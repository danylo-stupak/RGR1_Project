namespace Organizer_Project.User_Controls
{
    partial class OrganizerItemControl
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
            this.PriorityLabel = new System.Windows.Forms.Label();
            this.MainTimeLabel = new System.Windows.Forms.Label();
            this.EndTimeLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.DetailsButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.MainTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTableLayout
            // 
            this.MainTableLayout.AutoSize = true;
            this.MainTableLayout.ColumnCount = 3;
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTableLayout.Controls.Add(this.PriorityLabel, 0, 1);
            this.MainTableLayout.Controls.Add(this.MainTimeLabel, 2, 1);
            this.MainTableLayout.Controls.Add(this.EndTimeLabel, 2, 2);
            this.MainTableLayout.Controls.Add(this.TypeLabel, 0, 0);
            this.MainTableLayout.Controls.Add(this.TitleLabel, 1, 0);
            this.MainTableLayout.Controls.Add(this.DetailsButton, 0, 3);
            this.MainTableLayout.Controls.Add(this.StatusLabel, 0, 2);
            this.MainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayout.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.MainTableLayout.Name = "MainTableLayout";
            this.MainTableLayout.RowCount = 4;
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.MainTableLayout.Size = new System.Drawing.Size(296, 154);
            this.MainTableLayout.TabIndex = 1;
            // 
            // PriorityLabel
            // 
            this.PriorityLabel.AutoSize = true;
            this.PriorityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PriorityLabel.Location = new System.Drawing.Point(5, 39);
            this.PriorityLabel.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.PriorityLabel.Name = "PriorityLabel";
            this.PriorityLabel.Padding = new System.Windows.Forms.Padding(5, 5, 10, 5);
            this.PriorityLabel.Size = new System.Drawing.Size(68, 29);
            this.PriorityLabel.TabIndex = 11;
            this.PriorityLabel.Text = "Priority";
            this.PriorityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainTimeLabel
            // 
            this.MainTimeLabel.AutoSize = true;
            this.MainTimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTimeLabel.Location = new System.Drawing.Point(192, 39);
            this.MainTimeLabel.Margin = new System.Windows.Forms.Padding(5, 10, 5, 0);
            this.MainTimeLabel.Name = "MainTimeLabel";
            this.MainTimeLabel.Padding = new System.Windows.Forms.Padding(5, 5, 10, 5);
            this.MainTimeLabel.Size = new System.Drawing.Size(99, 29);
            this.MainTimeLabel.TabIndex = 2;
            this.MainTimeLabel.Text = "Start/Due";
            this.MainTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EndTimeLabel
            // 
            this.EndTimeLabel.AutoSize = true;
            this.EndTimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EndTimeLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EndTimeLabel.Location = new System.Drawing.Point(192, 68);
            this.EndTimeLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.EndTimeLabel.Name = "EndTimeLabel";
            this.EndTimeLabel.Padding = new System.Windows.Forms.Padding(5, 5, 10, 5);
            this.EndTimeLabel.Size = new System.Drawing.Size(99, 29);
            this.EndTimeLabel.TabIndex = 3;
            this.EndTimeLabel.Text = "End";
            this.EndTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(0, 0);
            this.TypeLabel.Margin = new System.Windows.Forms.Padding(0);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.TypeLabel.Size = new System.Drawing.Size(46, 29);
            this.TypeLabel.TabIndex = 0;
            this.TypeLabel.Text = "Item";
            this.TypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TitleLabel
            // 
            this.MainTableLayout.SetColumnSpan(this.TitleLabel, 2);
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleLabel.Location = new System.Drawing.Point(82, 0);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Padding = new System.Windows.Forms.Padding(5, 5, 10, 5);
            this.TitleLabel.Size = new System.Drawing.Size(210, 29);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Title";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DetailsButton
            // 
            this.DetailsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DetailsButton.AutoSize = true;
            this.MainTableLayout.SetColumnSpan(this.DetailsButton, 3);
            this.DetailsButton.Location = new System.Drawing.Point(164, 112);
            this.DetailsButton.Margin = new System.Windows.Forms.Padding(5, 15, 10, 5);
            this.DetailsButton.Name = "DetailsButton";
            this.DetailsButton.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.DetailsButton.Size = new System.Drawing.Size(122, 37);
            this.DetailsButton.TabIndex = 23;
            this.DetailsButton.Text = "Details";
            this.DetailsButton.UseVisualStyleBackColor = true;
            this.DetailsButton.Click += new System.EventHandler(this.DetailsButton_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatusLabel.Location = new System.Drawing.Point(5, 68);
            this.StatusLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Padding = new System.Windows.Forms.Padding(5, 5, 10, 5);
            this.StatusLabel.Size = new System.Drawing.Size(68, 29);
            this.StatusLabel.TabIndex = 9;
            this.StatusLabel.Text = "Status";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OrganizerItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.MainTableLayout);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "OrganizerItemControl";
            this.Size = new System.Drawing.Size(296, 154);
            this.Load += new System.EventHandler(this.OrganizerItemControl_Load);
            this.MainTableLayout.ResumeLayout(false);
            this.MainTableLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTableLayout;
        private System.Windows.Forms.Label MainTimeLabel;
        private System.Windows.Forms.Label EndTimeLabel;
        private System.Windows.Forms.Label PriorityLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Button DetailsButton;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label TitleLabel;
    }
}
