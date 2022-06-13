using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

using MTLibrary;

namespace LoveMaker {
    public partial class MainWindow : Form {
        private void CheckGit() {
            if (LoveHelper.HasGit(this.TBProjectPath.Text)) {
                if (this.CBOperation.Items.Contains("Git Commit") == false) {
                    this.CBOperation.Items.Insert(1, "Git Commit");
                }
            } else {
                this.CBOperation.Items.Remove("Git Commit");
            }
            
        }
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

        private void SetPaths() {
            String workingDir = this.Settings.Get("workingDir");
            this.TBProjectPath.Text = String.IsNullOrEmpty(workingDir) ? Environment.CurrentDirectory : workingDir;
            this.TBLuaPath.Text = this.Settings.Get("luac");
            this.TBMoonPath.Text = this.Settings.Get("moonc");
        }
        private void AnnotateFilesTV(String rootDir) {
            DirectoryInfo rootDirInf = new(rootDir);
            static void AnnotateNode(TreeNode tN) {
                // FileInfo fI = new((String) tN.Tag);
                if (tN.Text.Contains('.')) {
                    tN.ImageIndex = 2;
                } else if (Directory.Exists((String) tN.Tag)) {
                    tN.ImageIndex = 0;
                    return;
                }
                if (tN.Text.Contains(".exe")) {
                    return;
                }
                if (tN.Text.Contains(".love") || tN.Text.Contains(".zip") ||
                    tN.Text.Contains(".lib") || tN.Text.Contains(".dll") ||
                    tN.Text.Contains(".so") || tN.Text.Contains(".dylib")) {
                    tN.ImageIndex = 3;
                    return;
                }
                if (tN.Text.Contains(".bin")) {
                    tN.ImageIndex = 7;
                    return;
                }
            }
            static void Annotate(TreeNode tN) {
                foreach (TreeNode childNode in tN.Nodes) {
                    Annotate(childNode);
                }
                AnnotateNode(tN);
            }
            foreach (TreeNode tN in this.TVFileStructure.Nodes) {
                Annotate(tN);
            }
        }
        private void UpdateFilesTV() {
            this.TVFileStructure.Nodes.Clear();
            var enume = this.ILFileTypes.Images.Keys.GetEnumerator();
            while (enume.MoveNext()) {
                this.LogText(enume.Current ?? "null!");
            }
            if (String.IsNullOrEmpty(this.TBProjectPath.Text) is not true) {
                void loadFiles(String dir, TreeNode parent) {
                    DirectoryInfo dI = new(dir);
                    foreach (FileInfo fInf in dI.GetFiles()) {
                        TreeNode tN = parent.Nodes.Add(fInf.Name);
                        tN.Tag = (String) fInf.FullName;
                    }
                }
                void loadSubDirs(String dir, TreeNode parent) {
                    DirectoryInfo dI = new(dir);
                    DirectoryInfo[] dirs = dI.GetDirectories();
                    foreach (DirectoryInfo dInf in dirs) {
                        TreeNode tN = parent.Nodes.Add(dInf.Name);
                        tN.Tag = (String) dInf.FullName;
                        loadFiles(dInf.FullName, tN);
                        loadSubDirs(dInf.FullName, tN);
                    }
                }
                void loadDir(String dir) {
                    DirectoryInfo dI = new(dir);
                    TreeNode tN = TVFileStructure.Nodes.Add(dI.Name);
                    tN.Tag = dI.FullName;
                    loadFiles(dI.FullName, tN);
                    loadSubDirs(dI.FullName, tN);
                    tN.Expand();
                }
                String path = this.TBProjectPath.Text.Trim();
                loadDir(path);
                AnnotateFilesTV(path);
            }
        }

        public DictionaryFile Settings;
        public MainWindow() {
            InitializeComponent();
            this.Settings = new("settings.bin");
        }

