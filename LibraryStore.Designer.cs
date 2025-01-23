namespace LoveMaker;

partial class LibraryStore {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        var listViewGroup1 = new ListViewGroup("utilities", HorizontalAlignment.Center);
        var resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryStore));
        this.Libraries = new ListView();
        this.Cancel = new Button();
        this.Install = new Button();
        this.Docs = new Button();
        this.Refresh = new Button();
        this.SuspendLayout();
        // 
        // Libraries
        // 
        this.Libraries.Alignment = ListViewAlignment.SnapToGrid;
        this.Libraries.GridLines = true;
        listViewGroup1.Header = "utilities";
        listViewGroup1.HeaderAlignment = HorizontalAlignment.Center;
        listViewGroup1.Name = "lvg_utils";
        this.Libraries.Groups.AddRange(new ListViewGroup[] { listViewGroup1 });
        this.Libraries.Location = new Point(12, 41);
        this.Libraries.MultiSelect = false;
        this.Libraries.Name = "Libraries";
        this.Libraries.Size = new Size(292, 307);
        this.Libraries.TabIndex = 0;
        this.Libraries.UseCompatibleStateImageBehavior = false;
        this.Libraries.View = View.List;
        this.Libraries.SelectedIndexChanged += this.Libraries_SelectedIndexChanged;
        // 
        // Cancel
        // 
        this.Cancel.Location = new Point(12, 354);
        this.Cancel.Name = "Cancel";
        this.Cancel.Size = new Size(75, 23);
        this.Cancel.TabIndex = 1;
        this.Cancel.Text = "cancel";
        this.Cancel.UseVisualStyleBackColor = true;
        this.Cancel.Click += this.Cancel_Click;
        // 
        // Install
        // 
        this.Install.Enabled = false;
        this.Install.Location = new Point(229, 354);
        this.Install.Name = "Install";
        this.Install.Size = new Size(75, 23);
        this.Install.TabIndex = 2;
        this.Install.Text = "install";
        this.Install.UseVisualStyleBackColor = true;
        this.Install.Click += this.Install_Click;
        // 
        // Docs
        // 
        this.Docs.Enabled = false;
        this.Docs.Location = new Point(93, 354);
        this.Docs.Name = "Docs";
        this.Docs.Size = new Size(130, 23);
        this.Docs.TabIndex = 3;
        this.Docs.Text = "go to documentation";
        this.Docs.UseVisualStyleBackColor = true;
        this.Docs.Click += this.Docs_Click;
        // 
        // Refresh
        // 
        this.Refresh.Location = new Point(12, 12);
        this.Refresh.Name = "Refresh";
        this.Refresh.Size = new Size(75, 23);
        this.Refresh.TabIndex = 1;
        this.Refresh.Text = "refresh";
        this.Refresh.UseVisualStyleBackColor = true;
        this.Refresh.Click += this.Refresh_Click;
        // 
        // LibraryStore
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(316, 389);
        this.Controls.Add(this.Docs);
        this.Controls.Add(this.Install);
        this.Controls.Add(this.Refresh);
        this.Controls.Add(this.Cancel);
        this.Controls.Add(this.Libraries);
        this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        this.Icon = (Icon) resources.GetObject("$this.Icon");
        this.MaximizeBox = false;
        this.Name = "LibraryStore";
        this.ShowIcon = false;
        this.ShowInTaskbar = false;
        this.Text = "Library Store";
        this.Load += this.LibraryStore_Load;
        this.ResumeLayout(false);
    }

    #endregion

    private ListView Libraries;
    private Button Cancel;
    private Button Install;
    private Button Docs;
    private Button Refresh;
}