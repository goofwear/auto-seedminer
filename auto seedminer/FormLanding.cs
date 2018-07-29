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
    public partial class FormLanding : Form {
        public FormLanding() {
            InitializeComponent();
            lblPreRead.Text = "This application will walk you through the process of using SeedMiner on your Nintendo 3DS to achieve custom firmware.\r\n\r\nIf you have just stumbled upon this application, you should check https://3ds.hacks.guide before using this, as there may be a faster method to hacking your 3DS! Only use this if you are certain SeedMiner is the best option for you.\r\n\r\nTo use this application, basic reading ability is required. Follow all steps exactly as described!\r\n\r\nForce stopping the application, or quitting partway through, may cause problems on your 3DS! If you wish to quit at any point during this process, check the bottom left corner of whatever window you are on to know if it is safe to stop!";
        }

        private void btnStart_Click(object sender, EventArgs e) {
            this.Visible = false;
            G4l.frmInfo = new FormInfo();
            G4l.frmInfo.ShowDialog();
        }
    }
}
