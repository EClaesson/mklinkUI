using System;
using System.Windows.Forms;

namespace mklinkUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void srcButton_Click(object sender, EventArgs e)
        {
            var dlg = new FolderBrowserDialog
                          {
                              Description = "Select the folder you wish to move",
                              ShowNewFolderButton = false
                          };

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                srcText.Text = dlg.SelectedPath;
            }
        }

        private void dstButton_Click(object sender, EventArgs e)
        {
            var dlg = new FolderBrowserDialog
                          {
                              Description = "Select where you want the folder to be moved",
                              ShowNewFolderButton = true
                          };

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                dstText.Text = dlg.SelectedPath;
            }
        }

        private void mkButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(srcText.Text) || string.IsNullOrEmpty(dstText.Text))
            {
                MessageBox.Show("Both Source and Destination must be set.", "Error", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            else
            {
                string newDir = DirUtils.MakeNewPath(srcText.Text, dstText.Text);

                if (DirUtils.Exists(newDir))
                {
                    MessageBox.Show("Destination folder (" + newDir + ") is not empty.", "Error", MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                else
                {
                    //TODO: Get an accurate progress
                    // 
                    DirUtils.MakeDir(newDir);
                    progress.Value = 10;

                    DirUtils.MoveDirectory(srcText.Text, newDir);
                    progress.Value = 80;

                    DirUtils.DeleteDir(srcText.Text);
                    progress.Value = 90;

                    DirUtils.MakeSymlink(srcText.Text, newDir);
                    progress.Value = 100;

                    MessageBox.Show("The folder has been moved and linked.", "Success", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    progress.Value = 0;
                    srcText.Text = "";
                    dstText.Text = "";
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}