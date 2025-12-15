namespace Organizer_Project.User_Controls
{
    partial class TaskItemDemoControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.PriorityNameLabel = new System.Windows.Forms.Label();
            this.MainTimeNameLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.DetailsButton = new System.Windows.Forms.Button();
            this.StatusNameLabel = new System.Windows.Forms.Label();
            this.MainTimeValueLabel = new System.Windows.Forms.Label();
            this.PriorityValueLabel = new System.Windows.Forms.Label();
            this.StatusValueLabel = new System.Windows.Forms.Label();
            this.MainTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTableLayout
            // 
            this.MainTableLayout.AutoSize = true;
            this.MainTableLayout.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.MainTableLayout.ColumnCount = 4;
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTableLayout.Controls.Add(this.PriorityNameLabel, 0, 1);
            this.MainTableLayout.Controls.Add(this.MainTimeNameLabel, 2, 1);
            this.MainTableLayout.Controls.Add(this.TypeLabel, 0, 0);
            this.MainTableLayout.Controls.Add(this.TitleLabel, 1, 0);
            this.MainTableLayout.Controls.Add(this.DetailsButton, 0, 3);
            this.MainTableLayout.Controls.Add(this.StatusNameLabel, 0, 2);
            this.MainTableLayout.Controls.Add(this.MainTimeValueLabel, 3, 1);
            this.MainTableLayout.Controls.Add(this.PriorityValueLabel, 1, 1);
            this.MainTableLayout.Controls.Add(this.StatusValueLabel, 1, 2);
            this.MainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayout.Location = new System.Drawing.Point(8, 8);
            this.MainTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.MainTableLayout.Name = "MainTableLayout";
            this.MainTableLayout.RowCount = 4;
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayout.Size = new System.Drawing.Size(284, 151);
            this.MainTableLayout.TabIndex = 1;
            // 
            // PriorityNameLabel
            // 
            this.PriorityNameLabel.AutoSize = true;
            this.PriorityNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PriorityNameLabel.Location = new System.Drawing.Point(0, 42);
            this.PriorityNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.PriorityNameLabel.Name = "PriorityNameLabel";
            this.PriorityNameLabel.Padding = new System.Windows.Forms.Padding(4);
            this.PriorityNameLabel.Size = new System.Drawing.Size(64, 27);
            this.PriorityNameLabel.TabIndex = 11;
            this.PriorityNameLabel.Text = "Priority:";
            this.PriorityNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainTimeNameLabel
            // 
            this.MainTimeNameLabel.AutoSize = true;
            this.MainTimeNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTimeNameLabel.Location = new System.Drawing.Point(153, 42);
            this.MainTimeNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.MainTimeNameLabel.Name = "MainTimeNameLabel";
            this.MainTimeNameLabel.Padding = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.MainTimeNameLabel.Size = new System.Drawing.Size(41, 27);
            this.MainTimeNameLabel.TabIndex = 2;
            this.MainTimeNameLabel.Text = "Due:";
            this.MainTimeNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.BackColor = System.Drawing.Color.LightGreen;
            this.TypeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TypeLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeLabel.Location = new System.Drawing.Point(0, 0);
            this.TypeLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Padding = new System.Windows.Forms.Padding(5);
            this.TypeLabel.Size = new System.Drawing.Size(64, 34);
            this.TypeLabel.TabIndex = 0;
            this.TypeLabel.Text = "Task";
            this.TypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.MainTableLayout.SetColumnSpan(this.TitleLabel, 3);
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(64, 0);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.TitleLabel.Size = new System.Drawing.Size(220, 34);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Title";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DetailsButton
            // 
            this.DetailsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DetailsButton.AutoSize = true;
            this.MainTableLayout.SetColumnSpan(this.DetailsButton, 4);
            this.DetailsButton.Location = new System.Drawing.Point(208, 111);
            this.DetailsButton.Margin = new System.Windows.Forms.Padding(5, 15, 10, 5);
            this.DetailsButton.Name = "DetailsButton";
            this.DetailsButton.Padding = new System.Windows.Forms.Padding(3);
            this.DetailsButton.Size = new System.Drawing.Size(66, 35);
            this.DetailsButton.TabIndex = 23;
            this.DetailsButton.Text = "Details";
            this.DetailsButton.UseVisualStyleBackColor = true;
            this.DetailsButton.Click += new System.EventHandler(this.DetailsButton_Click);
            // 
            // StatusNameLabel
            // 
            this.StatusNameLabel.AutoSize = true;
            this.StatusNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatusNameLabel.Location = new System.Drawing.Point(0, 69);
            this.StatusNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.StatusNameLabel.Name = "StatusNameLabel";
            this.StatusNameLabel.Padding = new System.Windows.Forms.Padding(4);
            this.StatusNameLabel.Size = new System.Drawing.Size(64, 27);
            this.StatusNameLabel.TabIndex = 9;
            this.StatusNameLabel.Text = "Status:";
            this.StatusNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainTimeValueLabel
            // 
            this.MainTimeValueLabel.AutoSize = true;
            this.MainTimeValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTimeValueLabel.Location = new System.Drawing.Point(194, 42);
            this.MainTimeValueLabel.Margin = new System.Windows.Forms.Padding(0);
            this.MainTimeValueLabel.Name = "MainTimeValueLabel";
            this.MainTimeValueLabel.Padding = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.MainTimeValueLabel.Size = new System.Drawing.Size(90, 27);
            this.MainTimeValueLabel.TabIndex = 24;
            this.MainTimeValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PriorityValueLabel
            // 
            this.PriorityValueLabel.AutoSize = true;
            this.PriorityValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PriorityValueLabel.Location = new System.Drawing.Point(64, 42);
            this.PriorityValueLabel.Margin = new System.Windows.Forms.Padding(0);
            this.PriorityValueLabel.Name = "PriorityValueLabel";
            this.PriorityValueLabel.Padding = new System.Windows.Forms.Padding(4);
            this.PriorityValueLabel.Size = new System.Drawing.Size(89, 27);
            this.PriorityValueLabel.TabIndex = 25;
            this.PriorityValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StatusValueLabel
            // 
            this.StatusValueLabel.AutoSize = true;
            this.StatusValueLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatusValueLabel.Location = new System.Drawing.Point(64, 69);
            this.StatusValueLabel.Margin = new System.Windows.Forms.Padding(0);
            this.StatusValueLabel.Name = "StatusValueLabel";
            this.StatusValueLabel.Padding = new System.Windows.Forms.Padding(4);
            this.StatusValueLabel.Size = new System.Drawing.Size(89, 27);
            this.StatusValueLabel.TabIndex = 26;
            this.StatusValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TaskItemDemoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Green;
            this.Controls.Add(this.MainTableLayout);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(300, 0);
            this.Name = "TaskItemDemoControl";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Size = new System.Drawing.Size(300, 167);
            this.Load += new System.EventHandler(this.TaskItemDemoControl_Load);
            this.MainTableLayout.ResumeLayout(false);
            this.MainTableLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTableLayout;
        private System.Windows.Forms.Label MainTimeNameLabel;
        private System.Windows.Forms.Label PriorityNameLabel;
        private System.Windows.Forms.Label StatusNameLabel;
        private System.Windows.Forms.Button DetailsButton;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label MainTimeValueLabel;
        private System.Windows.Forms.Label PriorityValueLabel;
        private System.Windows.Forms.Label StatusValueLabel;
    }
}
