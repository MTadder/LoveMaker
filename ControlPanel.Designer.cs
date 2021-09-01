
namespace LoveMaker
{
    partial class ControlPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlPanel));
            this.FSWatcher = new System.IO.FileSystemWatcher();
            this.tcParameters = new System.Windows.Forms.TabControl();
            this.tpEnv = new System.Windows.Forms.TabPage();
            this.tpMaker = new System.Windows.Forms.TabPage();
            this.bStart = new System.Windows.Forms.Button();
            this.lOperation = new System.Windows.Forms.Label();
            this.cbOperation = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.FSWatcher)).BeginInit();
            this.tcParameters.SuspendLayout();
            this.SuspendLayout();
            // 
            // FSWatcher
            // 
            this.FSWatcher.EnableRaisingEvents = true;
            this.FSWatcher.SynchronizingObject = this;
            // 
            // tcParameters
            // 
            this.tcParameters.Controls.Add(this.tpEnv);
            this.tcParameters.Controls.Add(this.tpMaker);
            this.tcParameters.Location = new System.Drawing.Point(12, 12);
            this.tcParameters.Name = "tcParameters";
            this.tcParameters.SelectedIndex = 0;
            this.tcParameters.Size = new System.Drawing.Size(860, 508);
            this.tcParameters.TabIndex = 0;
            // 
            // tpEnv
            // 
            this.tpEnv.CausesValidation = false;
            this.tpEnv.Location = new System.Drawing.Point(4, 24);
            this.tpEnv.Name = "tpEnv";
            this.tpEnv.Padding = new System.Windows.Forms.Padding(3);
            this.tpEnv.Size = new System.Drawing.Size(852, 480);
            this.tpEnv.TabIndex = 0;
            this.tpEnv.Text = "Environment";
            this.tpEnv.ToolTipText = "adjust package-specific settings";
            this.tpEnv.UseVisualStyleBackColor = true;
            // 
            // tpMaker
            // 
            this.tpMaker.Location = new System.Drawing.Point(4, 24);
            this.tpMaker.Name = "tpMaker";
            this.tpMaker.Padding = new System.Windows.Forms.Padding(3);
            this.tpMaker.Size = new System.Drawing.Size(852, 480);
            this.tpMaker.TabIndex = 1;
            this.tpMaker.Text = "Maker";
            this.tpMaker.UseVisualStyleBackColor = true;
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(797, 526);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(75, 23);
            this.bStart.TabIndex = 1;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            // 
            // lOperation
            // 
            this.lOperation.AutoSize = true;
            this.lOperation.Location = new System.Drawing.Point(544, 530);
            this.lOperation.Name = "lOperation";
            this.lOperation.Size = new System.Drawing.Size(60, 15);
            this.lOperation.TabIndex = 2;
            this.lOperation.Text = "Operation";
            // 
            // cbOperation
            // 
            this.cbOperation.FormattingEnabled = true;
            this.cbOperation.Location = new System.Drawing.Point(610, 527);
            this.cbOperation.Name = "cbOperation";
            this.cbOperation.Size = new System.Drawing.Size(181, 23);
            this.cbOperation.TabIndex = 3;
            // 
            // ControlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.cbOperation);
            this.Controls.Add(this.lOperation);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.tcParameters);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ControlPanel";
            this.Text = "LoveMaker";
            ((System.ComponentModel.ISupportInitialize)(this.FSWatcher)).EndInit();
            this.tcParameters.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher FSWatcher;
        private System.Windows.Forms.ComboBox cbOperation;
        private System.Windows.Forms.Label lOperation;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.TabControl tcParameters;
        private System.Windows.Forms.TabPage tpEnv;
        private System.Windows.Forms.TabPage tpMaker;
    }
}