        private void MainWindow_Load(Object sender, EventArgs e) {
            this.SetPaths();
            this.CBOperation.SelectedIndex = 0;
            FSWLister.Changed += this.FSWLister_FileChanged;
            FSWLister.Created += this.FSWLister_FileChanged;
            FSWLister.Deleted += this.FSWLister_FileChanged;
            this.FSWLister_FileChanged(null, null);
        }
        private void FSWLister_FileChanged(Object? sender, FileSystemEventArgs? e) {
            if (this.TVFileStructure.InvokeRequired) {
                MethodInvoker iUpdateFiles= new(UpdateFilesTV);
                _ = this.TVFileStructure.Invoke(iUpdateFiles);
            } else {
                UpdateFilesTV();
            }
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
        private void TBLuaPath_DoubleClick(Object sender, EventArgs e) {
            OpenFileDialog oFD = new();
            oFD.FileName = "lua.exe";
            oFD.CheckFileExists = true;
            oFD.CheckPathExists = true;
            DialogResult res = oFD.ShowDialog(this);
            if (res.Equals(DialogResult.OK)) {
                this.TBLuaPath.Text = oFD.FileName;
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
        private void TBMoonPath_DoubleClick(Object sender, EventArgs e) {
            OpenFileDialog oFD = new();
            oFD.FileName = "moonc.exe";
            oFD.CheckFileExists = true;
            oFD.CheckPathExists = true;
            DialogResult res = oFD.ShowDialog(this);
            if (res.Equals(DialogResult.OK)) {
                this.TBMoonPath.Text = oFD.FileName;
            }
        }

        private void TBProjectPath_TextChanged(Object sender, EventArgs e) {
            String got = this.TBProjectPath.Text;
            Boolean workingDir = Directory.Exists(got);
            Boolean loveExists = LoveHelper.HasLove(got, false);
            Boolean combo = workingDir && loveExists;
            if (combo is true) {
                this.Settings.Set("workingDir", got);
                this.LogCase(combo, $"{got} is a valid LOVE game!");
            }
            this.CheckGit();
            this.CBValidRoot.Checked = combo;
            this.GBControls.Enabled = combo;
        }
        private void TBProjectPath_DoubleClick(Object sender, EventArgs e) {
            FolderBrowserDialog fbd = new();
            fbd.RootFolder = Environment.SpecialFolder.MyComputer;
            fbd.ShowNewFolderButton = false;
            DialogResult res = fbd.ShowDialog(this);
            if (res.Equals(DialogResult.OK)) {
                this.TBProjectPath.Text = fbd.SelectedPath.Trim();
            }
        }

        private void CBValidRoot_CheckedChanged(Object sender, EventArgs e) {
            Boolean ch = this.CBValidRoot.Checked;
            this.TSMIGenerate.Enabled = ch;
            FSWLister.EnableRaisingEvents = ch;
            
            if (ch is true) {
                FSWLister.Path = this.TBProjectPath.Text.Trim();
            }
        }

        private void TSMINewProject_Click(Object sender, EventArgs e) {
            Forms.LoveWizard wizard = new();
            _ = wizard.ShowDialog(this);
            this.TBProjectPath.Text = wizard.SelectedPath;
        }

        private void TSMIResetSettings_Click(Object sender, EventArgs e) {
            this.Settings.Clear();
            BRefreshEnv.PerformClick();
        }

        private void TSMISaveSettings_Click(Object sender, EventArgs e) {
            SaveFileDialog sFD = new();
            String name = this.Settings.FileName;
            sFD.FileName = String.IsNullOrEmpty(name) ? "" : name;
            sFD.AddExtension = true;
            sFD.CreatePrompt = false;
            sFD.Filter = "Binary Files|*.bin|Any|*.*";
            sFD.CheckPathExists = true;
            sFD.OverwritePrompt = true;
            DialogResult res = sFD.ShowDialog(this);
            if (res.Equals(DialogResult.OK)) {
                DictionaryFile dfExp = new(this.Settings, sFD.FileName);
                dfExp.Load(); dfExp.Save();
            }
        }

        private void TSMILoadSettings_Click(Object sender, EventArgs e) {
            OpenFileDialog oFD = new();
            oFD.Filter = "Binary Files|*.bin|Any|*.*";
            oFD.CheckFileExists = true;
            oFD.CheckPathExists = true;
            DialogResult res = oFD.ShowDialog(this);
            if (res.Equals(DialogResult.OK)) {
                try {
                    this.Settings = new(oFD.FileName);
                } catch { }
            }
            BRefreshEnv.PerformClick();
        }

        private void TSMIEditSettings_Click(Object sender, EventArgs e) {
            this.Settings.Load();
        }
    }
}
