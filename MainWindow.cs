using System;
using System.Windows.Forms;

namespace LoveMaker {
    public partial class MainWindow : Form {
        private void LogText(String text) {
            if (this.TBRuntimeLog != null) {
                this.TBRuntimeLog.Text += text.Trim() + Environment.NewLine;
            }
        }
        private void LogCase(Boolean c, String invoker) {
            if (c) {
                this.LogText("+ " + invoker);
            } else {
                this.LogText("- " + invoker);
            }
        }
        private void LogAction(Action a, String purpose) {
            try { a.Invoke(); } catch (Exception e) {
                this.LogCase(false, "action: " + purpose + " (" + e.Message + ")");
                return;
            }
            this.LogCase(true, "action: " + purpose);
        }

        LoveHelper Helper = new();
        public MainWindow() {
            InitializeComponent();

            // Hook the Helper.Updated Action
            this.Helper.Callbacks.Update = () => {
                this.RBValidRoot.Checked = Helper.Flags.IsValid;
                this.LogCase(Helper.Flags.IsValid, "Helper");
            };
            // Hook the Helper.PBStatus ProgressBar to the one in the form
            this.Helper.Flags.PBStatus = this.PBOperation;
        }

        private void MainWindow_Load(Object sender, EventArgs e) {
            // Check if the CurrentDirectory is a Valid LÖVE game
            String ENVPath = Environment.CurrentDirectory;
            if (FilesystemLover.IsValidLoveDirectory(ENVPath)) {
                this.Helper.Setup(ENVPath);
            }
        }

        private void BExecute_Click(Object sender, EventArgs e) {
            if (this.Helper.Flags.IsValid) {
                switch (this.CBOperation.Text) {
                    case "":
                        String title = "Cannot Execute";
                        String msg = "No Operation was selected.\n" +
                            "Select an Operation, and then try again.";
                        _= MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case "Compile":
                        break;
                    case "Execute":
                        break;
                    case "Package":
                        break;
                }
            } else {
                String title = "Cannot Execute";
                String msg = "The project's root path is invalid.\n" +
                    "Open a new project.";
                DialogResult res = MessageBox.Show(msg, title,
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
                if (res == DialogResult.Retry) { this.BExecute_Click(sender, e); }
            }
        }

        private void TSMIExit_Click(Object sender, EventArgs e) => this.Close();

        private void BOpenProject_Click(Object sender, EventArgs e) {
            _= this.FBDExplorer.ShowDialog();
            this.TBProjectPath.Text = this.FBDExplorer.SelectedPath;
            this.Helper.Setup(this.FBDExplorer.SelectedPath);
        }

        private void BRefreshEnv_Click(Object sender, EventArgs e) {
            this.TBRuntimeLog.Text = String.Empty;
            this.TBProjectPath.Text = String.Empty;
            this.TBLuaPath.Text = String.Empty;
            this.TBMoonPath.Text = String.Empty;
        }
    }
}
