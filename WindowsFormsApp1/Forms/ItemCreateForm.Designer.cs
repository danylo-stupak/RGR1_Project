namespace Organizer_Project.Forms
{
    partial class ItemCreateForm
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
            System.Windows.Forms.FlowLayoutPanel MainButtonsFlowLayout;
            this.CancelButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.MainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            MainButtonsFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            MainButtonsFlowLayout.SuspendLayout();
            this.MainTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainButtonsFlowLayout
            // 
            MainButtonsFlowLayout.AutoSize = true;
            MainButtonsFlowLayout.Controls.Add(this.CancelButton);
            MainButtonsFlowLayout.Controls.Add(this.CreateButton);
            MainButtonsFlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            MainButtonsFlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            MainButtonsFlowLayout.Location = new System.Drawing.Point(3, 226);
            MainButtonsFlowLayout.Name = "MainButtonsFlowLayout";
            MainButtonsFlowLayout.Size = new System.Drawing.Size(262, 57);
            MainButtonsFlowLayout.TabIndex = 2;
            MainButtonsFlowLayout.WrapContents = false;
            // 
            // CancelButton
            // 
            this.CancelButton.AutoSize = true;
            this.CancelButton.CausesValidation = false;
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(170, 8);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(8, 8, 12, 8);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Padding = new System.Windows.Forms.Padding(4);
            this.CancelButton.Size = new System.Drawing.Size(80, 41);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.TabStop = false;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // CreateButton
            // 
            this.CreateButton.AutoSize = true;
            this.CreateButton.CausesValidation = false;
            this.CreateButton.Location = new System.Drawing.Point(70, 8);
            this.CreateButton.Margin = new System.Windows.Forms.Padding(8);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Padding = new System.Windows.Forms.Padding(4);
            this.CreateButton.Size = new System.Drawing.Size(84, 41);
            this.CreateButton.TabIndex = 0;
            this.CreateButton.TabStop = false;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // MainTableLayout
            // 
            this.MainTableLayout.AutoSize = true;
            this.MainTableLayout.ColumnCount = 1;
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTableLayout.Controls.Add(MainButtonsFlowLayout, 0, 1);
            this.MainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayout.Location = new System.Drawing.Point(8, 8);
            this.MainTableLayout.Name = "MainTableLayout";
            this.MainTableLayout.RowCount = 2;
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTableLayout.Size = new System.Drawing.Size(268, 286);
            this.MainTableLayout.TabIndex = 0;
            // 
            // ItemCreateForm
            // 
            this.AcceptButton = this.CreateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(284, 302);
            this.Controls.Add(this.MainTableLayout);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "ItemCreateForm";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create";
            this.Load += new System.EventHandler(this.ItemCreateForm_Load);
            MainButtonsFlowLayout.ResumeLayout(false);
            MainButtonsFlowLayout.PerformLayout();
            this.MainTableLayout.ResumeLayout(false);
            this.MainTableLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainTableLayout;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button CancelButton;
    }
}