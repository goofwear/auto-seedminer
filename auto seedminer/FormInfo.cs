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
using Microsoft.VisualBasic.FileIO;

namespace auto_seedminer {
    public partial class FormInfo : Form {
        public FormInfo() {
            InitializeComponent();
        }

        private void StartAuto() {
            G4l.safeToExit = true;

            G4l.sessionID = Guid.NewGuid().ToString().ToUpper().Replace("-", "");

            foreach (KeyValuePair<string, string> k in Ref.downloads) {
                U7s.DownloadFile(k.Key, k.Value);
            }

            U7s.info("Fetching DSiWare titles");
            U7s.GenerateTitleList();

            U7s.info("Prompting for DSiWare information");
            new FormWares().ShowDialog();

            U7s.info("Mounting SD Card");
            new FormSDCard().ShowDialog();

            U7s.log("Writing auto seedminer breadcrumb to SD card");
            FileSystem.WriteAllText(G4l.sdCard.RootDirectory + Ref.name_breadcrumb, G4l.sessionID, false);

            U7s.log("Renaming Nintendo 3DS to Nintendo 3DS AUTOSEEDMINER BACKUP");
            G4l.safeToExit = false;
            FileSystem.RenameDirectory(G4l.sdCard.RootDirectory + "\\Nintendo 3DS\\", Ref.name_3DSBackup);

            U7s.info("Requesting DSiWare dump");
            MessageBox.Show("Your HOME Menu will temporarily have all settings reset. This is temporary, and everything will be restored after this step.\r\n\r\n1. Turn off your 3DS, insert your SD card into your 3DS, and turn your 3DS back on.\r\n\r\n2. Open System Settings, navigate to Data Management > DSiWare\r\n\r\n3. Under system memory, look for the game you selected earlier (" + G4l.selectedTitle.name + ") and tap Copy\r\n\r\n4. Exit system settings and power off your 3DS.\r\n\r\n5. Reinsert your SD card into your PC.");

            U7s.info("Please reinsert your SD card after completing the previous step");
            U7s.WaitForSDRemount();

            U7s.info("Done!");
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
