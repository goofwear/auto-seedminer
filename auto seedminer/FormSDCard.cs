using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Dolinay;
using Microsoft.VisualBasic.FileIO;

namespace auto_seedminer {
    public partial class FormSDCard : Form {

        List<DriveInfo> rawDrives = new List<DriveInfo>();

        public FormSDCard() {
            InitializeComponent();
            DriveDetector driveDetector = new DriveDetector();
            driveDetector.DeviceArrived += new DriveDetectorEventHandler(OnDriveArrived);
            driveDetector.DeviceRemoved += new DriveDetectorEventHandler(OnDriveRemoved);
        }

        private void UpdateDevices() {
            ddlDrives.Items.Clear();
            rawDrives.Clear();
            foreach (DriveInfo drive in DriveInfo.GetDrives()) {
                if (drive.DriveType == DriveType.Removable) {
                    rawDrives.Add(drive);
                    ddlDrives.Items.Add("( " + drive.RootDirectory + " ) " + drive.VolumeLabel + " [ " + Math.Round(((drive.TotalSize - drive.TotalFreeSpace) / 1000000000.0), 2) + "GB /" + Math.Round((drive.TotalSize / 1000000000.0), 2) + "GB ]");
                    U7s.log("Found drive " + ddlDrives.Items[ddlDrives.Items.Count - 1]);
                }
            }

            if (ddlDrives.Items.Count > 0) {
                ddlDrives.SelectedIndex = 0;
                btnContinue.Enabled = true;
            } else btnContinue.Enabled = false;
        }

        private void btnContinue_Click(object sender, EventArgs e) {

            G4l.sdCard = rawDrives[ddlDrives.SelectedIndex];
            if (!FileSystem.DirectoryExists(G4l.sdCard.RootDirectory + "\\Nintendo 3DS\\")) {
                MessageBox.Show("That SD card has no 3DS information on it. Please make sure you use the SD card in your 3DS at least once.");
                return;
            }
            U7s.log("User confirmed SD selection: " + ddlDrives.Items[ddlDrives.SelectedIndex]);
            this.Close();
        }

        private void FormSDCard_Load(object sender, EventArgs e) {
            Activate();
            UpdateDevices();
        }


        private void OnDriveArrived(object sender, DriveDetectorEventArgs e) {
            e.HookQueryRemove = false;
            UpdateDevices();
        }


        private void OnDriveRemoved(object sender, DriveDetectorEventArgs e) {
            UpdateDevices();
        }
    }
}
