using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoveMaker.Forms {
    public partial class LoveWizard : Form {
        public String SelectedPath = String.Empty;
        public LoveWizard() {
            InitializeComponent();
        }

        private void BFromDisk_Click(Object sender, EventArgs e) {
            FolderBrowserDialog fbd = new();
            fbd.RootFolder = Environment.SpecialFolder.MyComputer;
            fbd.ShowNewFolderButton = false;
            var res = fbd.ShowDialog(this);
            if (res.Equals(DialogResult.OK)) {
                this.SelectedPath = fbd.SelectedPath;
                this.Close();
            }
        }

        private void BFromRepo_Click(Object sender, EventArgs e) {
            InputBox inp = new("Remote Clone", "Enter a repository link");
            if (inp.ShowDialog(this) == DialogResult.OK) {

            } else {
                this.Close();
            }
        }

        private void BFromTitle_Click(Object sender, EventArgs e) {
            InputBox inp = new("Game Title", "Enter a name");
            if (inp.ShowDialog(this) == DialogResult.OK) {
                
            } else {
                this.Close();
            }
        }
    }
}
