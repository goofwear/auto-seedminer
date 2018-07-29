using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace auto_seedminer {
    public partial class FormInfo : Form {
        public FormInfo() {
            InitializeComponent();
        }

        private void StartAuto() {
            G4l.safeToExit = true;

            foreach(KeyValuePair<string, string> k in Ref.downloads) {
                U7s.DownloadFile(k.Key, k.Value);
            }

            U7s.info("Fetching DSiWare titles");
            U7s.GenerateTitleList();

            U7s.info("Prompting for DSiWare information");
            new FormWares().ShowDialog();

            U7s.info("Mounting SD Card");
            new FormSDCard().ShowDialog();
            U7s.info("Mounted SD Card");
        }

        private void FormInfo_FormClosing(object sender, FormClosingEventArgs e) {
            if (!G4l.safeToExit) e.Cancel = true;
            else Application.Exit();
        }

        private void FormInfo_Load(object sender, EventArgs e) {
            BringToFront();
            Task.Factory.StartNew(new Action(() => StartAuto()));
        }
    }
}
