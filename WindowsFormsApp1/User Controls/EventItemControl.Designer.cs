namespace Organizer_Project.User_Controls
{
    partial class EventItemControl
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
            this.MainTimeLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.PriorityLabel = new System.Windows.Forms.Label();
            this.EndTimeLabel = new System.Windows.Forms.Label();
            this.PriorityComboBox = new System.Windows.Forms.ComboBox();
            this.MainTimePicker = new System.Windows.Forms.DateTimePicker();
            this.NotesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.EndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AllDayCheckBox = new System.Windows.Forms.CheckBox();
            this.MainTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTableLayout
            // 
            this.MainTableLayout.AutoSize = true;
            this.MainTableLayout.ColumnCount = 4;
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTableLayout.Controls.Add(this.MainTimeLabel, 1, 2);
            this.MainTableLayout.Controls.Add(this.TitleLabel, 1, 0);
            this.MainTableLayout.Controls.Add(this.PriorityLabel, 1, 1);
            this.MainTableLayout.Controls.Add(this.EndTimeLabel, 1, 3);
            this.MainTableLayout.Controls.Add(this.PriorityComboBox, 2, 1);
            this.MainTableLayout.Controls.Add(this.MainTimePicker, 2, 2);
            this.MainTableLayout.Controls.Add(this.NotesRichTextBox, 1, 5);
            this.MainTableLayout.Controls.Add(this.TitleTextBox, 2, 0);
            this.MainTableLayout.Controls.Add(this.EndTimePicker, 2, 3);
            this.MainTableLayout.Controls.Add(this.AllDayCheckBox, 2, 4);
            this.MainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayout.Location = new System.Drawing.Point(8, 8);
            this.MainTableLayout.Margin = new System.Windows.Forms.Padding(5);
            this.MainTableLayout.Name = "MainTableLayout";
            this.MainTableLayout.RowCount = 6;
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayout.Size = new System.Drawing.Size(289, 308);
            this.MainTableLayout.TabIndex = 1;
            // 
            // MainTimeLabel
            // 
            this.MainTimeLabel.AutoSize = true;
            this.MainTimeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainTimeLabel.Location = new System.Drawing.Point(4, 90);
            this.MainTimeLabel.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.MainTimeLabel.Name = "MainTimeLabel";
            this.MainTimeLabel.Padding = new System.Windows.Forms.Padding(4);
            this.MainTimeLabel.Size = new System.Drawing.Size(73, 29);
            this.MainTimeLabel.TabIndex = 1;
            this.MainTimeLabel.Text = "Start";
            this.MainTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleLabel.Location = new System.Drawing.Point(4, 8);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Padding = new System.Windows.Forms.Padding(4);
            this.TitleLabel.Size = new System.Drawing.Size(73, 29);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Title";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PriorityLabel
            // 
            this.PriorityLabel.AutoSize = true;
            this.PriorityLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PriorityLabel.Location = new System.Drawing.Point(4, 49);
            this.PriorityLabel.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.PriorityLabel.Name = "PriorityLabel";
            this.PriorityLabel.Padding = new System.Windows.Forms.Padding(4);
            this.PriorityLabel.Size = new System.Drawing.Size(73, 29);
            this.PriorityLabel.TabIndex = 1;
            this.PriorityLabel.Text = "Priority";
            this.PriorityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EndTimeLabel
            // 
            this.EndTimeLabel.AutoSize = true;
            this.EndTimeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.EndTimeLabel.Location = new System.Drawing.Point(4, 131);
            this.EndTimeLabel.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.EndTimeLabel.Name = "EndTimeLabel";
            this.EndTimeLabel.Padding = new System.Windows.Forms.Padding(4);
            this.EndTimeLabel.Size = new System.Drawing.Size(73, 29);
            this.EndTimeLabel.TabIndex = 2;
            this.EndTimeLabel.Text = "End";
            this.EndTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PriorityComboBox
            // 
            this.PriorityComboBox.DisplayMember = "0";
            this.PriorityComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PriorityComboBox.FormattingEnabled = true;
            this.PriorityComboBox.Location = new System.Drawing.Point(85, 49);
            this.PriorityComboBox.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.PriorityComboBox.Name = "PriorityComboBox";
            this.PriorityComboBox.Size = new System.Drawing.Size(200, 29);
            this.PriorityComboBox.TabIndex = 1;
            // 
            // MainTimePicker
            // 
            this.MainTimePicker.CustomFormat = "ddd, dd MMM";
            this.MainTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.MainTimePicker.Location = new System.Drawing.Point(85, 90);
            this.MainTimePicker.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.MainTimePicker.Name = "MainTimePicker";
            this.MainTimePicker.ShowUpDown = true;
            this.MainTimePicker.Size = new System.Drawing.Size(200, 29);
            this.MainTimePicker.TabIndex = 2;
            // 
            // NotesRichTextBox
            // 
            this.NotesRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MainTableLayout.SetColumnSpan(this.NotesRichTextBox, 2);
            this.NotesRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NotesRichTextBox.Location = new System.Drawing.Point(3, 209);
            this.NotesRichTextBox.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.NotesRichTextBox.Name = "NotesRichTextBox";
            this.NotesRichTextBox.Size = new System.Drawing.Size(283, 96);
            this.NotesRichTextBox.TabIndex = 4;
            this.NotesRichTextBox.Text = "";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleTextBox.Location = new System.Drawing.Point(85, 8);
            this.TitleTextBox.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.TitleTextBox.Multiline = true;
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(200, 29);
            this.TitleTextBox.TabIndex = 0;
            // 
            // EndTimePicker
            // 
            this.EndTimePicker.CustomFormat = "ddd, dd MMM";
            this.EndTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EndTimePicker.Enabled = false;
            this.EndTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndTimePicker.Location = new System.Drawing.Point(85, 131);
            this.EndTimePicker.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.EndTimePicker.Name = "EndTimePicker";
            this.EndTimePicker.ShowUpDown = true;
            this.EndTimePicker.Size = new System.Drawing.Size(200, 29);
            this.EndTimePicker.TabIndex = 6;
            // 
            // AllDayCheckBox
            // 
            this.AllDayCheckBox.AutoSize = true;
            this.AllDayCheckBox.Checked = true;
            this.AllDayCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AllDayCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllDayCheckBox.Location = new System.Drawing.Point(85, 172);
            this.AllDayCheckBox.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.AllDayCheckBox.Name = "AllDayCheckBox";
            this.AllDayCheckBox.Size = new System.Drawing.Size(200, 25);
            this.AllDayCheckBox.TabIndex = 7;
            this.AllDayCheckBox.Text = "All Day";
            this.AllDayCheckBox.UseVisualStyleBackColor = true;
            this.AllDayCheckBox.CheckedChanged += new System.EventHandler(this.AllDayCheckBox_CheckedChanged);
            // 
            // EventItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.MainTableLayout);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "EventItemControl";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Size = new System.Drawing.Size(305, 324);
            this.Load += new System.EventHandler(this.EventControl_Load);
            this.MainTableLayout.ResumeLayout(false);
            this.MainTableLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTableLayout;
        private System.Windows.Forms.Label MainTimeLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label PriorityLabel;
        private System.Windows.Forms.Label EndTimeLabel;
        private System.Windows.Forms.ComboBox PriorityComboBox;
        private System.Windows.Forms.DateTimePicker MainTimePicker;
        private System.Windows.Forms.RichTextBox NotesRichTextBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.DateTimePicker EndTimePicker;
        private System.Windows.Forms.CheckBox AllDayCheckBox;
    }
}
