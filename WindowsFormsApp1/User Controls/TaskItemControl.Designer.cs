namespace Organizer_Project.User_Controls
{
    partial class TaskItemControl
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
            this.StatusLabel_Edit = new System.Windows.Forms.Label();
            this.PriorityComboBox = new System.Windows.Forms.ComboBox();
            this.MainTimePicker = new System.Windows.Forms.DateTimePicker();
            this.NotesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.GroupLabel_Edit = new System.Windows.Forms.Label();
            this.GroupTextBox = new System.Windows.Forms.TextBox();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ViewModeLayout = new System.Windows.Forms.TableLayoutPanel();
            this.MainTimeLabel_View = new System.Windows.Forms.Label();
            this.TitleLabel_View = new System.Windows.Forms.Label();
            this.PriorityLabel_View = new System.Windows.Forms.Label();
            this.StatusLabel_View = new System.Windows.Forms.Label();
            this.GroupLabel_View = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.PriorityLabel = new System.Windows.Forms.Label();
            this.MainTimeLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.GroupLabel = new System.Windows.Forms.Label();
            this.NotesLabel = new System.Windows.Forms.Label();
            this.MainFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.EditModeLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.ViewModeLayout.SuspendLayout();
            this.MainFlowLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditModeLayout
            // 
            this.EditModeLayout.AutoSize = true;
            this.EditModeLayout.CausesValidation = false;
            this.EditModeLayout.ColumnCount = 4;
            this.EditModeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.EditModeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.EditModeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.EditModeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.EditModeLayout.Controls.Add(this.MainTimeLabel_Edit, 1, 2);
            this.EditModeLayout.Controls.Add(this.TitleLabel_Edit, 1, 0);
            this.EditModeLayout.Controls.Add(this.PriorityLabel_Edit, 1, 1);
            this.EditModeLayout.Controls.Add(this.StatusLabel_Edit, 1, 3);
            this.EditModeLayout.Controls.Add(this.PriorityComboBox, 2, 1);
            this.EditModeLayout.Controls.Add(this.MainTimePicker, 2, 2);
            this.EditModeLayout.Controls.Add(this.NotesRichTextBox, 1, 5);
            this.EditModeLayout.Controls.Add(this.TitleTextBox, 2, 0);
            this.EditModeLayout.Controls.Add(this.StatusComboBox, 2, 3);
            this.EditModeLayout.Controls.Add(this.GroupLabel_Edit, 1, 4);
            this.EditModeLayout.Controls.Add(this.GroupTextBox, 2, 4);
            this.EditModeLayout.Location = new System.Drawing.Point(4, 6);
            this.EditModeLayout.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.EditModeLayout.Name = "EditModeLayout";
            this.EditModeLayout.RowCount = 6;
            this.EditModeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.EditModeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.EditModeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.EditModeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.EditModeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.EditModeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.EditModeLayout.Size = new System.Drawing.Size(317, 314);
            this.EditModeLayout.TabIndex = 0;
            this.EditModeLayout.Visible = false;
            // 
            // MainTimeLabel_Edit
            // 
            this.MainTimeLabel_Edit.AutoSize = true;
            this.MainTimeLabel_Edit.CausesValidation = false;
            this.MainTimeLabel_Edit.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainTimeLabel_Edit.Location = new System.Drawing.Point(4, 91);
            this.MainTimeLabel_Edit.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.MainTimeLabel_Edit.Name = "MainTimeLabel_Edit";
            this.MainTimeLabel_Edit.Padding = new System.Windows.Forms.Padding(4);
            this.MainTimeLabel_Edit.Size = new System.Drawing.Size(77, 29);
            this.MainTimeLabel_Edit.TabIndex = 1;
            this.MainTimeLabel_Edit.Text = "Due:";
            this.MainTimeLabel_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TitleLabel_Edit
            // 
            this.TitleLabel_Edit.AutoSize = true;
            this.TitleLabel_Edit.CausesValidation = false;
            this.TitleLabel_Edit.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleLabel_Edit.Location = new System.Drawing.Point(4, 8);
            this.TitleLabel_Edit.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.TitleLabel_Edit.Name = "TitleLabel_Edit";
            this.TitleLabel_Edit.Padding = new System.Windows.Forms.Padding(4);
            this.TitleLabel_Edit.Size = new System.Drawing.Size(77, 29);
            this.TitleLabel_Edit.TabIndex = 0;
            this.TitleLabel_Edit.Text = "Title:";
            this.TitleLabel_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PriorityLabel_Edit
            // 
            this.PriorityLabel_Edit.AutoSize = true;
            this.PriorityLabel_Edit.CausesValidation = false;
            this.PriorityLabel_Edit.Dock = System.Windows.Forms.DockStyle.Top;
            this.PriorityLabel_Edit.Location = new System.Drawing.Point(4, 50);
            this.PriorityLabel_Edit.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.PriorityLabel_Edit.Name = "PriorityLabel_Edit";
            this.PriorityLabel_Edit.Padding = new System.Windows.Forms.Padding(4);
            this.PriorityLabel_Edit.Size = new System.Drawing.Size(77, 29);
            this.PriorityLabel_Edit.TabIndex = 1;
            this.PriorityLabel_Edit.Text = "Priority:";
            this.PriorityLabel_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StatusLabel_Edit
            // 
            this.StatusLabel_Edit.AutoSize = true;
            this.StatusLabel_Edit.CausesValidation = false;
            this.StatusLabel_Edit.Dock = System.Windows.Forms.DockStyle.Top;
            this.StatusLabel_Edit.Location = new System.Drawing.Point(4, 132);
            this.StatusLabel_Edit.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.StatusLabel_Edit.Name = "StatusLabel_Edit";
            this.StatusLabel_Edit.Padding = new System.Windows.Forms.Padding(4);
            this.StatusLabel_Edit.Size = new System.Drawing.Size(77, 29);
            this.StatusLabel_Edit.TabIndex = 2;
            this.StatusLabel_Edit.Text = "Status:";
            this.StatusLabel_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PriorityComboBox
            // 
            this.PriorityComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PriorityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PriorityComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PriorityComboBox.FormattingEnabled = true;
            this.PriorityComboBox.Location = new System.Drawing.Point(89, 50);
            this.PriorityComboBox.Margin = new System.Windows.Forms.Padding(4, 8, 24, 4);
            this.PriorityComboBox.Name = "PriorityComboBox";
            this.PriorityComboBox.Size = new System.Drawing.Size(204, 29);
            this.PriorityComboBox.TabIndex = 1;
            // 
            // MainTimePicker
            // 
            this.MainTimePicker.CustomFormat = "ddd, dd MMM";
            this.MainTimePicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.MainTimePicker.Location = new System.Drawing.Point(89, 91);
            this.MainTimePicker.Margin = new System.Windows.Forms.Padding(4, 8, 24, 4);
            this.MainTimePicker.Name = "MainTimePicker";
            this.MainTimePicker.ShowUpDown = true;
            this.MainTimePicker.Size = new System.Drawing.Size(204, 29);
            this.MainTimePicker.TabIndex = 2;
            // 
            // NotesRichTextBox
            // 
            this.NotesRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EditModeLayout.SetColumnSpan(this.NotesRichTextBox, 2);
            this.NotesRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NotesRichTextBox.Location = new System.Drawing.Point(4, 211);
            this.NotesRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NotesRichTextBox.Name = "NotesRichTextBox";
            this.NotesRichTextBox.Size = new System.Drawing.Size(309, 99);
            this.NotesRichTextBox.TabIndex = 4;
            this.NotesRichTextBox.Text = "";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TitleTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleTextBox.Location = new System.Drawing.Point(89, 8);
            this.TitleTextBox.Margin = new System.Windows.Forms.Padding(4, 8, 24, 4);
            this.TitleTextBox.Multiline = true;
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(204, 30);
            this.TitleTextBox.TabIndex = 0;
            this.TitleTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.TitleTextBox_Validating);
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.DisplayMember = "1";
            this.StatusComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Location = new System.Drawing.Point(89, 132);
            this.StatusComboBox.Margin = new System.Windows.Forms.Padding(4, 8, 24, 4);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(204, 29);
            this.StatusComboBox.TabIndex = 3;
            // 
            // GroupLabel_Edit
            // 
            this.GroupLabel_Edit.AutoSize = true;
            this.GroupLabel_Edit.CausesValidation = false;
            this.GroupLabel_Edit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupLabel_Edit.Location = new System.Drawing.Point(4, 173);
            this.GroupLabel_Edit.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.GroupLabel_Edit.Name = "GroupLabel_Edit";
            this.GroupLabel_Edit.Padding = new System.Windows.Forms.Padding(4);
            this.GroupLabel_Edit.Size = new System.Drawing.Size(77, 30);
            this.GroupLabel_Edit.TabIndex = 5;
            this.GroupLabel_Edit.Text = "Group:";
            this.GroupLabel_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GroupTextBox
            // 
            this.GroupTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GroupTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupTextBox.Location = new System.Drawing.Point(89, 173);
            this.GroupTextBox.Margin = new System.Windows.Forms.Padding(4, 8, 24, 4);
            this.GroupTextBox.Multiline = true;
            this.GroupTextBox.Name = "GroupTextBox";
            this.GroupTextBox.Size = new System.Drawing.Size(204, 30);
            this.GroupTextBox.TabIndex = 6;
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErrorProvider.ContainerControl = this;
            // 
            // ViewModeLayout
            // 
            this.ViewModeLayout.AutoSize = true;
            this.ViewModeLayout.CausesValidation = false;
            this.ViewModeLayout.ColumnCount = 4;
            this.ViewModeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ViewModeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ViewModeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ViewModeLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.ViewModeLayout.Controls.Add(this.MainTimeLabel_View, 1, 2);
            this.ViewModeLayout.Controls.Add(this.TitleLabel_View, 1, 0);
            this.ViewModeLayout.Controls.Add(this.PriorityLabel_View, 1, 1);
            this.ViewModeLayout.Controls.Add(this.StatusLabel_View, 1, 3);
            this.ViewModeLayout.Controls.Add(this.GroupLabel_View, 1, 4);
            this.ViewModeLayout.Controls.Add(this.TitleLabel, 2, 0);
            this.ViewModeLayout.Controls.Add(this.PriorityLabel, 2, 1);
            this.ViewModeLayout.Controls.Add(this.MainTimeLabel, 2, 2);
            this.ViewModeLayout.Controls.Add(this.StatusLabel, 2, 3);
            this.ViewModeLayout.Controls.Add(this.GroupLabel, 2, 4);
            this.ViewModeLayout.Controls.Add(this.NotesLabel, 1, 5);
            this.ViewModeLayout.Location = new System.Drawing.Point(4, 332);
            this.ViewModeLayout.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ViewModeLayout.Name = "ViewModeLayout";
            this.ViewModeLayout.RowCount = 6;
            this.ViewModeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ViewModeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ViewModeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ViewModeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ViewModeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ViewModeLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ViewModeLayout.Size = new System.Drawing.Size(313, 320);
            this.ViewModeLayout.TabIndex = 1;
            this.ViewModeLayout.Visible = false;
            // 
            // MainTimeLabel_View
            // 
            this.MainTimeLabel_View.AutoSize = true;
            this.MainTimeLabel_View.CausesValidation = false;
            this.MainTimeLabel_View.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainTimeLabel_View.Location = new System.Drawing.Point(4, 91);
            this.MainTimeLabel_View.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.MainTimeLabel_View.Name = "MainTimeLabel_View";
            this.MainTimeLabel_View.Padding = new System.Windows.Forms.Padding(4);
            this.MainTimeLabel_View.Size = new System.Drawing.Size(77, 29);
            this.MainTimeLabel_View.TabIndex = 1;
            this.MainTimeLabel_View.Text = "Due:";
            this.MainTimeLabel_View.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TitleLabel_View
            // 
            this.TitleLabel_View.CausesValidation = false;
            this.TitleLabel_View.Location = new System.Drawing.Point(4, 8);
            this.TitleLabel_View.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.TitleLabel_View.Name = "TitleLabel_View";
            this.TitleLabel_View.Padding = new System.Windows.Forms.Padding(4);
            this.TitleLabel_View.Size = new System.Drawing.Size(73, 29);
            this.TitleLabel_View.TabIndex = 0;
            this.TitleLabel_View.Text = "Title:";
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
            this.PriorityLabel_View.Size = new System.Drawing.Size(77, 29);
            this.PriorityLabel_View.TabIndex = 1;
            this.PriorityLabel_View.Text = "Priority:";
            this.PriorityLabel_View.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StatusLabel_View
            // 
            this.StatusLabel_View.AutoSize = true;
            this.StatusLabel_View.CausesValidation = false;
            this.StatusLabel_View.Dock = System.Windows.Forms.DockStyle.Top;
            this.StatusLabel_View.Location = new System.Drawing.Point(4, 133);
            this.StatusLabel_View.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.StatusLabel_View.Name = "StatusLabel_View";
            this.StatusLabel_View.Padding = new System.Windows.Forms.Padding(4);
            this.StatusLabel_View.Size = new System.Drawing.Size(77, 29);
            this.StatusLabel_View.TabIndex = 2;
            this.StatusLabel_View.Text = "Status:";
            this.StatusLabel_View.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GroupLabel_View
            // 
            this.GroupLabel_View.AutoSize = true;
            this.GroupLabel_View.CausesValidation = false;
            this.GroupLabel_View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupLabel_View.Location = new System.Drawing.Point(4, 175);
            this.GroupLabel_View.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.GroupLabel_View.Name = "GroupLabel_View";
            this.GroupLabel_View.Padding = new System.Windows.Forms.Padding(4);
            this.GroupLabel_View.Size = new System.Drawing.Size(77, 30);
            this.GroupLabel_View.TabIndex = 5;
            this.GroupLabel_View.Text = "Group:";
            this.GroupLabel_View.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TitleLabel
            // 
            this.TitleLabel.CausesValidation = false;
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleLabel.Location = new System.Drawing.Point(89, 8);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4, 8, 24, 4);
            this.TitleLabel.MinimumSize = new System.Drawing.Size(200, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Padding = new System.Windows.Forms.Padding(4);
            this.TitleLabel.Size = new System.Drawing.Size(200, 29);
            this.TitleLabel.TabIndex = 6;
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PriorityLabel
            // 
            this.PriorityLabel.CausesValidation = false;
            this.PriorityLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PriorityLabel.Location = new System.Drawing.Point(89, 49);
            this.PriorityLabel.Margin = new System.Windows.Forms.Padding(4, 8, 24, 4);
            this.PriorityLabel.Name = "PriorityLabel";
            this.PriorityLabel.Padding = new System.Windows.Forms.Padding(4);
            this.PriorityLabel.Size = new System.Drawing.Size(200, 30);
            this.PriorityLabel.TabIndex = 7;
            this.PriorityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainTimeLabel
            // 
            this.MainTimeLabel.CausesValidation = false;
            this.MainTimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTimeLabel.Location = new System.Drawing.Point(89, 91);
            this.MainTimeLabel.Margin = new System.Windows.Forms.Padding(4, 8, 24, 4);
            this.MainTimeLabel.Name = "MainTimeLabel";
            this.MainTimeLabel.Padding = new System.Windows.Forms.Padding(4);
            this.MainTimeLabel.Size = new System.Drawing.Size(200, 30);
            this.MainTimeLabel.TabIndex = 8;
            this.MainTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StatusLabel
            // 
            this.StatusLabel.CausesValidation = false;
            this.StatusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatusLabel.Location = new System.Drawing.Point(89, 133);
            this.StatusLabel.Margin = new System.Windows.Forms.Padding(4, 8, 24, 4);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Padding = new System.Windows.Forms.Padding(4);
            this.StatusLabel.Size = new System.Drawing.Size(200, 30);
            this.StatusLabel.TabIndex = 9;
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // GroupLabel
            // 
            this.GroupLabel.CausesValidation = false;
            this.GroupLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupLabel.Location = new System.Drawing.Point(89, 175);
            this.GroupLabel.Margin = new System.Windows.Forms.Padding(4, 8, 24, 4);
            this.GroupLabel.Name = "GroupLabel";
            this.GroupLabel.Padding = new System.Windows.Forms.Padding(4);
            this.GroupLabel.Size = new System.Drawing.Size(200, 30);
            this.GroupLabel.TabIndex = 10;
            this.GroupLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NotesLabel
            // 
            this.NotesLabel.CausesValidation = false;
            this.ViewModeLayout.SetColumnSpan(this.NotesLabel, 2);
            this.NotesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NotesLabel.Location = new System.Drawing.Point(4, 217);
            this.NotesLabel.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.NotesLabel.MinimumSize = new System.Drawing.Size(0, 99);
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.Padding = new System.Windows.Forms.Padding(4);
            this.NotesLabel.Size = new System.Drawing.Size(305, 99);
            this.NotesLabel.TabIndex = 11;
            // 
            // MainFlowLayout
            // 
            this.MainFlowLayout.AutoSize = true;
            this.MainFlowLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MainFlowLayout.Controls.Add(this.EditModeLayout);
            this.MainFlowLayout.Controls.Add(this.ViewModeLayout);
            this.MainFlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.MainFlowLayout.Location = new System.Drawing.Point(11, 11);
            this.MainFlowLayout.Name = "MainFlowLayout";
            this.MainFlowLayout.Size = new System.Drawing.Size(325, 658);
            this.MainFlowLayout.TabIndex = 2;
            this.MainFlowLayout.WrapContents = false;
            // 
            // TaskItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.MainFlowLayout);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "TaskItemControl";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Size = new System.Drawing.Size(347, 680);
            this.Load += new System.EventHandler(this.TaskControl_Load);
            this.EditModeLayout.ResumeLayout(false);
            this.EditModeLayout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ViewModeLayout.ResumeLayout(false);
            this.ViewModeLayout.PerformLayout();
            this.MainFlowLayout.ResumeLayout(false);
            this.MainFlowLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel EditModeLayout;
        private System.Windows.Forms.Label MainTimeLabel_Edit;
        private System.Windows.Forms.Label TitleLabel_Edit;
        private System.Windows.Forms.Label PriorityLabel_Edit;
        private System.Windows.Forms.Label StatusLabel_Edit;
        private System.Windows.Forms.ComboBox PriorityComboBox;
        private System.Windows.Forms.DateTimePicker MainTimePicker;
        private System.Windows.Forms.RichTextBox NotesRichTextBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.Label GroupLabel_Edit;
        private System.Windows.Forms.TextBox GroupTextBox;
        private System.Windows.Forms.TableLayoutPanel ViewModeLayout;
        private System.Windows.Forms.Label MainTimeLabel_View;
        private System.Windows.Forms.Label TitleLabel_View;
        private System.Windows.Forms.Label PriorityLabel_View;
        private System.Windows.Forms.Label StatusLabel_View;
        private System.Windows.Forms.Label GroupLabel_View;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label PriorityLabel;
        private System.Windows.Forms.Label MainTimeLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label GroupLabel;
        private System.Windows.Forms.Label NotesLabel;
        private System.Windows.Forms.FlowLayoutPanel MainFlowLayout;
    }
}
