using System;
using System.IO;
using System.Windows.Forms;

using MTLibrary;

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
        private Boolean Check() {
            if (this.TBLuaPath.Text != String.Empty) {
                this.RBValidLua.Checked = File.Exists(this.TBLuaPath.Text);
            }
            if (this.TBMoonPath.Text != String.Empty) {
                this.RBValidMoonscript.Checked = File.Exists(this.TBMoonPath.Text);
            }
            return this.RBValidLua.Checked && this.RBValidMoonscript.Checked;
        }
        public DictionaryFile Settings;
        public LoveHelper Helper;
        public MainWindow() {
            InitializeComponent();

            this.Settings = new("setttings.bin");
            this.Helper = new(true);
        }

        private void MainWindow_Load(Object sender, EventArgs e) {
            this.TBProjectPath.Text = Environment.CurrentDirectory;
            this.TBLuaPath.Text = this.Settings.Get("luac");
            this.TBMoonPath.Text = this.Settings.Get("moonc");
            if (!this.Check()) {
                this.TBLuaPath.Text = this.Helper.GetKeyfile("luac.exe");
                this.TBMoonPath.Text = this.Helper.GetKeyfile("moonc.exe");
                if (this.Check()) {
                    this.Settings.Set("luac", this.TBLuaPath.Text);
                    this.Settings.Set("moonc", this.TBMoonPath.Text);
                }
            }
        }

        private void BExecute_Click(Object sender, EventArgs e) {
            if (true) { //this.Helper.Flags.IsValid
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
            //this.Helper.Setup(this.FBDExplorer.SelectedPath);
        }

        private void BRefreshEnv_Click(Object sender, EventArgs e) {
            this.TBRuntimeLog.Text = String.Empty;
            this.TBProjectPath.Text = String.Empty;
            this.TBLuaPath.Text = String.Empty;
            this.TBMoonPath.Text = String.Empty;
        }

        private void MainWindow_FormClosing(Object sender, FormClosingEventArgs e) {
            this.Settings.Save();
        }
    }
}
