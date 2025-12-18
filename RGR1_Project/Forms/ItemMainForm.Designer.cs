
namespace Organizer_Project
{
    partial class ItemMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.OperationsTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.AddTaskButton = new System.Windows.Forms.Button();
            this.AddEventButton = new System.Windows.Forms.Button();
            this.StatsButton = new System.Windows.Forms.Button();
            this.SieveButtonsLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.SieveButton = new System.Windows.Forms.Button();
            this.ResetSieveButton = new System.Windows.Forms.Button();
            this.DashboardFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.MainTableLayout.SuspendLayout();
            this.OperationsTableLayout.SuspendLayout();
            this.SieveButtonsLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTableLayout
            // 
            this.MainTableLayout.AutoSize = true;
            this.MainTableLayout.ColumnCount = 2;
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainTableLayout.Controls.Add(this.OperationsTableLayout, 0, 0);
            this.MainTableLayout.Controls.Add(this.DashboardFlowLayout, 0, 1);
            this.MainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayout.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayout.Name = "MainTableLayout";
            this.MainTableLayout.Padding = new System.Windows.Forms.Padding(12);
            this.MainTableLayout.RowCount = 2;
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayout.Size = new System.Drawing.Size(586, 482);
            this.MainTableLayout.TabIndex = 0;
            // 
            // OperationsTableLayout
            // 
            this.OperationsTableLayout.AutoSize = true;
            this.OperationsTableLayout.ColumnCount = 4;
            this.MainTableLayout.SetColumnSpan(this.OperationsTableLayout, 2);
            this.OperationsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.OperationsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.OperationsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.OperationsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.OperationsTableLayout.Controls.Add(this.AddTaskButton, 0, 0);
            this.OperationsTableLayout.Controls.Add(this.AddEventButton, 1, 0);
            this.OperationsTableLayout.Controls.Add(this.StatsButton, 2, 0);
            this.OperationsTableLayout.Controls.Add(this.SieveButtonsLayout, 3, 0);
            this.OperationsTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OperationsTableLayout.Location = new System.Drawing.Point(15, 15);
            this.OperationsTableLayout.Name = "OperationsTableLayout";
            this.OperationsTableLayout.RowCount = 1;
            this.OperationsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.OperationsTableLayout.Size = new System.Drawing.Size(556, 51);
            this.OperationsTableLayout.TabIndex = 0;
            // 
            // AddTaskButton
            // 
            this.AddTaskButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddTaskButton.AutoSize = true;
            this.AddTaskButton.Location = new System.Drawing.Point(3, 5);
            this.AddTaskButton.Name = "AddTaskButton";
            this.AddTaskButton.Padding = new System.Windows.Forms.Padding(4);
            this.AddTaskButton.Size = new System.Drawing.Size(102, 41);
            this.AddTaskButton.TabIndex = 0;
            this.AddTaskButton.Text = "Add Task";
            this.AddTaskButton.UseVisualStyleBackColor = true;
            this.AddTaskButton.Click += new System.EventHandler(this.AddTaskButton_Click);
            // 
            // AddEventButton
            // 
            this.AddEventButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddEventButton.AutoSize = true;
            this.AddEventButton.Location = new System.Drawing.Point(111, 5);
            this.AddEventButton.Name = "AddEventButton";
            this.AddEventButton.Padding = new System.Windows.Forms.Padding(4);
            this.AddEventButton.Size = new System.Drawing.Size(108, 41);
            this.AddEventButton.TabIndex = 1;
            this.AddEventButton.Text = "Add Event";
            this.AddEventButton.UseVisualStyleBackColor = true;
            this.AddEventButton.Click += new System.EventHandler(this.AddEventButton_Click);
            // 
            // StatsButton
            // 
            this.StatsButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.StatsButton.AutoSize = true;
            this.StatsButton.Location = new System.Drawing.Point(234, 6);
            this.StatsButton.Name = "StatsButton";
            this.StatsButton.Padding = new System.Windows.Forms.Padding(4);
            this.StatsButton.Size = new System.Drawing.Size(113, 39);
            this.StatsButton.TabIndex = 2;
            this.StatsButton.Text = "Show Stats";
            this.StatsButton.UseVisualStyleBackColor = true;
            this.StatsButton.Click += new System.EventHandler(this.StatsButton_Click);
            // 
            // SieveButtonsLayout
            // 
            this.SieveButtonsLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SieveButtonsLayout.AutoSize = true;
            this.SieveButtonsLayout.Controls.Add(this.SieveButton);
            this.SieveButtonsLayout.Controls.Add(this.ResetSieveButton);
            this.SieveButtonsLayout.Location = new System.Drawing.Point(353, 3);
            this.SieveButtonsLayout.Name = "SieveButtonsLayout";
            this.SieveButtonsLayout.Size = new System.Drawing.Size(200, 45);
            this.SieveButtonsLayout.TabIndex = 3;
            this.SieveButtonsLayout.WrapContents = false;
            // 
            // SieveButton
            // 
            this.SieveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SieveButton.AutoSize = true;
            this.SieveButton.Location = new System.Drawing.Point(3, 3);
            this.SieveButton.Name = "SieveButton";
            this.SieveButton.Padding = new System.Windows.Forms.Padding(4);
            this.SieveButton.Size = new System.Drawing.Size(103, 39);
            this.SieveButton.TabIndex = 3;
            this.SieveButton.Text = "Sieve";
            this.SieveButton.UseVisualStyleBackColor = true;
            this.SieveButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // ResetSieveButton
            // 
            this.ResetSieveButton.AutoSize = true;
            this.ResetSieveButton.Enabled = false;
            this.ResetSieveButton.Location = new System.Drawing.Point(112, 3);
            this.ResetSieveButton.Name = "ResetSieveButton";
            this.ResetSieveButton.Padding = new System.Windows.Forms.Padding(4);
            this.ResetSieveButton.Size = new System.Drawing.Size(85, 39);
            this.ResetSieveButton.TabIndex = 4;
            this.ResetSieveButton.Text = "Reset";
            this.ResetSieveButton.UseVisualStyleBackColor = true;
            this.ResetSieveButton.Click += new System.EventHandler(this.ResetSieveButton_Click);
            // 
            // DashboardFlowLayout
            // 
            this.DashboardFlowLayout.AutoScroll = true;
            this.MainTableLayout.SetColumnSpan(this.DashboardFlowLayout, 3);
            this.DashboardFlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DashboardFlowLayout.Location = new System.Drawing.Point(15, 72);
            this.DashboardFlowLayout.Name = "DashboardFlowLayout";
            this.DashboardFlowLayout.Size = new System.Drawing.Size(556, 395);
            this.DashboardFlowLayout.TabIndex = 1;
            // 
            // ItemMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(586, 482);
            this.Controls.Add(this.MainTableLayout);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "ItemMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard — Tasks & Events";
            this.Load += new System.EventHandler(this.OrganizerForm_Load);
            this.MainTableLayout.ResumeLayout(false);
            this.MainTableLayout.PerformLayout();
            this.OperationsTableLayout.ResumeLayout(false);
            this.OperationsTableLayout.PerformLayout();
            this.SieveButtonsLayout.ResumeLayout(false);
            this.SieveButtonsLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTableLayout;
        private System.Windows.Forms.TableLayoutPanel OperationsTableLayout;
        private System.Windows.Forms.Button AddTaskButton;
        private System.Windows.Forms.Button AddEventButton;
        private System.Windows.Forms.FlowLayoutPanel DashboardFlowLayout;
        private System.Windows.Forms.Button StatsButton;
        private System.Windows.Forms.Button SieveButton;
        private System.Windows.Forms.FlowLayoutPanel SieveButtonsLayout;
        private System.Windows.Forms.Button ResetSieveButton;
    }
}

