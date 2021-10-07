
namespace LoveMaker.Forms {
    partial class LoveWizard {
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
            this.BFromDisk = new System.Windows.Forms.Button();
            this.BFromRepo = new System.Windows.Forms.Button();
            this.BFromTitle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BFromDisk
            // 
            this.BFromDisk.BackColor = System.Drawing.SystemColors.Info;
            this.BFromDisk.Dock = System.Windows.Forms.DockStyle.Top;
            this.BFromDisk.Location = new System.Drawing.Point(0, 0);
            this.BFromDisk.Name = "BFromDisk";
            this.BFromDisk.Size = new System.Drawing.Size(384, 23);
            this.BFromDisk.TabIndex = 0;
            this.BFromDisk.Text = "Project from Disk";
            this.BFromDisk.UseVisualStyleBackColor = false;
            // 
            // BFromRepo
            // 
            this.BFromRepo.BackColor = System.Drawing.SystemColors.Info;
            this.BFromRepo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BFromRepo.Location = new System.Drawing.Point(0, 23);
            this.BFromRepo.Name = "BFromRepo";
            this.BFromRepo.Size = new System.Drawing.Size(384, 23);
            this.BFromRepo.TabIndex = 1;
            this.BFromRepo.Text = "Project from Repository";
            this.BFromRepo.UseVisualStyleBackColor = false;
            // 
            // BFromTitle
            // 
            this.BFromTitle.BackColor = System.Drawing.SystemColors.Info;
            this.BFromTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.BFromTitle.Location = new System.Drawing.Point(0, 46);
            this.BFromTitle.Name = "BFromTitle";
            this.BFromTitle.Size = new System.Drawing.Size(384, 23);
            this.BFromTitle.TabIndex = 2;
            this.BFromTitle.Text = "Project from Title";
            this.BFromTitle.UseVisualStyleBackColor = false;
            // 
            // LoveWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 69);
            this.Controls.Add(this.BFromTitle);
            this.Controls.Add(this.BFromRepo);
            this.Controls.Add(this.BFromDisk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoveWizard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wizard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BFromDisk;
        private System.Windows.Forms.Button BFromRepo;
        private System.Windows.Forms.Button BFromTitle;
    }
}