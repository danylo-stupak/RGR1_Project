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
            this.InputNameLabel = new System.Windows.Forms.Label();
            this.MainFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.PropertyControlPanel = new System.Windows.Forms.Panel();
            this.MainFlowLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnableCheckBox
            // 
            this.EnableCheckBox.AutoSize = true;
            this.EnableCheckBox.Location = new System.Drawing.Point(262, 0);
            this.EnableCheckBox.Margin = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.EnableCheckBox.MinimumSize = new System.Drawing.Size(100, 0);
            this.EnableCheckBox.Name = "EnableCheckBox";
            this.EnableCheckBox.Padding = new System.Windows.Forms.Padding(4);
            this.EnableCheckBox.Size = new System.Drawing.Size(100, 25);
            this.EnableCheckBox.TabIndex = 0;
            this.EnableCheckBox.Text = "Enable";
            this.EnableCheckBox.UseVisualStyleBackColor = true;
            this.EnableCheckBox.CheckedChanged += new System.EventHandler(this.EnableCheckBox_CheckedChanged);
            // 
            // InputNameLabel
            // 
            this.InputNameLabel.AutoSize = true;
            this.InputNameLabel.Location = new System.Drawing.Point(0, 0);
            this.InputNameLabel.Margin = new System.Windows.Forms.Padding(0);
            this.InputNameLabel.MinimumSize = new System.Drawing.Size(120, 0);
            this.InputNameLabel.Name = "InputNameLabel";
            this.InputNameLabel.Padding = new System.Windows.Forms.Padding(4);
            this.InputNameLabel.Size = new System.Drawing.Size(120, 21);
            this.InputNameLabel.TabIndex = 1;
            this.InputNameLabel.Text = "Text";
            this.InputNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainFlowLayout
            // 
            this.MainFlowLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MainFlowLayout.AutoSize = true;
            this.MainFlowLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MainFlowLayout.Controls.Add(this.InputNameLabel);
            this.MainFlowLayout.Controls.Add(this.PropertyControlPanel);
            this.MainFlowLayout.Controls.Add(this.EnableCheckBox);
            this.MainFlowLayout.Location = new System.Drawing.Point(0, 6);
            this.MainFlowLayout.Margin = new System.Windows.Forms.Padding(0);
            this.MainFlowLayout.MinimumSize = new System.Drawing.Size(525, 0);
            this.MainFlowLayout.Name = "MainFlowLayout";
            this.MainFlowLayout.Size = new System.Drawing.Size(525, 25);
            this.MainFlowLayout.TabIndex = 1;
            this.MainFlowLayout.WrapContents = false;
            // 
            // PropertyControlPanel
            // 
            this.PropertyControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PropertyControlPanel.Location = new System.Drawing.Point(123, 3);
            this.PropertyControlPanel.MinimumSize = new System.Drawing.Size(120, 0);
            this.PropertyControlPanel.Name = "PropertyControlPanel";
            this.PropertyControlPanel.Size = new System.Drawing.Size(120, 19);
            this.PropertyControlPanel.TabIndex = 4;
            // 
            // ItemPropertyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.MainFlowLayout);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ItemPropertyControl";
            this.Size = new System.Drawing.Size(598, 36);
            this.Load += new System.EventHandler(this.ItemPropertyControl_Load);
            this.MainFlowLayout.ResumeLayout(false);
            this.MainFlowLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox EnableCheckBox;
        private System.Windows.Forms.Label InputNameLabel;
        private System.Windows.Forms.FlowLayoutPanel MainFlowLayout;
        private System.Windows.Forms.Panel PropertyControlPanel;
    }
}
