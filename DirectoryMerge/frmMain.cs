using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DirectoryMerge
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			dirViewLeft.SelectedDir = Directory.GetCurrentDirectory();
			dirViewRight.SelectedDir = Directory.GetCurrentDirectory();
		}

		private void btnStartMerge_Click(object sender, EventArgs e)
		{
			string message = "One or more of the directories you selected does not exist";
			string caption = "Directory does not exist";
			if (!Directory.Exists(dirViewLeft.SelectedDir) || !Directory.Exists(dirViewRight.SelectedDir))
			{
				MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			message = "Are you sure you would like to merge the selected directories?\n\nNo files will be deleted, but files will be copied between them";
			if (MessageBox.Show(message, "Merge Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
			{
				return;
			}

			if (cbCopyLeftToRight.Checked)
			{
				CopyDirectory(dirViewLeft.SelectedDir, dirViewRight.SelectedDir, cbCopySubDirs.Checked);
			}

			if (cbCopyRightToLeft.Checked)
			{
				CopyDirectory(dirViewRight.SelectedDir, dirViewLeft.SelectedDir, cbCopySubDirs.Checked);
			}

			MessageBox.Show("Merge Complete!", "Merge Complete", MessageBoxButtons.OK);

			dirViewLeft.RefreshTree();
			dirViewRight.RefreshTree();
		}

		private void CopyDirectory(string source, string dest, bool recursive)
		{
			var sourceInfo = new DirectoryInfo(source);
			var destInfo = new DirectoryInfo(dest);


			//Copy Directories

			if (recursive)
			{
				var destSubDirs = Directory.GetDirectories(dest);

				foreach (var sourceSubDir in Directory.GetDirectories(source))
				{
					var destSubDir = $"{dest}\\{Path.GetFileName(sourceSubDir)}";

					if (!destSubDirs.Contains(sourceSubDir))
					{
						Directory.CreateDirectory(destSubDir);
					}

					CopyDirectory(sourceSubDir, destSubDir, recursive);
				}
			}
			

			//Copy Files

			//Get list of files currently in the dest
			var destFiles = Directory.GetFiles(dest);
			for (int i = 0; i < destFiles.Length; i++)
			{
				destFiles[i] = Path.GetFileName(destFiles[i]);
			}

			//for each file in source, check if it's already in dest and if not, copy it
			foreach (var file in Directory.GetFiles(source))
			{
				if (!destFiles.Contains(Path.GetFileName(file)))
				{
					File.Copy(file, $"{dest}\\{Path.GetFileName(file)}");
				}
			}
		}
	}
}
