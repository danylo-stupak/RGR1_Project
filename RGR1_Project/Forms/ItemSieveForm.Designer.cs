namespace Organizer_Project.Forms
{
    partial class ItemSieveForm
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
            this.FilteringTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.ButtonsFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.MainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.FilterGroupBox = new System.Windows.Forms.GroupBox();
            this.SortGroupBox = new System.Windows.Forms.GroupBox();
            this.SortingTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonsFlowLayout.SuspendLayout();
            this.MainTableLayout.SuspendLayout();
            this.FilterGroupBox.SuspendLayout();
            this.SortGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FilteringTableLayout
            // 
            this.FilteringTableLayout.AutoSize = true;
            this.FilteringTableLayout.ColumnCount = 1;
            this.FilteringTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.FilteringTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilteringTableLayout.Location = new System.Drawing.Point(3, 25);
            this.FilteringTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.FilteringTableLayout.Name = "FilteringTableLayout";
            this.FilteringTableLayout.Padding = new System.Windows.Forms.Padding(24, 0, 24, 0);
            this.FilteringTableLayout.RowCount = 6;
            this.FilteringTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FilteringTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FilteringTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FilteringTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FilteringTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FilteringTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.FilteringTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.FilteringTableLayout.Size = new System.Drawing.Size(464, 0);
            this.FilteringTableLayout.TabIndex = 10;
            // 
            // ApplyButton
            // 
            this.ApplyButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ApplyButton.AutoSize = true;
            this.ApplyButton.Location = new System.Drawing.Point(0, 0);
            this.ApplyButton.Margin = new System.Windows.Forms.Padding(0);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Padding = new System.Windows.Forms.Padding(2);
            this.ApplyButton.Size = new System.Drawing.Size(70, 36);
            this.ApplyButton.TabIndex = 0;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CancelBtn.AutoSize = true;
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(97, 0);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(27, 0, 0, 0);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Padding = new System.Windows.Forms.Padding(2);
            this.CancelBtn.Size = new System.Drawing.Size(75, 36);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ButtonsFlowLayout
            // 
            this.ButtonsFlowLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonsFlowLayout.AutoSize = true;
            this.ButtonsFlowLayout.Controls.Add(this.CancelBtn);
            this.ButtonsFlowLayout.Controls.Add(this.ApplyButton);
            this.ButtonsFlowLayout.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.ButtonsFlowLayout.Location = new System.Drawing.Point(288, 399);
            this.ButtonsFlowLayout.Margin = new System.Windows.Forms.Padding(4, 18, 16, 18);
            this.ButtonsFlowLayout.Name = "ButtonsFlowLayout";
            this.ButtonsFlowLayout.Size = new System.Drawing.Size(172, 36);
            this.ButtonsFlowLayout.TabIndex = 1;
            this.ButtonsFlowLayout.WrapContents = false;
            // 
            // MainTableLayout
            // 
            this.MainTableLayout.AutoSize = true;
            this.MainTableLayout.ColumnCount = 1;
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayout.Controls.Add(this.FilterGroupBox, 0, 0);
            this.MainTableLayout.Controls.Add(this.ButtonsFlowLayout, 0, 2);
            this.MainTableLayout.Controls.Add(this.SortGroupBox, 0, 1);
            this.MainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayout.Location = new System.Drawing.Point(4, 4);
            this.MainTableLayout.Name = "MainTableLayout";
            this.MainTableLayout.RowCount = 3;
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTableLayout.Size = new System.Drawing.Size(476, 453);
            this.MainTableLayout.TabIndex = 4;
            // 
            // FilterGroupBox
            // 
            this.FilterGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterGroupBox.AutoSize = true;
            this.FilterGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FilterGroupBox.Controls.Add(this.FilteringTableLayout);
            this.FilterGroupBox.Location = new System.Drawing.Point(3, 3);
            this.FilterGroupBox.Name = "FilterGroupBox";
            this.FilterGroupBox.Size = new System.Drawing.Size(470, 28);
            this.FilterGroupBox.TabIndex = 0;
            this.FilterGroupBox.TabStop = false;
            this.FilterGroupBox.Text = "Filter";
            // 
            // SortGroupBox
            // 
            this.SortGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SortGroupBox.AutoSize = true;
            this.SortGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SortGroupBox.Controls.Add(this.SortingTableLayout);
            this.SortGroupBox.Location = new System.Drawing.Point(3, 37);
            this.SortGroupBox.Name = "SortGroupBox";
            this.SortGroupBox.Size = new System.Drawing.Size(470, 28);
            this.SortGroupBox.TabIndex = 2;
            this.SortGroupBox.TabStop = false;
            this.SortGroupBox.Text = "Sort";
            // 
            // SortingTableLayout
            // 
            this.SortingTableLayout.AutoSize = true;
            this.SortingTableLayout.ColumnCount = 1;
            this.SortingTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SortingTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SortingTableLayout.Location = new System.Drawing.Point(3, 25);
            this.SortingTableLayout.Margin = new System.Windows.Forms.Padding(0);
            this.SortingTableLayout.Name = "SortingTableLayout";
            this.SortingTableLayout.Padding = new System.Windows.Forms.Padding(24, 0, 24, 0);
            this.SortingTableLayout.RowCount = 6;
            this.SortingTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SortingTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SortingTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SortingTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SortingTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.SortingTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SortingTableLayout.Size = new System.Drawing.Size(464, 0);
            this.SortingTableLayout.TabIndex = 13;
            // 
            // ItemSieveForm
            // 
            this.AcceptButton = this.ApplyButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.CancelButton = this.CancelBtn;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.MainTableLayout);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "ItemSieveForm";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sieve Form";
            this.Load += new System.EventHandler(this.FilterItemsForm_Load);
            this.ButtonsFlowLayout.ResumeLayout(false);
            this.ButtonsFlowLayout.PerformLayout();
            this.MainTableLayout.ResumeLayout(false);
            this.MainTableLayout.PerformLayout();
            this.FilterGroupBox.ResumeLayout(false);
            this.FilterGroupBox.PerformLayout();
            this.SortGroupBox.ResumeLayout(false);
            this.SortGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel FilteringTableLayout;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.FlowLayoutPanel ButtonsFlowLayout;
        private System.Windows.Forms.TableLayoutPanel MainTableLayout;
        private System.Windows.Forms.GroupBox FilterGroupBox;
        private System.Windows.Forms.GroupBox SortGroupBox;
        private System.Windows.Forms.TableLayoutPanel SortingTableLayout;
    }
}