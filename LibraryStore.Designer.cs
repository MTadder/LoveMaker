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
        this.components = new System.ComponentModel.Container();
        var listViewGroup1 = new ListViewGroup("utilities", HorizontalAlignment.Center);
        var listViewItem1 = new ListViewItem("hump", 8);
        var listViewItem2 = new ListViewItem("omk", 0);
        var resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryStore));
        this.Libraries = new ListView();
        this.imageList1 = new ImageList(this.components);
        this.Cancel = new Button();
        this.Install = new Button();
        this.Docs = new Button();
        this.SuspendLayout();
        // 
        // Libraries
        // 
        this.Libraries.GridLines = true;
        listViewGroup1.Header = "utilities";
        listViewGroup1.HeaderAlignment = HorizontalAlignment.Center;
        listViewGroup1.Name = "lvg_utils";
        this.Libraries.Groups.AddRange(new ListViewGroup[] { listViewGroup1 });
        listViewItem1.Group = listViewGroup1;
        listViewItem2.Group = listViewGroup1;
        this.Libraries.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2 });
        this.Libraries.LargeImageList = this.imageList1;
        this.Libraries.Location = new Point(12, 12);
        this.Libraries.MultiSelect = false;
        this.Libraries.Name = "Libraries";
        this.Libraries.Size = new Size(292, 336);
        this.Libraries.SmallImageList = this.imageList1;
        this.Libraries.StateImageList = this.imageList1;
        this.Libraries.TabIndex = 0;
        this.Libraries.UseCompatibleStateImageBehavior = false;
        this.Libraries.View = View.SmallIcon;
        this.Libraries.SelectedIndexChanged += this.Libraries_SelectedIndexChanged;
        // 
        // imageList1
        // 
        this.imageList1.ColorDepth = ColorDepth.Depth32Bit;
        this.imageList1.ImageStream = (ImageListStreamer) resources.GetObject("imageList1.ImageStream");
        this.imageList1.TransparentColor = Color.Transparent;
        this.imageList1.Images.SetKeyName(0, "alert.png");
        this.imageList1.Images.SetKeyName(1, "apple.png");
        this.imageList1.Images.SetKeyName(2, "archive.png");
        this.imageList1.Images.SetKeyName(3, "asterisk.png");
        this.imageList1.Images.SetKeyName(4, "bug.png");
        this.imageList1.Images.SetKeyName(5, "checkmark.png");
        this.imageList1.Images.SetKeyName(6, "close.png");
        this.imageList1.Images.SetKeyName(7, "code.png");
        this.imageList1.Images.SetKeyName(8, "code-working.png");
        this.imageList1.Images.SetKeyName(9, "compose.png");
        this.imageList1.Images.SetKeyName(10, "cube.png");
        this.imageList1.Images.SetKeyName(11, "disc.png");
        this.imageList1.Images.SetKeyName(12, "document.png");
        this.imageList1.Images.SetKeyName(13, "document-text.png");
        this.imageList1.Images.SetKeyName(14, "down.png");
        this.imageList1.Images.SetKeyName(15, "efficient.png");
        this.imageList1.Images.SetKeyName(16, "folder.png");
        this.imageList1.Images.SetKeyName(17, "git.png");
        this.imageList1.Images.SetKeyName(18, "grid.png");
        this.imageList1.Images.SetKeyName(19, "halt.png");
        this.imageList1.Images.SetKeyName(20, "help.png");
        this.imageList1.Images.SetKeyName(21, "help-circled.png");
        this.imageList1.Images.SetKeyName(22, "left.png");
        this.imageList1.Images.SetKeyName(23, "link.png");
        this.imageList1.Images.SetKeyName(24, "locked.png");
        this.imageList1.Images.SetKeyName(25, "minus.png");
        this.imageList1.Images.SetKeyName(26, "music.png");
        this.imageList1.Images.SetKeyName(27, "navicon.png");
        this.imageList1.Images.SetKeyName(28, "network.png");
        this.imageList1.Images.SetKeyName(29, "pinpoint.png");
        this.imageList1.Images.SetKeyName(30, "playstation.png");
        this.imageList1.Images.SetKeyName(31, "plus.png");
        this.imageList1.Images.SetKeyName(32, "program.png");
        this.imageList1.Images.SetKeyName(33, "pull.png");
        this.imageList1.Images.SetKeyName(34, "right.png");
        this.imageList1.Images.SetKeyName(35, "settings.png");
        this.imageList1.Images.SetKeyName(36, "social-android.png");
        this.imageList1.Images.SetKeyName(37, "sparse.png");
        this.imageList1.Images.SetKeyName(38, "star.png");
        this.imageList1.Images.SetKeyName(39, "steam.png");
        this.imageList1.Images.SetKeyName(40, "trash-b.png");
        this.imageList1.Images.SetKeyName(41, "unavailable.png");
        this.imageList1.Images.SetKeyName(42, "up.png");
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
        // 
        // LibraryStore
        // 
        this.AutoScaleDimensions = new SizeF(7F, 15F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(316, 389);
        this.Controls.Add(this.Docs);
        this.Controls.Add(this.Install);
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
    private ImageList imageList1;
    private Button Cancel;
    private Button Install;
    private Button Docs;
}