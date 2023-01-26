using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DirectoryMerge
{
	public partial class DirectoryView : UserControl
	{
		public string SelectedDir
		{
			get
			{
				return tbPath.Text;
			}
			set
			{
				tbPath.Text = value;
				tbPath.Text = value;
				if (Directory.Exists(value))
				{
					UpdateTreeView(value);
				}
			}
		}

		public string Title
		{
			get
			{
				return lblTitle.Text;
			}
			set
			{
				lblTitle.Text = value;
			}
		}

		public DirectoryView()
		{
			InitializeComponent();
		}

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			if (Directory.Exists(SelectedDir))
			{
				fbd.SelectedPath = SelectedDir;
			}

			if (fbd.ShowDialog() == DialogResult.OK)
			{
				SelectedDir = fbd.SelectedPath;
			}
		}

		private void DirectoryView_Load(object sender, EventArgs e)
		{

		}

		private void UpdateTreeView(string rootDirFullPath)
		{
			treeDir.Nodes.Clear();
			treeDir.Nodes.Add(GenerateNodes(rootDirFullPath));
		}

		/// <summary>
		/// Generates a tree of all of the contents of the directory
		/// </summary>
		/// <returns>A tree node which represents the selected dir</returns>
		private TreeNode GenerateNodes(string fullPath)
		{
			var newNode = new TreeNode();
			newNode.Text = new DirectoryInfo(fullPath).Name;
			newNode.ToolTipText = fullPath;
			newNode.Tag = fullPath;

			var files = Directory.EnumerateFiles(fullPath);
			var subDirs = Directory.EnumerateDirectories(fullPath);

			foreach (var subDir in subDirs)
			{
				newNode.Nodes.Add(GenerateNodes(subDir));
			}

			foreach (var file in files)
			{
				var newFileNode = new TreeNode(new FileInfo(file).Name);
				newFileNode.ToolTipText = file;
				newFileNode.Tag = file;
				newNode.Nodes.Add(newFileNode);
			}

			return newNode;
		}

		private void btnOpenExplorer_Click(object sender, EventArgs e)
		{
			Process.Start("explorer.exe", SelectedDir);
		}

		private void btnExpandAll_Click(object sender, EventArgs e)
		{
			foreach (TreeNode node in treeDir.Nodes)
			{
				ExpandNode(node);
			}
			treeDir.Nodes[0].EnsureVisible();
		}

		private void ExpandNode(TreeNode node)
		{
			node.Expand();
			foreach (TreeNode child in node.Nodes)
			{
				ExpandNode(child);
			}
		}

		private void btnCollapseAll_Click(object sender, EventArgs e)
		{
			foreach (TreeNode node in treeDir.Nodes)
			{
				CollapseNode(node);
			}
			treeDir.Nodes[0].EnsureVisible();
		}

		private void CollapseNode(TreeNode node)
		{
			node.Collapse();
			foreach (TreeNode child in node.Nodes)
			{
				CollapseNode(child);
			}
		}

		/// <summary>
		/// Refreshes the selected tree view
		/// </summary>
		public void RefreshTree()
		{
			UpdateTreeView(SelectedDir);
		}

		private void treeDir_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
		{
			string path = (string)e.Node.Tag;
			if (Directory.Exists(path))
			{
				Process.Start("explorer.exe", path);
				return;
			}

			if (File.Exists(path))
			{
				Process.Start(path);
			}
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			UpdateTreeView(SelectedDir);
		}
	}
}
