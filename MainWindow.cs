using System;
using System.Collections.Generic;
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
                this.LogCase(false, $"{purpose} ({e.Message})");
                return;
            }
            this.LogCase(true, purpose);
        }

        private void SetPaths() {
            this.TBProjectPath.Text = this.Settings.Get("workingDir");
            if (this.TBProjectPath.Text.Length < 1) {
                this.TBProjectPath.Text = Environment.CurrentDirectory;
            }
            this.TBLuaPath.Text = this.Settings.Get("luac");
            this.TBMoonPath.Text = this.Settings.Get("moonc");
            if (this.TBLuaPath.Text.Length < 1) {
                //this.TBLuaPath.Text = this.Helper.GetKeyfile("luac.exe");
            }
            if (this.TBMoonPath.Text.Length < 1) {
                //this.TBMoonPath.Text = this.Helper.GetKeyfile("moonc.exe");
            }
        }

        private Action OnRootValid = () => {

        };
        private Action OnRootInvalid = () => {

        };

        public DictionaryFile Settings;
        public MainWindow() {
            InitializeComponent();

            //this.Helper = new(true);
            this.Settings = new("setttings.bin");
        }

        private void MainWindow_Load(Object sender, EventArgs e) {
            this.SetPaths();
            this.CBOperation.SelectedIndex = 0;
        }

        private void BExecute_Click(Object sender, EventArgs e) {
            switch (this.CBOperation.Text) {
                case "":
                    String title = "Cannot Execute";
                    String msg = "No Operation was selected.\n" +
                        "Select an Operation, and then try again.";
                    _ = MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case "Compile":
                    static Boolean SearchForLuas(String inPath) {
                        foreach (String candidateDir in Directory.EnumerateDirectories(inPath +@"\")) {
                            foreach (String candidateFile in Directory.EnumerateFiles(candidateDir)) {
                                String[] candidateFileParts = candidateFile.Split(".");
                                if (candidateFileParts.Length > 1) {
                                    return candidateFileParts[candidateFileParts.Length - 1].Contains("lua",
                                    StringComparison.OrdinalIgnoreCase);
                                }
                            }
                        } return false;
                    }
                    this.PBStatus.Value = 100;
                    String workingDir = this.Settings.Get("workingDir");
                    //await this.Helper.Compile(workingDir);
                    if (SearchForLuas(workingDir)) {
                        this.LogCase(true, "Found luas!");
                    } else {
                        this.LogCase(false, "no luas found!");
                    }
                    this.PBStatus.Value = 0;
                    break;
                case "Execute":
                    break;
                case "Package":
                    break;
            }
        }

        private void TSMIExit_Click(Object sender, EventArgs e) {
            this.Close();
        }

        private void BRefreshEnv_Click(Object sender, EventArgs e) {
            this.SetPaths();
        }

        private void MainWindow_FormClosing(Object sender, FormClosingEventArgs e) {
            this.Settings.Save();
        }

        private void TBLuaPath_TextChanged(Object sender, EventArgs e) {
            String got = this.TBLuaPath.Text.Trim();
            Boolean exists = File.Exists(got);
            this.CBValidLua.Checked = exists;
            if (exists is true) {
                this.Settings.Set("luac", got);
            }
        }

        private void TBMoonPath_TextChanged(Object sender, EventArgs e) {
            String got = this.TBMoonPath.Text.Trim();
            Boolean exists = File.Exists(got);
            this.CBValidMoon.Checked = exists;
            if (File.Exists(got)) {
                this.Settings.Set("moonc", got);
            }
        }

        private void TBProjectPath_TextChanged(Object sender, EventArgs e) {
            String got = this.TBProjectPath.Text;
            Boolean workingDir = Directory.Exists(got);
            Boolean loveExists = LoveHelper.IsValidLOVEDirectory(got, false);
            Boolean combo = workingDir && loveExists;
            if (combo is true) {
                this.Settings.Set("workingDir", got);
                this.LogAction(this.OnRootValid, "Root Validation");
            } else {
                this.LogAction(this.OnRootInvalid, "Root Invalidation");
            }
            this.CBValidRoot.Checked = combo;
            this.GBControls.Enabled = combo;
        }

        private void CBValidRoot_CheckedChanged(Object sender, EventArgs e) {
            this.TSMINewProject.Enabled = !this.CBValidRoot.Checked;
            this.TSMIGenerate.Enabled = this.CBValidRoot.Checked;
        }

        private void TSMINewProject_Click(Object sender, EventArgs e) {
            Forms.LoveWizard wizard = new();
            _ = wizard.ShowDialog(this);
            this.TBProjectPath.Text = wizard.SelectedPath;
        }
    }
}
