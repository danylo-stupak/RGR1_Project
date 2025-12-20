namespace Organizer_Project.UserControls
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
            this.components = new System.ComponentModel.Container();
            this.EditModeLayout = new System.Windows.Forms.TableLayoutPanel();
            this.MainTimeLabel_Edit = new System.Windows.Forms.Label();
            this.TitleLabel_Edit = new System.Windows.Forms.Label();
            this.PriorityLabel_Edit = new System.Windows.Forms.Label();
            this.EndTimeLabel_Edit = new System.Windows.Forms.Label();
            this.PriorityComboBox = new System.Windows.Forms.ComboBox();
            this.MainTimePicker = new System.Windows.Forms.DateTimePicker();
            this.NotesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.EndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AllDayCheckBox_Edit = new System.Windows.Forms.CheckBox();
            this.MainFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.ViewModeLayout = new System.Windows.Forms.TableLayoutPanel();
            this.MainTimeLabel_View = new System.Windows.Forms.Label();
            this.TitleLabel_View = new System.Windows.Forms.Label();
            this.PriorityLabel_View = new System.Windows.Forms.Label();
            this.EndTimeLabel_View = new System.Windows.Forms.Label();
            this.AllDayCheckBox_View = new System.Windows.Forms.CheckBox();
            this.NotesLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.PriorityLabel = new System.Windows.Forms.Label();
            this.MainTimeLabel = new System.Windows.Forms.Label();
            this.EndTimeLabel = new System.Windows.Forms.Label();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.EditModeLayout.SuspendLayout();
            this.MainFlowLayout.SuspendLayout();
            this.ViewModeLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // EditModeLayout
            // 
            this.EditModeLayout.AutoSize = true;
            this.EditModeLayout.ColumnCount = 4;
            this.EditModeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EditModeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.EditModeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.EditModeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EditModeLayout.Controls.Add(this.MainTimeLabel_Edit, 1, 2);
            this.EditModeLayout.Controls.Add(this.TitleLabel_Edit, 1, 0);
            this.EditModeLayout.Controls.Add(this.PriorityLabel_Edit, 1, 1);
            this.EditModeLayout.Controls.Add(this.EndTimeLabel_Edit, 1, 3);
            this.EditModeLayout.Controls.Add(this.PriorityComboBox, 2, 1);
            this.EditModeLayout.Controls.Add(this.MainTimePicker, 2, 2);
            this.EditModeLayout.Controls.Add(this.NotesRichTextBox, 1, 5);
            this.EditModeLayout.Controls.Add(this.TitleTextBox, 2, 0);
            this.EditModeLayout.Controls.Add(this.EndTimePicker, 2, 3);
            this.EditModeLayout.Controls.Add(this.AllDayCheckBox_Edit, 2, 4);
            this.EditModeLayout.Location = new System.Drawing.Point(5, 5);
            this.EditModeLayout.Margin = new System.Windows.Forms.Padding(5);
            this.EditModeLayout.Name = "EditModeLayout";
            this.EditModeLayout.RowCount = 6;
            this.EditModeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.EditModeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.EditModeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.EditModeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.EditModeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.EditModeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.EditModeLayout.Size = new System.Drawing.Size(309, 362);
            this.EditModeLayout.TabIndex = 1;
            this.EditModeLayout.Visible = false;
            // 
            // MainTimeLabel_Edit
            // 
            this.MainTimeLabel_Edit.AutoSize = true;
            this.MainTimeLabel_Edit.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainTimeLabel_Edit.Location = new System.Drawing.Point(4, 90);
            this.MainTimeLabel_Edit.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.MainTimeLabel_Edit.Name = "MainTimeLabel_Edit";
            this.MainTimeLabel_Edit.Padding = new System.Windows.Forms.Padding(4);
            this.MainTimeLabel_Edit.Size = new System.Drawing.Size(73, 29);
            this.MainTimeLabel_Edit.TabIndex = 1;
            this.MainTimeLabel_Edit.Text = "Start";
            this.MainTimeLabel_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TitleLabel_Edit
            // 
            this.TitleLabel_Edit.AutoSize = true;
            this.TitleLabel_Edit.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleLabel_Edit.Location = new System.Drawing.Point(4, 8);
            this.TitleLabel_Edit.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.TitleLabel_Edit.Name = "TitleLabel_Edit";
            this.TitleLabel_Edit.Padding = new System.Windows.Forms.Padding(4);
            this.TitleLabel_Edit.Size = new System.Drawing.Size(73, 29);
            this.TitleLabel_Edit.TabIndex = 0;
            this.TitleLabel_Edit.Text = "Title";
            this.TitleLabel_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PriorityLabel_Edit
            // 
            this.PriorityLabel_Edit.AutoSize = true;
            this.PriorityLabel_Edit.Dock = System.Windows.Forms.DockStyle.Top;
            this.PriorityLabel_Edit.Location = new System.Drawing.Point(4, 49);
            this.PriorityLabel_Edit.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.PriorityLabel_Edit.Name = "PriorityLabel_Edit";
            this.PriorityLabel_Edit.Padding = new System.Windows.Forms.Padding(4);
            this.PriorityLabel_Edit.Size = new System.Drawing.Size(73, 29);
            this.PriorityLabel_Edit.TabIndex = 1;
            this.PriorityLabel_Edit.Text = "Priority";
            this.PriorityLabel_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EndTimeLabel_Edit
            // 
            this.EndTimeLabel_Edit.AutoSize = true;
            this.EndTimeLabel_Edit.Dock = System.Windows.Forms.DockStyle.Top;
            this.EndTimeLabel_Edit.Location = new System.Drawing.Point(4, 131);
            this.EndTimeLabel_Edit.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.EndTimeLabel_Edit.Name = "EndTimeLabel_Edit";
            this.EndTimeLabel_Edit.Padding = new System.Windows.Forms.Padding(4);
            this.EndTimeLabel_Edit.Size = new System.Drawing.Size(73, 29);
            this.EndTimeLabel_Edit.TabIndex = 2;
            this.EndTimeLabel_Edit.Text = "End";
            this.EndTimeLabel_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PriorityComboBox
            // 
            this.PriorityComboBox.CausesValidation = false;
            this.PriorityComboBox.DisplayMember = "0";
            this.PriorityComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PriorityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PriorityComboBox.FormattingEnabled = true;
            this.PriorityComboBox.Location = new System.Drawing.Point(85, 49);
            this.PriorityComboBox.Margin = new System.Windows.Forms.Padding(4, 8, 24, 4);
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
            this.MainTimePicker.Margin = new System.Windows.Forms.Padding(4, 8, 24, 4);
            this.MainTimePicker.Name = "MainTimePicker";
            this.MainTimePicker.ShowUpDown = true;
            this.MainTimePicker.Size = new System.Drawing.Size(200, 29);
            this.MainTimePicker.TabIndex = 2;
            this.MainTimePicker.Value = new System.DateTime(2025, 11, 3, 0, 0, 0, 0);
            // 
            // NotesRichTextBox
            // 
            this.NotesRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EditModeLayout.SetColumnSpan(this.NotesRichTextBox, 2);
            this.NotesRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NotesRichTextBox.Location = new System.Drawing.Point(3, 209);
            this.NotesRichTextBox.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.NotesRichTextBox.MinimumSize = new System.Drawing.Size(0, 150);
            this.NotesRichTextBox.Name = "NotesRichTextBox";
            this.NotesRichTextBox.Size = new System.Drawing.Size(303, 150);
            this.NotesRichTextBox.TabIndex = 5;
            this.NotesRichTextBox.Text = "";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TitleTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleTextBox.Location = new System.Drawing.Point(85, 8);
            this.TitleTextBox.Margin = new System.Windows.Forms.Padding(4, 8, 24, 4);
            this.TitleTextBox.MinimumSize = new System.Drawing.Size(200, 0);
            this.TitleTextBox.Multiline = true;
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(200, 29);
            this.TitleTextBox.TabIndex = 0;
            this.TitleTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TitleTextBox_Validating);
            // 
            // EndTimePicker
            // 
            this.EndTimePicker.CustomFormat = "ddd, dd MMM";
            this.EndTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EndTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndTimePicker.Location = new System.Drawing.Point(85, 131);
            this.EndTimePicker.Margin = new System.Windows.Forms.Padding(4, 8, 24, 4);
            this.EndTimePicker.Name = "EndTimePicker";
            this.EndTimePicker.ShowUpDown = true;
            this.EndTimePicker.Size = new System.Drawing.Size(200, 29);
            this.EndTimePicker.TabIndex = 3;
            this.EndTimePicker.Value = new System.DateTime(2025, 11, 10, 0, 0, 0, 0);
            this.EndTimePicker.Validating += new System.ComponentModel.CancelEventHandler(this.EndTimePicker_Validating);
            // 
            // AllDayCheckBox_Edit
            // 
            this.AllDayCheckBox_Edit.AutoSize = true;
            this.AllDayCheckBox_Edit.Checked = true;
            this.AllDayCheckBox_Edit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AllDayCheckBox_Edit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllDayCheckBox_Edit.FlatAppearance.BorderSize = 0;
            this.AllDayCheckBox_Edit.Location = new System.Drawing.Point(85, 172);
            this.AllDayCheckBox_Edit.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.AllDayCheckBox_Edit.Name = "AllDayCheckBox_Edit";
            this.AllDayCheckBox_Edit.Size = new System.Drawing.Size(220, 25);
            this.AllDayCheckBox_Edit.TabIndex = 4;
            this.AllDayCheckBox_Edit.Text = "All Day";
            this.AllDayCheckBox_Edit.CheckedChanged += new System.EventHandler(this.AllDayCheckBox_CheckedChanged);
            // 
            // MainFlowLayout
            // 
            this.MainFlowLayout.AutoSize = true;
            this.MainFlowLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MainFlowLayout.Controls.Add(this.EditModeLayout);
            this.MainFlowLayout.Controls.Add(this.ViewModeLayout);
            this.MainFlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainFlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.MainFlowLayout.Location = new System.Drawing.Point(8, 8);
            this.MainFlowLayout.Name = "MainFlowLayout";
            this.MainFlowLayout.Size = new System.Drawing.Size(319, 745);
            this.MainFlowLayout.TabIndex = 2;
            this.MainFlowLayout.WrapContents = false;
            // 
            // ViewModeLayout
            // 
            this.ViewModeLayout.AutoSize = true;
            this.ViewModeLayout.ColumnCount = 4;
            this.ViewModeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ViewModeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ViewModeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ViewModeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ViewModeLayout.Controls.Add(this.MainTimeLabel_View, 1, 2);
            this.ViewModeLayout.Controls.Add(this.TitleLabel_View, 1, 0);
            this.ViewModeLayout.Controls.Add(this.PriorityLabel_View, 1, 1);
            this.ViewModeLayout.Controls.Add(this.EndTimeLabel_View, 1, 3);
            this.ViewModeLayout.Controls.Add(this.AllDayCheckBox_View, 2, 4);
            this.ViewModeLayout.Controls.Add(this.NotesLabel, 1, 5);
            this.ViewModeLayout.Controls.Add(this.TitleLabel, 2, 0);
            this.ViewModeLayout.Controls.Add(this.PriorityLabel, 2, 1);
            this.ViewModeLayout.Controls.Add(this.MainTimeLabel, 2, 2);
            this.ViewModeLayout.Controls.Add(this.EndTimeLabel, 2, 3);
            this.ViewModeLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewModeLayout.Location = new System.Drawing.Point(5, 377);
            this.ViewModeLayout.Margin = new System.Windows.Forms.Padding(5);
            this.ViewModeLayout.Name = "ViewModeLayout";
            this.ViewModeLayout.RowCount = 6;
            this.ViewModeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ViewModeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ViewModeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ViewModeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ViewModeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ViewModeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ViewModeLayout.Size = new System.Drawing.Size(309, 363);
            this.ViewModeLayout.TabIndex = 2;
            this.ViewModeLayout.Visible = false;
            // 
            // MainTimeLabel_View
            // 
            this.MainTimeLabel_View.AutoSize = true;
            this.MainTimeLabel_View.CausesValidation = false;
            this.MainTimeLabel_View.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainTimeLabel_View.Location = new System.Drawing.Point(4, 90);
            this.MainTimeLabel_View.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.MainTimeLabel_View.Name = "MainTimeLabel_View";
            this.MainTimeLabel_View.Padding = new System.Windows.Forms.Padding(4);
            this.MainTimeLabel_View.Size = new System.Drawing.Size(73, 29);
            this.MainTimeLabel_View.TabIndex = 1;
            this.MainTimeLabel_View.Text = "Start";
            this.MainTimeLabel_View.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TitleLabel_View
            // 
            this.TitleLabel_View.AutoSize = true;
            this.TitleLabel_View.CausesValidation = false;
            this.TitleLabel_View.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleLabel_View.Location = new System.Drawing.Point(4, 8);
            this.TitleLabel_View.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.TitleLabel_View.Name = "TitleLabel_View";
            this.TitleLabel_View.Padding = new System.Windows.Forms.Padding(4);
            this.TitleLabel_View.Size = new System.Drawing.Size(73, 29);
            this.TitleLabel_View.TabIndex = 0;
            this.TitleLabel_View.Text = "Title";
            this.TitleLabel_View.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PriorityLabel_View
            // 
            this.PriorityLabel_View.AutoSize = true;
            this.PriorityLabel_View.CausesValidation = false;
            this.PriorityLabel_View.Dock = System.Windows.Forms.DockStyle.Top;
            this.PriorityLabel_View.Location = new System.Drawing.Point(4, 49);
            this.PriorityLabel_View.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.PriorityLabel_View.Name = "PriorityLabel_View";
            this.PriorityLabel_View.Padding = new System.Windows.Forms.Padding(4);
            this.PriorityLabel_View.Size = new System.Drawing.Size(73, 29);
            this.PriorityLabel_View.TabIndex = 1;
            this.PriorityLabel_View.Text = "Priority";
            this.PriorityLabel_View.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // EndTimeLabel_View
            // 
            this.EndTimeLabel_View.AutoSize = true;
            this.EndTimeLabel_View.CausesValidation = false;
            this.EndTimeLabel_View.Dock = System.Windows.Forms.DockStyle.Top;
            this.EndTimeLabel_View.Location = new System.Drawing.Point(4, 131);
            this.EndTimeLabel_View.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.EndTimeLabel_View.Name = "EndTimeLabel_View";
            this.EndTimeLabel_View.Padding = new System.Windows.Forms.Padding(4);
            this.EndTimeLabel_View.Size = new System.Drawing.Size(73, 29);
            this.EndTimeLabel_View.TabIndex = 2;
            this.EndTimeLabel_View.Text = "End";
            this.EndTimeLabel_View.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AllDayCheckBox_View
            // 
            this.AllDayCheckBox_View.AutoSize = true;
            this.AllDayCheckBox_View.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AllDayCheckBox_View.CausesValidation = false;
            this.AllDayCheckBox_View.Checked = true;
            this.AllDayCheckBox_View.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AllDayCheckBox_View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllDayCheckBox_View.Enabled = false;
            this.AllDayCheckBox_View.FlatAppearance.BorderSize = 0;
            this.AllDayCheckBox_View.Location = new System.Drawing.Point(85, 172);
            this.AllDayCheckBox_View.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.AllDayCheckBox_View.Name = "AllDayCheckBox_View";
            this.AllDayCheckBox_View.Size = new System.Drawing.Size(220, 25);
            this.AllDayCheckBox_View.TabIndex = 7;
            this.AllDayCheckBox_View.TabStop = false;
            this.AllDayCheckBox_View.Text = "All Day";
            // 
            // NotesLabel
            // 
            this.NotesLabel.AutoSize = true;
            this.ViewModeLayout.SetColumnSpan(this.NotesLabel, 2);
            this.NotesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NotesLabel.Location = new System.Drawing.Point(4, 209);
            this.NotesLabel.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.NotesLabel.MinimumSize = new System.Drawing.Size(0, 150);
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.Padding = new System.Windows.Forms.Padding(4);
            this.NotesLabel.Size = new System.Drawing.Size(301, 150);
            this.NotesLabel.TabIndex = 9;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.CausesValidation = false;
            this.TitleLabel.Location = new System.Drawing.Point(85, 8);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 8, 24, 4);
            this.TitleLabel.MinimumSize = new System.Drawing.Size(200, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Padding = new System.Windows.Forms.Padding(4);
            this.TitleLabel.Size = new System.Drawing.Size(200, 29);
            this.TitleLabel.TabIndex = 8;
            // 
            // PriorityLabel
            // 
            this.PriorityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PriorityLabel.AutoSize = true;
            this.PriorityLabel.CausesValidation = false;
            this.PriorityLabel.Location = new System.Drawing.Point(85, 49);
            this.PriorityLabel.Margin = new System.Windows.Forms.Padding(4, 8, 24, 4);
            this.PriorityLabel.Name = "PriorityLabel";
            this.PriorityLabel.Padding = new System.Windows.Forms.Padding(4);
            this.PriorityLabel.Size = new System.Drawing.Size(200, 29);
            this.PriorityLabel.TabIndex = 10;
            // 
            // MainTimeLabel
            // 
            this.MainTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTimeLabel.AutoSize = true;
            this.MainTimeLabel.CausesValidation = false;
            this.MainTimeLabel.Location = new System.Drawing.Point(85, 90);
            this.MainTimeLabel.Margin = new System.Windows.Forms.Padding(4, 8, 24, 4);
            this.MainTimeLabel.Name = "MainTimeLabel";
            this.MainTimeLabel.Padding = new System.Windows.Forms.Padding(4);
            this.MainTimeLabel.Size = new System.Drawing.Size(200, 29);
            this.MainTimeLabel.TabIndex = 11;
            // 
            // EndTimeLabel
            // 
            this.EndTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EndTimeLabel.AutoSize = true;
            this.EndTimeLabel.CausesValidation = false;
            this.EndTimeLabel.Location = new System.Drawing.Point(85, 131);
            this.EndTimeLabel.Margin = new System.Windows.Forms.Padding(4, 8, 24, 4);
            this.EndTimeLabel.Name = "EndTimeLabel";
            this.EndTimeLabel.Padding = new System.Windows.Forms.Padding(4);
            this.EndTimeLabel.Size = new System.Drawing.Size(200, 29);
            this.EndTimeLabel.TabIndex = 12;
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErrorProvider.ContainerControl = this;
            // 
            // EventItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.MainFlowLayout);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "EventItemControl";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Size = new System.Drawing.Size(335, 761);
            this.Load += new System.EventHandler(this.EventControl_Load);
            this.EditModeLayout.ResumeLayout(false);
            this.EditModeLayout.PerformLayout();
            this.MainFlowLayout.ResumeLayout(false);
            this.MainFlowLayout.PerformLayout();
            this.ViewModeLayout.ResumeLayout(false);
            this.ViewModeLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel EditModeLayout;
        private System.Windows.Forms.Label MainTimeLabel_Edit;
        private System.Windows.Forms.Label TitleLabel_Edit;
        private System.Windows.Forms.Label PriorityLabel_Edit;
        private System.Windows.Forms.Label EndTimeLabel_Edit;
        private System.Windows.Forms.ComboBox PriorityComboBox;
        private System.Windows.Forms.DateTimePicker MainTimePicker;
        private System.Windows.Forms.RichTextBox NotesRichTextBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.DateTimePicker EndTimePicker;
        private System.Windows.Forms.CheckBox AllDayCheckBox_Edit;
        private System.Windows.Forms.FlowLayoutPanel MainFlowLayout;
        private System.Windows.Forms.TableLayoutPanel ViewModeLayout;
        private System.Windows.Forms.Label MainTimeLabel_View;
        private System.Windows.Forms.Label TitleLabel_View;
        private System.Windows.Forms.Label PriorityLabel_View;
        private System.Windows.Forms.Label EndTimeLabel_View;
        private System.Windows.Forms.CheckBox AllDayCheckBox_View;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label NotesLabel;
        private System.Windows.Forms.Label PriorityLabel;
        private System.Windows.Forms.Label MainTimeLabel;
        private System.Windows.Forms.Label EndTimeLabel;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}
