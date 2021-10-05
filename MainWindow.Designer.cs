
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.TCVariables = new System.Windows.Forms.TabControl();
            this.TPEnvrionment = new System.Windows.Forms.TabPage();
            this.GBPaths = new System.Windows.Forms.GroupBox();
            this.GBRuntime = new System.Windows.Forms.GroupBox();
            this.TBRuntimeLog = new System.Windows.Forms.TextBox();
            this.TBMoonPath = new System.Windows.Forms.TextBox();
            this.TBLuaPath = new System.Windows.Forms.TextBox();
            this.RBValidMoonscript = new System.Windows.Forms.RadioButton();
            this.RBValidLua = new System.Windows.Forms.RadioButton();
            this.RBValidRoot = new System.Windows.Forms.RadioButton();
            this.BOpenProject = new System.Windows.Forms.Button();
            this.BRefreshEnv = new System.Windows.Forms.Button();
            this.TBProjectPath = new System.Windows.Forms.TextBox();
            this.TPConf = new System.Windows.Forms.TabPage();
            this.GBConfVariables = new System.Windows.Forms.GroupBox();
            this.TVVariables = new System.Windows.Forms.TreeView();
            this.TPBuild = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CLBIncludes = new System.Windows.Forms.CheckedListBox();
            this.MSToolbar = new System.Windows.Forms.MenuStrip();
            this.TSMIProjects = new System.Windows.Forms.ToolStripMenuItem();
            this.generateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manifestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMITools = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMILove = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIVersioning = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMISteam = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIExit = new System.Windows.Forms.ToolStripMenuItem();
            this.GBControls = new System.Windows.Forms.GroupBox();
            this.LOperation = new System.Windows.Forms.Label();
            this.TBVersion = new System.Windows.Forms.TextBox();
            this.LVersion = new System.Windows.Forms.Label();
            this.LStatus = new System.Windows.Forms.Label();
            this.PBOperation = new System.Windows.Forms.ProgressBar();
            this.CBOperation = new System.Windows.Forms.ComboBox();
            this.BExecute = new System.Windows.Forms.Button();
            this.FBDExplorer = new System.Windows.Forms.FolderBrowserDialog();
            this.TCVariables.SuspendLayout();
            this.TPEnvrionment.SuspendLayout();
            this.GBPaths.SuspendLayout();
            this.GBRuntime.SuspendLayout();
            this.TPConf.SuspendLayout();
            this.GBConfVariables.SuspendLayout();
            this.TPBuild.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.MSToolbar.SuspendLayout();
            this.GBControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // TCVariables
            // 
            resources.ApplyResources(this.TCVariables, "TCVariables");
            this.TCVariables.Controls.Add(this.TPEnvrionment);
            this.TCVariables.Controls.Add(this.TPConf);
            this.TCVariables.Controls.Add(this.TPBuild);
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
            this.GBPaths.Controls.Add(this.GBRuntime);
            this.GBPaths.Controls.Add(this.TBMoonPath);
            this.GBPaths.Controls.Add(this.TBLuaPath);
            this.GBPaths.Controls.Add(this.RBValidMoonscript);
            this.GBPaths.Controls.Add(this.RBValidLua);
            this.GBPaths.Controls.Add(this.RBValidRoot);
            this.GBPaths.Controls.Add(this.BOpenProject);
            this.GBPaths.Controls.Add(this.BRefreshEnv);
            this.GBPaths.Controls.Add(this.TBProjectPath);
            this.GBPaths.Name = "GBPaths";
            this.GBPaths.TabStop = false;
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
            this.TBMoonPath.ReadOnly = true;
            // 
            // TBLuaPath
            // 
            resources.ApplyResources(this.TBLuaPath, "TBLuaPath");
            this.TBLuaPath.Name = "TBLuaPath";
            this.TBLuaPath.ReadOnly = true;
            // 
            // RBValidMoonscript
            // 
            resources.ApplyResources(this.RBValidMoonscript, "RBValidMoonscript");
            this.RBValidMoonscript.Name = "RBValidMoonscript";
            this.RBValidMoonscript.TabStop = true;
            this.RBValidMoonscript.UseVisualStyleBackColor = true;
            // 
            // RBValidLua
            // 
            resources.ApplyResources(this.RBValidLua, "RBValidLua");
            this.RBValidLua.Name = "RBValidLua";
            this.RBValidLua.TabStop = true;
            this.RBValidLua.UseVisualStyleBackColor = true;
            // 
            // RBValidRoot
            // 
            resources.ApplyResources(this.RBValidRoot, "RBValidRoot");
            this.RBValidRoot.Name = "RBValidRoot";
            this.RBValidRoot.TabStop = true;
            this.RBValidRoot.UseVisualStyleBackColor = true;
            // 
            // BOpenProject
            // 
            resources.ApplyResources(this.BOpenProject, "BOpenProject");
            this.BOpenProject.Name = "BOpenProject";
            this.BOpenProject.UseVisualStyleBackColor = true;
            this.BOpenProject.Click += new System.EventHandler(this.BOpenProject_Click);
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
            this.TBProjectPath.ReadOnly = true;
            // 
            // TPConf
            // 
            resources.ApplyResources(this.TPConf, "TPConf");
            this.TPConf.Controls.Add(this.GBConfVariables);
            this.TPConf.Name = "TPConf";
            this.TPConf.UseVisualStyleBackColor = true;
            // 
            // GBConfVariables
            // 
            resources.ApplyResources(this.GBConfVariables, "GBConfVariables");
            this.GBConfVariables.Controls.Add(this.TVVariables);
            this.GBConfVariables.Name = "GBConfVariables";
            this.GBConfVariables.TabStop = false;
            // 
            // TVVariables
            // 
            resources.ApplyResources(this.TVVariables, "TVVariables");
            this.TVVariables.Name = "TVVariables";
            // 
            // TPBuild
            // 
            resources.ApplyResources(this.TPBuild, "TPBuild");
            this.TPBuild.Controls.Add(this.groupBox1);
            this.TPBuild.Name = "TPBuild";
            this.TPBuild.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.CLBIncludes);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // CLBIncludes
            // 
            resources.ApplyResources(this.CLBIncludes, "CLBIncludes");
            this.CLBIncludes.FormattingEnabled = true;
            this.CLBIncludes.Name = "CLBIncludes";
            // 
            // MSToolbar
            // 
            resources.ApplyResources(this.MSToolbar, "MSToolbar");
            this.MSToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMIProjects,
            this.TSMITools,
            this.TSMIExit});
            this.MSToolbar.Name = "MSToolbar";
            // 
            // TSMIProjects
            // 
            resources.ApplyResources(this.TSMIProjects, "TSMIProjects");
            this.TSMIProjects.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateToolStripMenuItem});
            this.TSMIProjects.Name = "TSMIProjects";
            // 
            // generateToolStripMenuItem
            // 
            resources.ApplyResources(this.generateToolStripMenuItem, "generateToolStripMenuItem");
            this.generateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manifestToolStripMenuItem});
            this.generateToolStripMenuItem.Name = "generateToolStripMenuItem";
            // 
            // manifestToolStripMenuItem
            // 
            resources.ApplyResources(this.manifestToolStripMenuItem, "manifestToolStripMenuItem");
            this.manifestToolStripMenuItem.Name = "manifestToolStripMenuItem";
            // 
            // TSMITools
            // 
            resources.ApplyResources(this.TSMITools, "TSMITools");
            this.TSMITools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMILove,
            this.TSMIVersioning,
            this.TSMISteam});
            this.TSMITools.Name = "TSMITools";
            // 
            // TSMILove
            // 
            resources.ApplyResources(this.TSMILove, "TSMILove");
            this.TSMILove.Name = "TSMILove";
            // 
            // TSMIVersioning
            // 
            resources.ApplyResources(this.TSMIVersioning, "TSMIVersioning");
            this.TSMIVersioning.Name = "TSMIVersioning";
            // 
            // TSMISteam
            // 
            resources.ApplyResources(this.TSMISteam, "TSMISteam");
            this.TSMISteam.Name = "TSMISteam";
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
            this.GBControls.Controls.Add(this.LOperation);
            this.GBControls.Controls.Add(this.TBVersion);
            this.GBControls.Controls.Add(this.LVersion);
            this.GBControls.Controls.Add(this.LStatus);
            this.GBControls.Controls.Add(this.PBOperation);
            this.GBControls.Controls.Add(this.CBOperation);
            this.GBControls.Controls.Add(this.BExecute);
            this.GBControls.Name = "GBControls";
            this.GBControls.TabStop = false;
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
            // LStatus
            // 
            resources.ApplyResources(this.LStatus, "LStatus");
            this.LStatus.Name = "LStatus";
            // 
            // PBOperation
            // 
            resources.ApplyResources(this.PBOperation, "PBOperation");
            this.PBOperation.Name = "PBOperation";
            this.PBOperation.Step = 5;
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
            this.TPConf.ResumeLayout(false);
            this.GBConfVariables.ResumeLayout(false);
            this.TPBuild.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.MSToolbar.ResumeLayout(false);
            this.MSToolbar.PerformLayout();
            this.GBControls.ResumeLayout(false);
            this.GBControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TCVariables;
        private System.Windows.Forms.TabPage TPEnvrionment;
        private System.Windows.Forms.TabPage TPBuild;
        private System.Windows.Forms.MenuStrip MSToolbar;
        private System.Windows.Forms.ToolStripMenuItem TSMIProjects;
        private System.Windows.Forms.ToolStripMenuItem generateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manifestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMITools;
        private System.Windows.Forms.ToolStripMenuItem TSMILove;
        private System.Windows.Forms.ToolStripMenuItem TSMIVersioning;
        private System.Windows.Forms.ToolStripMenuItem TSMISteam;
        private System.Windows.Forms.ToolStripMenuItem TSMIExit;
        private System.Windows.Forms.GroupBox GBControls;
        private System.Windows.Forms.ComboBox CBOperation;
        private System.Windows.Forms.Button BExecute;
        private System.Windows.Forms.Label LVersion;
        private System.Windows.Forms.Label LStatus;
        private System.Windows.Forms.ProgressBar PBOperation;
        private System.Windows.Forms.TextBox TBVersion;
        private System.Windows.Forms.Label LOperation;
        private System.Windows.Forms.TabPage TPConf;
        private System.Windows.Forms.GroupBox GBPaths;
        private System.Windows.Forms.TextBox TBProjectPath;
        private System.Windows.Forms.Button BOpenProject;
        private System.Windows.Forms.Button BRefreshEnv;
        private System.Windows.Forms.GroupBox GBConfVariables;
        private System.Windows.Forms.FolderBrowserDialog FBDExplorer;
        private System.Windows.Forms.RadioButton RBValidRoot;
        private System.Windows.Forms.TreeView TVVariables;
        private System.Windows.Forms.CheckedListBox CLBIncludes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TBMoonPath;
        private System.Windows.Forms.TextBox TBLuaPath;
        private System.Windows.Forms.RadioButton RBValidMoonscript;
        private System.Windows.Forms.RadioButton RBValidLua;
        private System.Windows.Forms.GroupBox GBRuntime;
        private System.Windows.Forms.TextBox TBRuntimeLog;
    }
}

