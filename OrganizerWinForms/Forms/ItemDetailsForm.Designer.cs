namespace Organizer_Project.Forms
{
    partial class ItemDetailsForm
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
            this.EditButtonsFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.MainButtonsFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.MainTableLayout.SuspendLayout();
            this.EditButtonsFlowLayout.SuspendLayout();
            this.MainButtonsFlowLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTableLayout
            // 
            this.MainTableLayout.AutoSize = true;
            this.MainTableLayout.ColumnCount = 2;
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayout.Controls.Add(this.EditButtonsFlowLayout, 1, 2);
            this.MainTableLayout.Controls.Add(this.MainButtonsFlowLayout, 1, 0);
            this.MainTableLayout.Controls.Add(this.BackButton, 0, 0);
            this.MainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayout.Location = new System.Drawing.Point(12, 12);
            this.MainTableLayout.Name = "MainTableLayout";
            this.MainTableLayout.RowCount = 3;
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTableLayout.Size = new System.Drawing.Size(261, 237);
            this.MainTableLayout.TabIndex = 0;
            // 
            // EditButtonsFlowLayout
            // 
            this.EditButtonsFlowLayout.AutoSize = true;
            this.EditButtonsFlowLayout.CausesValidation = false;
            this.EditButtonsFlowLayout.Controls.Add(this.CancelBtn);
            this.EditButtonsFlowLayout.Controls.Add(this.SaveButton);
            this.EditButtonsFlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditButtonsFlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.EditButtonsFlowLayout.Location = new System.Drawing.Point(80, 193);
            this.EditButtonsFlowLayout.Name = "EditButtonsFlowLayout";
            this.EditButtonsFlowLayout.Size = new System.Drawing.Size(178, 41);
            this.EditButtonsFlowLayout.TabIndex = 0;
            this.EditButtonsFlowLayout.WrapContents = false;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CancelBtn.AutoSize = true;
            this.CancelBtn.CausesValidation = false;
            this.CancelBtn.Location = new System.Drawing.Point(94, 3);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Padding = new System.Windows.Forms.Padding(2);
            this.CancelBtn.Size = new System.Drawing.Size(81, 35);
            this.CancelBtn.TabIndex = 0;
            this.CancelBtn.TabStop = false;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaveButton.AutoSize = true;
            this.SaveButton.CausesValidation = false;
            this.SaveButton.Location = new System.Drawing.Point(7, 3);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Padding = new System.Windows.Forms.Padding(2);
            this.SaveButton.Size = new System.Drawing.Size(81, 35);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.TabStop = false;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // MainButtonsFlowLayout
            // 
            this.MainButtonsFlowLayout.AutoSize = true;
            this.MainButtonsFlowLayout.CausesValidation = false;
            this.MainButtonsFlowLayout.Controls.Add(this.DeleteButton);
            this.MainButtonsFlowLayout.Controls.Add(this.EditButton);
            this.MainButtonsFlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainButtonsFlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.MainButtonsFlowLayout.Location = new System.Drawing.Point(80, 3);
            this.MainButtonsFlowLayout.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.MainButtonsFlowLayout.Name = "MainButtonsFlowLayout";
            this.MainButtonsFlowLayout.Size = new System.Drawing.Size(173, 41);
            this.MainButtonsFlowLayout.TabIndex = 1;
            this.MainButtonsFlowLayout.WrapContents = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeleteButton.AutoSize = true;
            this.DeleteButton.CausesValidation = false;
            this.DeleteButton.Location = new System.Drawing.Point(89, 3);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Padding = new System.Windows.Forms.Padding(2);
            this.DeleteButton.Size = new System.Drawing.Size(81, 35);
            this.DeleteButton.TabIndex = 0;
            this.DeleteButton.TabStop = false;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EditButton.AutoSize = true;
            this.EditButton.CausesValidation = false;
            this.EditButton.Location = new System.Drawing.Point(2, 3);
            this.EditButton.Name = "EditButton";
            this.EditButton.Padding = new System.Windows.Forms.Padding(2);
            this.EditButton.Size = new System.Drawing.Size(81, 35);
            this.EditButton.TabIndex = 1;
            this.EditButton.TabStop = false;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BackButton.AutoSize = true;
            this.BackButton.CausesValidation = false;
            this.BackButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BackButton.Location = new System.Drawing.Point(12, 6);
            this.BackButton.Margin = new System.Windows.Forms.Padding(12, 3, 3, 3);
            this.BackButton.Name = "BackButton";
            this.BackButton.Padding = new System.Windows.Forms.Padding(2);
            this.BackButton.Size = new System.Drawing.Size(62, 35);
            this.BackButton.TabIndex = 2;
            this.BackButton.TabStop = false;
            this.BackButton.Text = "Back";
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ItemDetailsForm
            // 
            this.AcceptButton = this.SaveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(285, 261);
            this.Controls.Add(this.MainTableLayout);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 39);
            this.Name = "ItemDetailsForm";
            this.Padding = new System.Windows.Forms.Padding(12);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.OrganizerItemForm_Load);
            this.MainTableLayout.ResumeLayout(false);
            this.MainTableLayout.PerformLayout();
            this.EditButtonsFlowLayout.ResumeLayout(false);
            this.EditButtonsFlowLayout.PerformLayout();
            this.MainButtonsFlowLayout.ResumeLayout(false);
            this.MainButtonsFlowLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel MainTableLayout;
        private System.Windows.Forms.FlowLayoutPanel EditButtonsFlowLayout;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.FlowLayoutPanel MainButtonsFlowLayout;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button BackButton;
    }
}