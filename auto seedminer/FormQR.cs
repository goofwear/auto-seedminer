using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace auto_seedminer {
    public partial class FormQR : Form {
        public FormQR(string qrPath, string name) {
            InitializeComponent();
            lblTitle.Text = "QR Code for " + name;
            picQR.ImageLocation = qrPath;
        }

        private void btnClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void FormQR_Load(object sender, EventArgs e) {
            BringToFront();
        }
    }
}
