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

		private bool isNodeDoubleClick = false;

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
			if (!Directory.Exists(rootDirFullPath)) 
			{
				string message = $"Directory does not exist:\n\n{rootDirFullPath}";
				MessageBox.Show(message, "Directory does not exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			treeDir.Nodes.Clear();
			treeDir.Nodes.Add(GenerateNodes(rootDirFullPath));
		}

		/// <summary>
		/// Generates a tree of all of the contents of the directory
		/// </summary>
		/// <returns>A tree node which represents the selected dir</returns>
		private TreeNode GenerateNodes(string dirFullPath)
		{
			var newNode = new TreeNode();
			if (!Directory.Exists(dirFullPath))
			{
				return null;
			}
			newNode.Text = new DirectoryInfo(dirFullPath).Name;
			newNode.ToolTipText = dirFullPath;
			newNode.Tag = dirFullPath;

			var files = Directory.EnumerateFiles(dirFullPath);
			var subDirs = Directory.EnumerateDirectories(dirFullPath);

			foreach (var subDir in subDirs)
			{
				var newChildNode = GenerateNodes(subDir);
				if (newChildNode != null)
				{
					newNode.Nodes.Add(newChildNode);
				}
			}

			foreach (var file in files)
			{
				if (!File.Exists(file)) continue;

				var newFileNode = new TreeNode(new FileInfo(file).Name);
				newFileNode.ToolTipText = file;
				newFileNode.Tag = file;
				newNode.Nodes.Add(newFileNode);
			}

			return newNode;
		}

		private void btnOpenExplorer_Click(object sender, EventArgs e)
		{
			if (!Directory.Exists(SelectedDir))
			{
				string message = $"Directory does not exist:\n\n{SelectedDir}";
				MessageBox.Show(message, "Directory does not exist", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			try
			{
				Process.Start("explorer.exe", SelectedDir);
			}
			catch (Exception ex)
			{
				string message = $"Unable to open directory:\n\n{SelectedDir}\n\n{ex.Message}";
				MessageBox.Show(message, "Failed to open directory", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
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
			OpenNode(e.Node);
		}

		private void btnOpenNode_Click(object sender, EventArgs e)
		{
			if (treeDir.SelectedNode != null)
			{
				OpenNode(treeDir.SelectedNode);
			}
		}

		private void OpenNode(TreeNode node)
		{
			string path = (string)node.Tag;
			if (Directory.Exists(path))
			{
				try
				{
					Process.Start("explorer.exe", path);
				}
				catch (Exception ex)
				{
					string message = $"Unable to open directory:\n\n{path}\n\n{ex.Message}";
					MessageBox.Show(message, "Failed to open directory", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				return;
			}

			if (File.Exists(path))
			{
				try
				{
					Process.Start(path);
				}
				catch (Exception ex)
				{
					string message = $"Unable to open file:\n\n{path}\n\n{ex.Message}";
					MessageBox.Show(message, "Failed to open file", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			UpdateTreeView(SelectedDir);
		}

		private void treeDir_MouseDown(object sender, MouseEventArgs e)
		{
			isNodeDoubleClick = e.Clicks == 2;
		}

		private void treeDir_BeforeExpand(object sender, TreeViewCancelEventArgs e)
		{
			if (isNodeDoubleClick && e.Action == TreeViewAction.Expand)
				e.Cancel = true;
		}

		private void treeDir_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
		{
			if (isNodeDoubleClick && e.Action == TreeViewAction.Collapse)
				e.Cancel = true;
		}

		private void btnUpDirLevel_Click(object sender, EventArgs e)
		{
			try
			{
				SelectedDir = new DirectoryInfo(SelectedDir).Parent.FullName;
			}
			catch
			{
				//do nothing
			}
		}
	}
}
