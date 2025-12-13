
namespace Organizer_Project
{
    partial class OrganizerForm
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
            this.ButtonsTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.AddTaskButton = new System.Windows.Forms.Button();
            this.AddEventButton = new System.Windows.Forms.Button();
            this.DashboardFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.MainTableLayout.SuspendLayout();
            this.ButtonsTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTableLayout
            // 
            this.MainTableLayout.ColumnCount = 2;
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainTableLayout.Controls.Add(this.ButtonsTableLayout, 0, 0);
            this.MainTableLayout.Controls.Add(this.DashboardFlowLayout, 0, 1);
            this.MainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayout.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayout.Name = "MainTableLayout";
            this.MainTableLayout.Padding = new System.Windows.Forms.Padding(12);
            this.MainTableLayout.RowCount = 2;
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayout.Size = new System.Drawing.Size(484, 461);
            this.MainTableLayout.TabIndex = 0;
            // 
            // ButtonsTableLayout
            // 
            this.ButtonsTableLayout.ColumnCount = 3;
            this.MainTableLayout.SetColumnSpan(this.ButtonsTableLayout, 2);
            this.ButtonsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ButtonsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ButtonsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonsTableLayout.Controls.Add(this.AddTaskButton, 0, 0);
            this.ButtonsTableLayout.Controls.Add(this.AddEventButton, 1, 0);
            this.ButtonsTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonsTableLayout.Location = new System.Drawing.Point(15, 15);
            this.ButtonsTableLayout.Name = "ButtonsTableLayout";
            this.ButtonsTableLayout.RowCount = 1;
            this.ButtonsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonsTableLayout.Size = new System.Drawing.Size(454, 100);
            this.ButtonsTableLayout.TabIndex = 0;
            // 
            // AddTaskButton
            // 
            this.AddTaskButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddTaskButton.AutoSize = true;
            this.AddTaskButton.Location = new System.Drawing.Point(3, 29);
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
            this.AddEventButton.Location = new System.Drawing.Point(111, 29);
            this.AddEventButton.Name = "AddEventButton";
            this.AddEventButton.Padding = new System.Windows.Forms.Padding(4);
            this.AddEventButton.Size = new System.Drawing.Size(108, 41);
            this.AddEventButton.TabIndex = 1;
            this.AddEventButton.Text = "Add Event";
            this.AddEventButton.UseVisualStyleBackColor = true;
            this.AddEventButton.Click += new System.EventHandler(this.AddEventButton_Click);
            // 
            // DashboardFlowLayout
            // 
            this.DashboardFlowLayout.AutoScroll = true;
            this.MainTableLayout.SetColumnSpan(this.DashboardFlowLayout, 3);
            this.DashboardFlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DashboardFlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.DashboardFlowLayout.Location = new System.Drawing.Point(15, 121);
            this.DashboardFlowLayout.Name = "DashboardFlowLayout";
            this.DashboardFlowLayout.Size = new System.Drawing.Size(454, 325);
            this.DashboardFlowLayout.TabIndex = 1;
            this.DashboardFlowLayout.WrapContents = false;
            // 
            // OrganizerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.MainTableLayout);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "OrganizerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard — Tasks & Events";
            this.Load += new System.EventHandler(this.OrganizerForm_Load);
            this.MainTableLayout.ResumeLayout(false);
            this.ButtonsTableLayout.ResumeLayout(false);
            this.ButtonsTableLayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTableLayout;
        private System.Windows.Forms.TableLayoutPanel ButtonsTableLayout;
        private System.Windows.Forms.Button AddTaskButton;
        private System.Windows.Forms.Button AddEventButton;
        private System.Windows.Forms.FlowLayoutPanel DashboardFlowLayout;
    }
}

