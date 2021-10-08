
namespace LoveMaker.Forms {
    partial class InputBox {
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
            this.BCancel = new System.Windows.Forms.Button();
            this.BAccept = new System.Windows.Forms.Button();
            this.TBInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BCancel
            // 
            this.BCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BCancel.Location = new System.Drawing.Point(381, 41);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(75, 23);
            this.BCancel.TabIndex = 0;
            this.BCancel.Text = "Cancel";
            this.BCancel.UseVisualStyleBackColor = true;
            this.BCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // BAccept
            // 
            this.BAccept.Location = new System.Drawing.Point(12, 41);
            this.BAccept.Name = "BAccept";
            this.BAccept.Size = new System.Drawing.Size(363, 23);
            this.BAccept.TabIndex = 1;
            this.BAccept.Text = "Accept";
            this.BAccept.UseVisualStyleBackColor = true;
            this.BAccept.Click += new System.EventHandler(this.BAccept_Click);
            // 
            // TBInput
            // 
            this.TBInput.Location = new System.Drawing.Point(12, 12);
            this.TBInput.Name = "TBInput";
            this.TBInput.Size = new System.Drawing.Size(444, 23);
            this.TBInput.TabIndex = 2;
            this.TBInput.TextChanged += new System.EventHandler(this.TBInput_TextChanged);
            // 
            // InputBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 69);
            this.Controls.Add(this.TBInput);
            this.Controls.Add(this.BAccept);
            this.Controls.Add(this.BCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InputBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.InputBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BCancel;
        private System.Windows.Forms.Button BAccept;
        private System.Windows.Forms.TextBox TBInput;
    }
}