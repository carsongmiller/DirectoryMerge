namespace DirectoryMerge
{
	partial class DirectoryView
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
			this.tbPath = new System.Windows.Forms.TextBox();
			this.lblPath = new System.Windows.Forms.Label();
			this.treeDir = new System.Windows.Forms.TreeView();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.fbd = new System.Windows.Forms.FolderBrowserDialog();
			this.btnOpenExplorer = new System.Windows.Forms.Button();
			this.btnExpandAll = new System.Windows.Forms.Button();
			this.btnCollapseAll = new System.Windows.Forms.Button();
			this.lblTitle = new System.Windows.Forms.Label();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tbPath
			// 
			this.tbPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbPath.Location = new System.Drawing.Point(41, 33);
			this.tbPath.Name = "tbPath";
			this.tbPath.Size = new System.Drawing.Size(289, 20);
			this.tbPath.TabIndex = 0;
			this.tbPath.Text = "C:\\Full\\Path\\";
			// 
			// lblPath
			// 
			this.lblPath.AutoSize = true;
			this.lblPath.Location = new System.Drawing.Point(6, 36);
			this.lblPath.Name = "lblPath";
			this.lblPath.Size = new System.Drawing.Size(29, 13);
			this.lblPath.TabIndex = 1;
			this.lblPath.Text = "Path";
			// 
			// treeDir
			// 
			this.treeDir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.treeDir.Location = new System.Drawing.Point(3, 90);
			this.treeDir.Name = "treeDir";
			this.treeDir.Size = new System.Drawing.Size(408, 283);
			this.treeDir.TabIndex = 6;
			this.treeDir.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeDir_NodeMouseDoubleClick);
			// 
			// btnBrowse
			// 
			this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowse.Location = new System.Drawing.Point(336, 32);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(75, 23);
			this.btnBrowse.TabIndex = 1;
			this.btnBrowse.Text = "Browse";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// btnOpenExplorer
			// 
			this.btnOpenExplorer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOpenExplorer.Location = new System.Drawing.Point(296, 61);
			this.btnOpenExplorer.Name = "btnOpenExplorer";
			this.btnOpenExplorer.Size = new System.Drawing.Size(115, 23);
			this.btnOpenExplorer.TabIndex = 5;
			this.btnOpenExplorer.Text = "Open in Explorer";
			this.btnOpenExplorer.UseVisualStyleBackColor = true;
			this.btnOpenExplorer.Click += new System.EventHandler(this.btnOpenExplorer_Click);
			// 
			// btnExpandAll
			// 
			this.btnExpandAll.Location = new System.Drawing.Point(3, 61);
			this.btnExpandAll.Name = "btnExpandAll";
			this.btnExpandAll.Size = new System.Drawing.Size(88, 23);
			this.btnExpandAll.TabIndex = 3;
			this.btnExpandAll.Text = "Expand All";
			this.btnExpandAll.UseVisualStyleBackColor = true;
			this.btnExpandAll.Click += new System.EventHandler(this.btnExpandAll_Click);
			// 
			// btnCollapseAll
			// 
			this.btnCollapseAll.Location = new System.Drawing.Point(97, 61);
			this.btnCollapseAll.Name = "btnCollapseAll";
			this.btnCollapseAll.Size = new System.Drawing.Size(88, 23);
			this.btnCollapseAll.TabIndex = 4;
			this.btnCollapseAll.Text = "Collapse All";
			this.btnCollapseAll.UseVisualStyleBackColor = true;
			this.btnCollapseAll.Click += new System.EventHandler(this.btnCollapseAll_Click);
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.Location = new System.Drawing.Point(3, 3);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(43, 20);
			this.lblTitle.TabIndex = 7;
			this.lblTitle.Text = "Title";
			// 
			// btnRefresh
			// 
			this.btnRefresh.Location = new System.Drawing.Point(191, 61);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(68, 23);
			this.btnRefresh.TabIndex = 2;
			this.btnRefresh.Text = "Refresh";
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// DirectoryView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.btnCollapseAll);
			this.Controls.Add(this.btnExpandAll);
			this.Controls.Add(this.btnOpenExplorer);
			this.Controls.Add(this.btnBrowse);
			this.Controls.Add(this.treeDir);
			this.Controls.Add(this.lblPath);
			this.Controls.Add(this.tbPath);
			this.Name = "DirectoryView";
			this.Size = new System.Drawing.Size(414, 376);
			this.Load += new System.EventHandler(this.DirectoryView_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbPath;
		private System.Windows.Forms.Label lblPath;
		private System.Windows.Forms.TreeView treeDir;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.FolderBrowserDialog fbd;
		private System.Windows.Forms.Button btnOpenExplorer;
		private System.Windows.Forms.Button btnExpandAll;
		private System.Windows.Forms.Button btnCollapseAll;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Button btnRefresh;
	}
}
