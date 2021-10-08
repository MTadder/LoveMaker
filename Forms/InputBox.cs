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
    public partial class InputBox : Form {
        public String Input = String.Empty;
        public InputBox(String title, String prompt) {
            InitializeComponent();
            this.Text = title;
            this.TBInput.PlaceholderText = prompt;
            this.BAccept.Enabled = false;
        }

        private void TBInput_TextChanged(Object sender, EventArgs e) {
            this.BAccept.Enabled = !this.TBInput.Text.Length.Equals(0);
            this.Input = this.TBInput.Text.Trim();
        }

        private void BAccept_Click(Object sender, EventArgs e) {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BCancel_Click(Object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void InputBox_Load(Object sender, EventArgs e) {

        }
    }
}
