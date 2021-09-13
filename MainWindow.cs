using System;
using System.Windows.Forms;

namespace LoveMaker
{
    public partial class MainWindow : Form
    {
        LoveHelper Helper = new();
        public MainWindow()
        {
            InitializeComponent();

            // Hook the Helper.Updated Action
            this.Helper.Updated = () => 
            {
                this.RBValidRoot.Checked = Helper.IsValid;
            };

            // Check if the CurrentDirectory is a Valid LÖVE game
            string envPath = Environment.CurrentDirectory;
            if (FilesystemLover.IsValidLoveDirectory(envPath))
            { this.Helper.Setup(envPath); }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            // Hook the Helper.PBStatus ProgressBar to the one in the form
            this.Helper.PBStatus = this.PBOperation;
        }

        private void BExecute_Click(object sender, EventArgs e)
        {
            if (this.Helper.IsValid)
            {
                switch (this.CBOperation.Text)
                {
                    case "":
                        string title = "Cannot Execute";
                        string msg = "No Operation was selected.\n" +
                            "Select an Operation, and then try again.";
                        MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case "Compile":
                        break;
                    case "Execute":
                        break;
                    case "Package":
                        break;
                }
            } else
            {
                string title = "Cannot Execute";
                string msg = "The project's root path is invalid.\n" +
                    "Open a new project.";
                DialogResult res = MessageBox.Show(msg, title,
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                if (res == DialogResult.Retry) { this.BExecute_Click(sender, e); }
            }
        }

        private void TSMIExit_Click(object sender, EventArgs e)
        { this.Close(); }

        private void BOpenProject_Click(object sender, EventArgs e)
        {
            this.FBDExplorer.ShowDialog();
            this.TBProjectPath.Text = this.FBDExplorer.SelectedPath;
            this.Helper.Setup(this.FBDExplorer.SelectedPath);
        }
    }
}
