# Organizer WinForms Project (Async & SQL)

A desktop organizer application built with C# and WinForms, featuring asynchronous database operations and a robust filtering system. 
This project is architected to be as cross-platform friendly as possible by decoupling business logic from the UI.

## Features

- **Asynchronous CRUD:** All database operations (Create, Read, Update, Delete) are non-blocking to keep the UI responsive.
- **Dual Item Types:** Support for both Tasks (with status/overdue logic) and Events (with start/end times).
- **Advanced Filtering (Sieve):** Filter and sort your dashboard by text, priority, type, and dates using a lazy-evaluated LINQ query.
- **SQL Persistence:** Uses Entity Framework 6 (Code First) with a Table-per-Hierarchy (TPH) mapping.

## Prerequisites
- Visual Studio 2022 or higher
- .NET Framework 4.7.2 SDK
- SQL Server Express LocalDB  

![Visual Studio installer](./assets/images/readme-workload-0.jpg)*Visual Studio Installer*  

![.NET workload](./assets/images/readme-workload-1.jpg)*.NET desktop workload*  

![SQL Server workload](./assets/images/readme-workload-2.jpg)*SQL Server workload*  


## Getting Started
Follow these steps to launch the project:

### 1. Initial Setup
- Clone the repository.
- Open OrganizerProject.sln in Visual Studio.
- Restore NuGet Packages:
	- Right-click the Solution
	- Select "Restore NuGet Packages" (this installs Entity Framework 6.5.1).

### 2. Database Configuration
The app is configured to use LocalDB. If you need to change the server instance, update the connection string in `App.config`:
```xml
<connectionStrings>
    <add name="OrganizerDb" 
         connectionString="Server=(localdb)\ProjectModels;Database=OrganizerDatabase;Trusted_Connection=True;" 
         providerName="System.Data.SqlClient" />
</connectionStrings>
```

### 3. Initialize the Database
Open the Package Manager Console (Tools > NuGet Package Manager) and run:
```powershell
Update-Database
```

### 4. Run the App
Press `F5` to Run in Debug Mode. Or click green 'play' button in Visual Studio.  
*Note: To launch qpp faster press `Shift + F5` to run without Debug Mode.*

## Developer Notes
- **Constructors:** All items are automatically assigned a new `Guid` and default `DateTime.Today` upon creation to prevent SQL MinDate crashes.  
- **Async Logic:** When calling service methods, always `await` them in `async void` event handlers to ensure the `RerenderDashboardLayout()` call waits for the database to finish.  
- **Cleanup:** If you want to start with a fresh database, use the `ClearAsync()` method in the service or manually delete the `.mdf` file in your build directory.  

## UML Diagram
```mermaid
classDiagram
    %% --- Data Models Layer ---
    namespace Interfaces {
        class OrganizerItem {
            <<abstract>>
            +Guid Id
            +string Title
            +string Notes
            +Priority Priority
            +DateTime Time
            +ItemType? Type
        }
        class Priority { <<enumeration>> }
        class ItemType { <<enumeration>> }
    }

    namespace Models {
        class TaskItem {
            +TaskStatus Status
            +string Group
        }
        class EventItem {
            +DateTime EndTime
            +bool IsAllDay
        }
        class TaskStatus { <<enumeration>> }
    }

    OrganizerItem <|-- TaskItem : Inherits
    OrganizerItem <|-- EventItem : Inherits
    OrganizerItem --> Priority
    OrganizerItem --> ItemType
    TaskItem --> TaskStatus

    %% --- Data Access Layer ---
    namespace Data {
        class OrganizerDbContext {
            +DbSet<OrganizerItem> Items
            +Task<int> SaveChangesAsync()
        }
    }
    OrganizerDbContext "1" --> "*" OrganizerItem : Manages

    %% --- Service Layer ---
    namespace Service {
        class IManagerService {
            <<interface>>
            +BindingSource BindingSource
            +Task AddItemAsync(OrganizerItem item)
            +Task UpdateItemAsync(OrganizerItem item)
            +Task DeleteItemAsync(OrganizerItem item)
            +Task ApplySieveAsync(ItemSieveDTO sieve)
            +Task ClearAsync()
        }

        class OrganizerSqlAsyncService {
            -OrganizerDbContext _context
            +BindingSource BindingSource
            +Task AddItemAsync(...)
            +Task UpdateItemAsync(...)
            +Task DeleteItemAsync(...)
        }
        class ItemSieveDTO {
            +string SearchText
            +ItemType? Type
            +DateTime? MinDate
        }
    }

    IManagerService <|.. OrganizerSqlAsyncService : Implements
    OrganizerSqlAsyncService --> OrganizerDbContext : Uses
    IManagerService ..> ItemSieveDTO : Uses dependency
    OrganizerSqlAsyncService ..> OrganizerItem : Manipulates

    %% --- Presentation Layer (Forms & Controls) ---
    namespace Forms {
        class ItemMainForm {
            -IManagerService _service
            -void RerenderDashboardLayout()
            -async btnRefresh_Click()
        }
        class ItemCreateForm {
        }
        class ItemDetailsForm {
        }
        class ItemSieveForm {
        }
    }
    namespace UserControls {
        class ItemControl {
            +OrganizerItem GetItem()
            +void SetItem(OrganizerItem item)
        }
        class ItemCard {
        }
    }

    ItemMainForm --> IManagerService : Injects/Uses
    ItemMainForm ..> ItemCreateForm : Creates
    ItemMainForm ..> ItemDetailsForm : Creates
    ItemMainForm ..> ItemSieveForm : Creates
    ItemMainForm --> "*" ItemCard : Displays many
    
    ItemCreateForm *-- ItemControl : Contains
    ItemDetailsForm *-- ItemControl : Contains
    ItemControl ..> OrganizerItem : Depends on structure
  
```
