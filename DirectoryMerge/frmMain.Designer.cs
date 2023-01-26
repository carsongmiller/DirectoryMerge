namespace DirectoryMerge
{
	partial class frmMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.folderBrowserDialog_Output = new System.Windows.Forms.FolderBrowserDialog();
			this.folderBrowserDialog_Add = new System.Windows.Forms.FolderBrowserDialog();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.dirViewLeft = new DirectoryMerge.DirectoryView();
			this.dirViewRight = new DirectoryMerge.DirectoryView();
			this.btnStartMerge = new System.Windows.Forms.Button();
			this.cbCopyLeftToRight = new System.Windows.Forms.CheckBox();
			this.cbCopyRightToLeft = new System.Windows.Forms.CheckBox();
			this.cbCopySubDirs = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.IsSplitterFixed = true;
			this.splitContainer1.Location = new System.Drawing.Point(12, 12);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.dirViewLeft);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.dirViewRight);
			this.splitContainer1.Size = new System.Drawing.Size(996, 451);
			this.splitContainer1.SplitterDistance = 499;
			this.splitContainer1.TabIndex = 2;
			// 
			// dirViewLeft
			// 
			this.dirViewLeft.Cursor = System.Windows.Forms.Cursors.Default;
			this.dirViewLeft.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dirViewLeft.Location = new System.Drawing.Point(0, 0);
			this.dirViewLeft.Name = "dirViewLeft";
			this.dirViewLeft.SelectedDir = "";
			this.dirViewLeft.Size = new System.Drawing.Size(499, 451);
			this.dirViewLeft.TabIndex = 0;
			this.dirViewLeft.Title = "Left";
			// 
			// dirViewRight
			// 
			this.dirViewRight.Cursor = System.Windows.Forms.Cursors.Default;
			this.dirViewRight.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dirViewRight.Location = new System.Drawing.Point(0, 0);
			this.dirViewRight.Name = "dirViewRight";
			this.dirViewRight.SelectedDir = "";
			this.dirViewRight.Size = new System.Drawing.Size(493, 451);
			this.dirViewRight.TabIndex = 1;
			this.dirViewRight.Title = "Right";
			// 
			// btnStartMerge
			// 
			this.btnStartMerge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnStartMerge.Location = new System.Drawing.Point(12, 538);
			this.btnStartMerge.Name = "btnStartMerge";
			this.btnStartMerge.Size = new System.Drawing.Size(75, 23);
			this.btnStartMerge.TabIndex = 5;
			this.btnStartMerge.Text = "Merge";
			this.btnStartMerge.UseVisualStyleBackColor = true;
			this.btnStartMerge.Click += new System.EventHandler(this.btnStartMerge_Click);
			// 
			// cbCopyLeftToRight
			// 
			this.cbCopyLeftToRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cbCopyLeftToRight.AutoSize = true;
			this.cbCopyLeftToRight.Checked = true;
			this.cbCopyLeftToRight.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbCopyLeftToRight.Location = new System.Drawing.Point(12, 469);
			this.cbCopyLeftToRight.Name = "cbCopyLeftToRight";
			this.cbCopyLeftToRight.Size = new System.Drawing.Size(111, 17);
			this.cbCopyLeftToRight.TabIndex = 2;
			this.cbCopyLeftToRight.Text = "Copy Left to Right";
			this.cbCopyLeftToRight.UseVisualStyleBackColor = true;
			// 
			// cbCopyRightToLeft
			// 
			this.cbCopyRightToLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cbCopyRightToLeft.AutoSize = true;
			this.cbCopyRightToLeft.Checked = true;
			this.cbCopyRightToLeft.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbCopyRightToLeft.Location = new System.Drawing.Point(12, 492);
			this.cbCopyRightToLeft.Name = "cbCopyRightToLeft";
			this.cbCopyRightToLeft.Size = new System.Drawing.Size(111, 17);
			this.cbCopyRightToLeft.TabIndex = 3;
			this.cbCopyRightToLeft.Text = "Copy Right to Left";
			this.cbCopyRightToLeft.UseVisualStyleBackColor = true;
			// 
			// cbCopySubDirs
			// 
			this.cbCopySubDirs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cbCopySubDirs.AutoSize = true;
			this.cbCopySubDirs.Checked = true;
			this.cbCopySubDirs.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbCopySubDirs.Location = new System.Drawing.Point(12, 515);
			this.cbCopySubDirs.Name = "cbCopySubDirs";
			this.cbCopySubDirs.Size = new System.Drawing.Size(125, 17);
			this.cbCopySubDirs.TabIndex = 4;
			this.cbCopySubDirs.Text = "Copy Sub-Directories";
			this.cbCopySubDirs.UseVisualStyleBackColor = true;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1020, 573);
			this.Controls.Add(this.cbCopySubDirs);
			this.Controls.Add(this.cbCopyRightToLeft);
			this.Controls.Add(this.cbCopyLeftToRight);
			this.Controls.Add(this.btnStartMerge);
			this.Controls.Add(this.splitContainer1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmMain";
			this.Text = "Directory Merge";
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_Output;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_Add;
		private DirectoryView dirViewLeft;
		private DirectoryView dirViewRight;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Button btnStartMerge;
		private System.Windows.Forms.CheckBox cbCopyLeftToRight;
		private System.Windows.Forms.CheckBox cbCopyRightToLeft;
		private System.Windows.Forms.CheckBox cbCopySubDirs;
	}
}

