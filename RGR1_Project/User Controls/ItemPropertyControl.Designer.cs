namespace Organizer_Project.User_Controls
{
    partial class ItemPropertyControl
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
            this.EnableCheckBox = new System.Windows.Forms.CheckBox();
            this.PropertyComboBox = new System.Windows.Forms.ComboBox();
            this.InputNameLabel = new System.Windows.Forms.Label();
            this.PropertyTextBox = new System.Windows.Forms.TextBox();
            this.PropertyTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ControlsFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.MainFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.ControlsFlowLayout.SuspendLayout();
            this.MainFlowLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnableCheckBox
            // 
            this.EnableCheckBox.AutoSize = true;
            this.EnableCheckBox.Location = new System.Drawing.Point(806, 8);
            this.EnableCheckBox.Margin = new System.Windows.Forms.Padding(24, 8, 8, 8);
            this.EnableCheckBox.MinimumSize = new System.Drawing.Size(100, 0);
            this.EnableCheckBox.Name = "EnableCheckBox";
            this.EnableCheckBox.Padding = new System.Windows.Forms.Padding(4);
            this.EnableCheckBox.Size = new System.Drawing.Size(100, 33);
            this.EnableCheckBox.TabIndex = 0;
            this.EnableCheckBox.Text = "Enable";
            this.EnableCheckBox.UseVisualStyleBackColor = true;
            this.EnableCheckBox.CheckedChanged += new System.EventHandler(this.EnableCheckBox_CheckedChanged);
            // 
            // PropertyComboBox
            // 
            this.PropertyComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PropertyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PropertyComboBox.FormattingEnabled = true;
            this.PropertyComboBox.Items.AddRange(new object[] {
            "None"});
            this.PropertyComboBox.Location = new System.Drawing.Point(0, 0);
            this.PropertyComboBox.Margin = new System.Windows.Forms.Padding(0);
            this.PropertyComboBox.MinimumSize = new System.Drawing.Size(100, 0);
            this.PropertyComboBox.Name = "PropertyComboBox";
            this.PropertyComboBox.Size = new System.Drawing.Size(200, 29);
            this.PropertyComboBox.TabIndex = 0;
            // 
            // InputNameLabel
            // 
            this.InputNameLabel.AutoSize = true;
            this.InputNameLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputNameLabel.Location = new System.Drawing.Point(8, 8);
            this.InputNameLabel.Margin = new System.Windows.Forms.Padding(8);
            this.InputNameLabel.MinimumSize = new System.Drawing.Size(150, 0);
            this.InputNameLabel.Name = "InputNameLabel";
            this.InputNameLabel.Padding = new System.Windows.Forms.Padding(4);
            this.InputNameLabel.Size = new System.Drawing.Size(150, 29);
            this.InputNameLabel.TabIndex = 1;
            this.InputNameLabel.Text = "Text";
            this.InputNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PropertyTextBox
            // 
            this.PropertyTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PropertyTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PropertyTextBox.Location = new System.Drawing.Point(200, 3);
            this.PropertyTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.PropertyTextBox.MinimumSize = new System.Drawing.Size(100, 4);
            this.PropertyTextBox.Name = "PropertyTextBox";
            this.PropertyTextBox.Size = new System.Drawing.Size(200, 22);
            this.PropertyTextBox.TabIndex = 1;
            // 
            // PropertyTimePicker
            // 
            this.PropertyTimePicker.CustomFormat = "dd/MM/yyyy    HH:mm";
            this.PropertyTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.PropertyTimePicker.Location = new System.Drawing.Point(400, 0);
            this.PropertyTimePicker.Margin = new System.Windows.Forms.Padding(0);
            this.PropertyTimePicker.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.PropertyTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.PropertyTimePicker.MinimumSize = new System.Drawing.Size(100, 4);
            this.PropertyTimePicker.Name = "PropertyTimePicker";
            this.PropertyTimePicker.Size = new System.Drawing.Size(200, 29);
            this.PropertyTimePicker.TabIndex = 2;
            this.PropertyTimePicker.Value = new System.DateTime(2025, 11, 20, 0, 0, 0, 0);
            this.PropertyTimePicker.Visible = false;
            // 
            // ControlsFlowLayout
            // 
            this.ControlsFlowLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlsFlowLayout.AutoSize = true;
            this.ControlsFlowLayout.Controls.Add(this.PropertyComboBox);
            this.ControlsFlowLayout.Controls.Add(this.PropertyTextBox);
            this.ControlsFlowLayout.Controls.Add(this.PropertyTimePicker);
            this.ControlsFlowLayout.Location = new System.Drawing.Point(174, 10);
            this.ControlsFlowLayout.Margin = new System.Windows.Forms.Padding(8);
            this.ControlsFlowLayout.Name = "ControlsFlowLayout";
            this.ControlsFlowLayout.Size = new System.Drawing.Size(600, 29);
            this.ControlsFlowLayout.TabIndex = 3;
            this.ControlsFlowLayout.WrapContents = false;
            // 
            // MainFlowLayout
            // 
            this.MainFlowLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MainFlowLayout.AutoSize = true;
            this.MainFlowLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MainFlowLayout.Controls.Add(this.InputNameLabel);
            this.MainFlowLayout.Controls.Add(this.ControlsFlowLayout);
            this.MainFlowLayout.Controls.Add(this.EnableCheckBox);
            this.MainFlowLayout.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainFlowLayout.Location = new System.Drawing.Point(1, 14);
            this.MainFlowLayout.Margin = new System.Windows.Forms.Padding(4);
            this.MainFlowLayout.Name = "MainFlowLayout";
            this.MainFlowLayout.Size = new System.Drawing.Size(914, 49);
            this.MainFlowLayout.TabIndex = 1;
            this.MainFlowLayout.WrapContents = false;
            // 
            // ItemPropertyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.MainFlowLayout);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ItemPropertyControl";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.Size = new System.Drawing.Size(926, 73);
            this.Load += new System.EventHandler(this.FilterItemProperty_Load);
            this.ControlsFlowLayout.ResumeLayout(false);
            this.ControlsFlowLayout.PerformLayout();
            this.MainFlowLayout.ResumeLayout(false);
            this.MainFlowLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox EnableCheckBox;
        private System.Windows.Forms.Label InputNameLabel;
        private System.Windows.Forms.ComboBox PropertyComboBox;
        private System.Windows.Forms.TextBox PropertyTextBox;
        private System.Windows.Forms.DateTimePicker PropertyTimePicker;
        private System.Windows.Forms.FlowLayoutPanel ControlsFlowLayout;
        private System.Windows.Forms.FlowLayoutPanel MainFlowLayout;
    }
}
