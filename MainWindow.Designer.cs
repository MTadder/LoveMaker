﻿
namespace LoveMaker
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.TCVariables = new System.Windows.Forms.TabControl();
            this.TPEnvrionment = new System.Windows.Forms.TabPage();
            this.GBPaths = new System.Windows.Forms.GroupBox();
            this.CBValidMoon = new System.Windows.Forms.CheckBox();
            this.CBValidLua = new System.Windows.Forms.CheckBox();
            this.CBValidRoot = new System.Windows.Forms.CheckBox();
            this.GBRuntime = new System.Windows.Forms.GroupBox();
            this.TBRuntimeLog = new System.Windows.Forms.TextBox();
            this.TBMoonPath = new System.Windows.Forms.TextBox();
            this.TBLuaPath = new System.Windows.Forms.TextBox();
            this.BRefreshEnv = new System.Windows.Forms.Button();
            this.TBProjectPath = new System.Windows.Forms.TextBox();
            this.TPCodeBrowser = new System.Windows.Forms.TabPage();
            this.TPFileSources = new System.Windows.Forms.TabPage();
            this.BExecuteNode = new System.Windows.Forms.Button();
            this.BDeleteNode = new System.Windows.Forms.Button();
            this.TVFileStructure = new System.Windows.Forms.TreeView();
            this.ILFileTypes = new System.Windows.Forms.ImageList(this.components);
            this.BNewNode = new System.Windows.Forms.Button();
            this.TPSteam = new System.Windows.Forms.TabPage();
            this.TPPackaging = new System.Windows.Forms.TabPage();
            this.MSToolbar = new System.Windows.Forms.MenuStrip();
            this.TSMIProjects = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMINewProject = new System.Windows.Forms.ToolStripMenuItem();
            this.TSSProject = new System.Windows.Forms.ToolStripSeparator();
            this.TSMIGenerate = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIGenCodeAnalysis = new System.Windows.Forms.ToolStripMenuItem();
            this.mD5HashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMISettings = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIEditSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.TSSSettings = new System.Windows.Forms.ToolStripSeparator();
            this.TSMISaveSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMILoadSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIResetSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIExit = new System.Windows.Forms.ToolStripMenuItem();
            this.GBControls = new System.Windows.Forms.GroupBox();
            this.PBStatus = new System.Windows.Forms.ProgressBar();
            this.LOperation = new System.Windows.Forms.Label();
            this.TBVersion = new System.Windows.Forms.TextBox();
            this.LVersion = new System.Windows.Forms.Label();
            this.CBOperation = new System.Windows.Forms.ComboBox();
            this.BExecute = new System.Windows.Forms.Button();
            this.FBDExplorer = new System.Windows.Forms.FolderBrowserDialog();
            this.FSWLister = new System.IO.FileSystemWatcher();
            this.TCVariables.SuspendLayout();
            this.TPEnvrionment.SuspendLayout();
            this.GBPaths.SuspendLayout();
            this.GBRuntime.SuspendLayout();
            this.TPFileSources.SuspendLayout();
            this.MSToolbar.SuspendLayout();
            this.GBControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FSWLister)).BeginInit();
            this.SuspendLayout();
            // 
            // TCVariables
            // 
            resources.ApplyResources(this.TCVariables, "TCVariables");
            this.TCVariables.Controls.Add(this.TPEnvrionment);
            this.TCVariables.Controls.Add(this.TPCodeBrowser);
            this.TCVariables.Controls.Add(this.TPFileSources);
            this.TCVariables.Controls.Add(this.TPSteam);
            this.TCVariables.Controls.Add(this.TPPackaging);
            this.TCVariables.Name = "TCVariables";
            this.TCVariables.SelectedIndex = 0;
            // 
            // TPEnvrionment
            // 
            resources.ApplyResources(this.TPEnvrionment, "TPEnvrionment");
            this.TPEnvrionment.Controls.Add(this.GBPaths);
            this.TPEnvrionment.Name = "TPEnvrionment";
            this.TPEnvrionment.UseVisualStyleBackColor = true;
            // 
            // GBPaths
            // 
            resources.ApplyResources(this.GBPaths, "GBPaths");
            this.GBPaths.Controls.Add(this.CBValidMoon);
            this.GBPaths.Controls.Add(this.CBValidLua);
            this.GBPaths.Controls.Add(this.CBValidRoot);
            this.GBPaths.Controls.Add(this.GBRuntime);
            this.GBPaths.Controls.Add(this.TBMoonPath);
            this.GBPaths.Controls.Add(this.TBLuaPath);
            this.GBPaths.Controls.Add(this.BRefreshEnv);
            this.GBPaths.Controls.Add(this.TBProjectPath);
            this.GBPaths.Name = "GBPaths";
            this.GBPaths.TabStop = false;
            // 
            // CBValidMoon
            // 
            resources.ApplyResources(this.CBValidMoon, "CBValidMoon");
            this.CBValidMoon.Name = "CBValidMoon";
            this.CBValidMoon.UseVisualStyleBackColor = true;
            // 
            // CBValidLua
            // 
            resources.ApplyResources(this.CBValidLua, "CBValidLua");
            this.CBValidLua.Name = "CBValidLua";
            this.CBValidLua.UseVisualStyleBackColor = true;
            // 
            // CBValidRoot
            // 
            resources.ApplyResources(this.CBValidRoot, "CBValidRoot");
            this.CBValidRoot.Name = "CBValidRoot";
            this.CBValidRoot.UseVisualStyleBackColor = true;
            this.CBValidRoot.CheckedChanged += new System.EventHandler(this.CBValidRoot_CheckedChanged);
            // 
            // GBRuntime
            // 
            resources.ApplyResources(this.GBRuntime, "GBRuntime");
            this.GBRuntime.Controls.Add(this.TBRuntimeLog);
            this.GBRuntime.Name = "GBRuntime";
            this.GBRuntime.TabStop = false;
            // 
            // TBRuntimeLog
            // 
            resources.ApplyResources(this.TBRuntimeLog, "TBRuntimeLog");
            this.TBRuntimeLog.Name = "TBRuntimeLog";
            this.TBRuntimeLog.ReadOnly = true;
            // 
            // TBMoonPath
            // 
            resources.ApplyResources(this.TBMoonPath, "TBMoonPath");
            this.TBMoonPath.Name = "TBMoonPath";
            this.TBMoonPath.TextChanged += new System.EventHandler(this.TBMoonPath_TextChanged);
            this.TBMoonPath.DoubleClick += new System.EventHandler(this.TBMoonPath_DoubleClick);
            // 
            // TBLuaPath
            // 
            resources.ApplyResources(this.TBLuaPath, "TBLuaPath");
            this.TBLuaPath.Name = "TBLuaPath";
            this.TBLuaPath.TextChanged += new System.EventHandler(this.TBLuaPath_TextChanged);
            this.TBLuaPath.DoubleClick += new System.EventHandler(this.TBLuaPath_DoubleClick);
            // 
            // BRefreshEnv
            // 
            resources.ApplyResources(this.BRefreshEnv, "BRefreshEnv");
            this.BRefreshEnv.Name = "BRefreshEnv";
            this.BRefreshEnv.UseVisualStyleBackColor = true;
            this.BRefreshEnv.Click += new System.EventHandler(this.BRefreshEnv_Click);
            // 
            // TBProjectPath
            // 
            resources.ApplyResources(this.TBProjectPath, "TBProjectPath");
            this.TBProjectPath.Name = "TBProjectPath";
            this.TBProjectPath.TextChanged += new System.EventHandler(this.TBProjectPath_TextChanged);
            this.TBProjectPath.DoubleClick += new System.EventHandler(this.TBProjectPath_DoubleClick);
            // 
            // TPCodeBrowser
            // 
            resources.ApplyResources(this.TPCodeBrowser, "TPCodeBrowser");
            this.TPCodeBrowser.Name = "TPCodeBrowser";
            this.TPCodeBrowser.UseVisualStyleBackColor = true;
            // 
            // TPFileSources
            // 
            resources.ApplyResources(this.TPFileSources, "TPFileSources");
            this.TPFileSources.Controls.Add(this.BExecuteNode);
            this.TPFileSources.Controls.Add(this.BDeleteNode);
            this.TPFileSources.Controls.Add(this.TVFileStructure);
            this.TPFileSources.Controls.Add(this.BNewNode);
            this.TPFileSources.Name = "TPFileSources";
            this.TPFileSources.UseVisualStyleBackColor = true;
            // 
            // BExecuteNode
            // 
            resources.ApplyResources(this.BExecuteNode, "BExecuteNode");
            this.BExecuteNode.Name = "BExecuteNode";
            this.BExecuteNode.UseVisualStyleBackColor = true;
            // 
            // BDeleteNode
            // 
            resources.ApplyResources(this.BDeleteNode, "BDeleteNode");
            this.BDeleteNode.Name = "BDeleteNode";
            this.BDeleteNode.UseVisualStyleBackColor = true;
            // 
            // TVFileStructure
            // 
            resources.ApplyResources(this.TVFileStructure, "TVFileStructure");
            this.TVFileStructure.ImageList = this.ILFileTypes;
            this.TVFileStructure.Name = "TVFileStructure";
            // 
            // ILFileTypes
            // 
            this.ILFileTypes.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ILFileTypes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ILFileTypes.ImageStream")));
            this.ILFileTypes.TransparentColor = System.Drawing.Color.Transparent;
            this.ILFileTypes.Images.SetKeyName(0, "bug.png");
            this.ILFileTypes.Images.SetKeyName(1, "help.png");
            this.ILFileTypes.Images.SetKeyName(2, "asterisk.png");
            this.ILFileTypes.Images.SetKeyName(3, "alert.png");
            this.ILFileTypes.Images.SetKeyName(4, "unavailable.png");
            this.ILFileTypes.Images.SetKeyName(5, "locked.png");
            this.ILFileTypes.Images.SetKeyName(6, "halt.png");
            this.ILFileTypes.Images.SetKeyName(7, "help-circled.png");
            this.ILFileTypes.Images.SetKeyName(8, "star.png");
            this.ILFileTypes.Images.SetKeyName(9, "program.png");
            this.ILFileTypes.Images.SetKeyName(10, "folder.png");
            this.ILFileTypes.Images.SetKeyName(11, "code.png");
            this.ILFileTypes.Images.SetKeyName(12, "archive.png");
            this.ILFileTypes.Images.SetKeyName(13, "playstation.png");
            this.ILFileTypes.Images.SetKeyName(14, "apple.png");
            this.ILFileTypes.Images.SetKeyName(15, "close.png");
            this.ILFileTypes.Images.SetKeyName(16, "settings.png");
            this.ILFileTypes.Images.SetKeyName(17, "checkmark.png");
            this.ILFileTypes.Images.SetKeyName(18, "code-working.png");
            this.ILFileTypes.Images.SetKeyName(19, "compose.png");
            this.ILFileTypes.Images.SetKeyName(20, "cube.png");
            this.ILFileTypes.Images.SetKeyName(21, "disc.png");
            this.ILFileTypes.Images.SetKeyName(22, "document.png");
            this.ILFileTypes.Images.SetKeyName(23, "document-text.png");
            this.ILFileTypes.Images.SetKeyName(24, "down.png");
            this.ILFileTypes.Images.SetKeyName(25, "efficient.png");
            this.ILFileTypes.Images.SetKeyName(26, "git.png");
            this.ILFileTypes.Images.SetKeyName(27, "grid.png");
            this.ILFileTypes.Images.SetKeyName(28, "left.png");
            this.ILFileTypes.Images.SetKeyName(29, "link.png");
            this.ILFileTypes.Images.SetKeyName(30, "minus.png");
            this.ILFileTypes.Images.SetKeyName(31, "music.png");
            this.ILFileTypes.Images.SetKeyName(32, "navicon.png");
            this.ILFileTypes.Images.SetKeyName(33, "network.png");
            this.ILFileTypes.Images.SetKeyName(34, "pinpoint.png");
            this.ILFileTypes.Images.SetKeyName(35, "plus.png");
            this.ILFileTypes.Images.SetKeyName(36, "right.png");
            this.ILFileTypes.Images.SetKeyName(37, "social-android.png");
            this.ILFileTypes.Images.SetKeyName(38, "sparse.png");
            this.ILFileTypes.Images.SetKeyName(39, "steam.png");
            this.ILFileTypes.Images.SetKeyName(40, "trash-b.png");
            this.ILFileTypes.Images.SetKeyName(41, "up.png");
            // 
            // BNewNode
            // 
            resources.ApplyResources(this.BNewNode, "BNewNode");
            this.BNewNode.Name = "BNewNode";
            this.BNewNode.UseVisualStyleBackColor = true;
            // 
            // TPSteam
            // 
            resources.ApplyResources(this.TPSteam, "TPSteam");
            this.TPSteam.Name = "TPSteam";
            this.TPSteam.UseVisualStyleBackColor = true;
            // 
            // TPPackaging
            // 
            resources.ApplyResources(this.TPPackaging, "TPPackaging");
            this.TPPackaging.Name = "TPPackaging";
            this.TPPackaging.UseVisualStyleBackColor = true;
            // 
            // MSToolbar
            // 
            resources.ApplyResources(this.MSToolbar, "MSToolbar");
            this.MSToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIProjects,
            this.TSMISettings,
            this.TSMIExit});
            this.MSToolbar.Name = "MSToolbar";
            // 
            // TSMIProjects
            // 
            resources.ApplyResources(this.TSMIProjects, "TSMIProjects");
            this.TSMIProjects.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMINewProject,
            this.TSSProject,
            this.TSMIGenerate});
            this.TSMIProjects.Name = "TSMIProjects";
            // 
            // TSMINewProject
            // 
            resources.ApplyResources(this.TSMINewProject, "TSMINewProject");
            this.TSMINewProject.Name = "TSMINewProject";
            this.TSMINewProject.Click += new System.EventHandler(this.TSMINewProject_Click);
            // 
            // TSSProject
            // 
            resources.ApplyResources(this.TSSProject, "TSSProject");
            this.TSSProject.Name = "TSSProject";
            // 
            // TSMIGenerate
            // 
            resources.ApplyResources(this.TSMIGenerate, "TSMIGenerate");
            this.TSMIGenerate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIGenCodeAnalysis,
            this.mD5HashToolStripMenuItem});
            this.TSMIGenerate.Name = "TSMIGenerate";
            // 
            // TSMIGenCodeAnalysis
            // 
            resources.ApplyResources(this.TSMIGenCodeAnalysis, "TSMIGenCodeAnalysis");
            this.TSMIGenCodeAnalysis.Name = "TSMIGenCodeAnalysis";
            // 
            // mD5HashToolStripMenuItem
            // 
            resources.ApplyResources(this.mD5HashToolStripMenuItem, "mD5HashToolStripMenuItem");
            this.mD5HashToolStripMenuItem.Name = "mD5HashToolStripMenuItem";
            // 
            // TSMISettings
            // 
            resources.ApplyResources(this.TSMISettings, "TSMISettings");
            this.TSMISettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIEditSettings,
            this.TSSSettings,
            this.TSMISaveSettings,
            this.TSMILoadSettings,
            this.TSMIResetSettings});
            this.TSMISettings.Name = "TSMISettings";
            // 
            // TSMIEditSettings
            // 
            resources.ApplyResources(this.TSMIEditSettings, "TSMIEditSettings");
            this.TSMIEditSettings.Name = "TSMIEditSettings";
            this.TSMIEditSettings.Click += new System.EventHandler(this.TSMIEditSettings_Click);
            // 
            // TSSSettings
            // 
            resources.ApplyResources(this.TSSSettings, "TSSSettings");
            this.TSSSettings.Name = "TSSSettings";
            // 
            // TSMISaveSettings
            // 
            resources.ApplyResources(this.TSMISaveSettings, "TSMISaveSettings");
            this.TSMISaveSettings.Name = "TSMISaveSettings";
            this.TSMISaveSettings.Click += new System.EventHandler(this.TSMISaveSettings_Click);
            // 
            // TSMILoadSettings
            // 
            resources.ApplyResources(this.TSMILoadSettings, "TSMILoadSettings");
            this.TSMILoadSettings.Name = "TSMILoadSettings";
            this.TSMILoadSettings.Click += new System.EventHandler(this.TSMILoadSettings_Click);
            // 
            // TSMIResetSettings
            // 
            resources.ApplyResources(this.TSMIResetSettings, "TSMIResetSettings");
            this.TSMIResetSettings.Name = "TSMIResetSettings";
            this.TSMIResetSettings.Click += new System.EventHandler(this.TSMIResetSettings_Click);
            // 
            // TSMIExit
            // 
            resources.ApplyResources(this.TSMIExit, "TSMIExit");
            this.TSMIExit.Name = "TSMIExit";
            this.TSMIExit.Click += new System.EventHandler(this.TSMIExit_Click);
            // 
            // GBControls
            // 
            resources.ApplyResources(this.GBControls, "GBControls");
            this.GBControls.Controls.Add(this.PBStatus);
            this.GBControls.Controls.Add(this.LOperation);
            this.GBControls.Controls.Add(this.TBVersion);
            this.GBControls.Controls.Add(this.LVersion);
            this.GBControls.Controls.Add(this.CBOperation);
            this.GBControls.Controls.Add(this.BExecute);
            this.GBControls.Name = "GBControls";
            this.GBControls.TabStop = false;
            // 
            // PBStatus
            // 
            resources.ApplyResources(this.PBStatus, "PBStatus");
            this.PBStatus.Name = "PBStatus";
            // 
            // LOperation
            // 
            resources.ApplyResources(this.LOperation, "LOperation");
            this.LOperation.Name = "LOperation";
            // 
            // TBVersion
            // 
            resources.ApplyResources(this.TBVersion, "TBVersion");
            this.TBVersion.Name = "TBVersion";
            // 
            // LVersion
            // 
            resources.ApplyResources(this.LVersion, "LVersion");
            this.LVersion.Name = "LVersion";
            // 
            // CBOperation
            // 
            resources.ApplyResources(this.CBOperation, "CBOperation");
            this.CBOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBOperation.FormattingEnabled = true;
            this.CBOperation.Items.AddRange(new object[] {
            resources.GetString("CBOperation.Items"),
            resources.GetString("CBOperation.Items1"),
            resources.GetString("CBOperation.Items2")});
            this.CBOperation.Name = "CBOperation";
            // 
            // BExecute
            // 
            resources.ApplyResources(this.BExecute, "BExecute");
            this.BExecute.Name = "BExecute";
            this.BExecute.UseVisualStyleBackColor = true;
            this.BExecute.Click += new System.EventHandler(this.BExecute_Click);
            // 
            // FBDExplorer
            // 
            resources.ApplyResources(this.FBDExplorer, "FBDExplorer");
            this.FBDExplorer.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.FBDExplorer.ShowNewFolderButton = false;
            // 
            // FSWLister
            // 
            this.FSWLister.EnableRaisingEvents = true;
            this.FSWLister.IncludeSubdirectories = true;
            this.FSWLister.NotifyFilter = ((System.IO.NotifyFilters)((((System.IO.NotifyFilters.FileName | System.IO.NotifyFilters.DirectoryName) 
            | System.IO.NotifyFilters.Size) 
            | System.IO.NotifyFilters.LastWrite)));
            this.FSWLister.SynchronizingObject = this;
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GBControls);
            this.Controls.Add(this.TCVariables);
            this.Controls.Add(this.MSToolbar);
            this.MainMenuStrip = this.MSToolbar;
            this.Name = "MainWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.TCVariables.ResumeLayout(false);
            this.TPEnvrionment.ResumeLayout(false);
            this.GBPaths.ResumeLayout(false);
            this.GBPaths.PerformLayout();
            this.GBRuntime.ResumeLayout(false);
            this.GBRuntime.PerformLayout();
            this.TPFileSources.ResumeLayout(false);
            this.MSToolbar.ResumeLayout(false);
            this.MSToolbar.PerformLayout();
            this.GBControls.ResumeLayout(false);
            this.GBControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FSWLister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TCVariables;
        private System.Windows.Forms.TabPage TPEnvrionment;
        private System.Windows.Forms.MenuStrip MSToolbar;
        private System.Windows.Forms.ToolStripMenuItem TSMIProjects;
        private System.Windows.Forms.ToolStripMenuItem TSMIGenerate;
        private System.Windows.Forms.ToolStripMenuItem TSMIExit;
        private System.Windows.Forms.GroupBox GBControls;
        private System.Windows.Forms.ComboBox CBOperation;
        private System.Windows.Forms.Button BExecute;
        private System.Windows.Forms.Label LVersion;
        private System.Windows.Forms.TextBox TBVersion;
        private System.Windows.Forms.Label LOperation;
        private System.Windows.Forms.GroupBox GBPaths;
        private System.Windows.Forms.TextBox TBProjectPath;
        private System.Windows.Forms.Button BRefreshEnv;
        private System.Windows.Forms.FolderBrowserDialog FBDExplorer;
        private System.Windows.Forms.TextBox TBMoonPath;
        private System.Windows.Forms.TextBox TBLuaPath;
        private System.Windows.Forms.GroupBox GBRuntime;
        private System.Windows.Forms.TextBox TBRuntimeLog;
        private System.Windows.Forms.CheckBox CBValidRoot;
        private System.Windows.Forms.CheckBox CBValidLua;
        private System.Windows.Forms.CheckBox CBValidMoon;
        private System.Windows.Forms.ToolStripMenuItem TSMIGenCodeAnalysis;
        private System.Windows.Forms.ToolStripMenuItem TSMISettings;
        private System.Windows.Forms.ToolStripMenuItem TSMIEditSettings;
        private System.Windows.Forms.ToolStripMenuItem TSMINewProject;
        private System.Windows.Forms.ToolStripSeparator TSSProject;
        private System.Windows.Forms.ToolStripMenuItem mD5HashToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator TSSSettings;
        private System.Windows.Forms.ToolStripMenuItem TSMISaveSettings;
        private System.Windows.Forms.ToolStripMenuItem TSMILoadSettings;
        private System.Windows.Forms.ProgressBar PBStatus;
        private System.Windows.Forms.TabPage TPFileSources;
        private System.Windows.Forms.TabPage TPSteam;
        private System.Windows.Forms.TabPage TPPackaging;
        private System.Windows.Forms.ToolStripMenuItem TSMIResetSettings;
        private System.Windows.Forms.TabPage TPCodeBrowser;
        private System.Windows.Forms.Button BDeleteNode;
        private System.Windows.Forms.TreeView TVFileStructure;
        private System.Windows.Forms.Button BNewNode;
        private System.IO.FileSystemWatcher FSWLister;
        private System.Windows.Forms.Button BExecuteNode;
        private System.Windows.Forms.ImageList ILFileTypes;
    }
}

