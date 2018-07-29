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
    public partial class FormWares : Form {

        private G4l.title selectedTitle;

        public FormWares() {
            InitializeComponent();
            lblInfo.Text = "To use Seedminer, you need a compatible, legitimately purchased, DSiWare title. \r\n\r\nSelect your eShop region below for a list of compatible titles, and their price.\r\n\r\nIf you do not already own a title on the list:\r\n\r\n1. Select a title on the list that you are willing to purchase\r\n\r\n2. Click the QR code button\r\n\r\n3. Make sure your SD card is inserted into your 3DS, turn it on, and go into the camera.\r\n\r\n4. Press the QR code button in the 3DS camera app and scan the QR code displayed by this program.\r\n\r\n5. Purchase and download the game.\r\n\r\nOnce you have the game downloaded, search for it in the list on the left, select it, and press Continue.";
        }

        private void UpdateListing() {
            U7s.log("Updating listing with search term " + txtSearch.Text);
            lstTitles.Items.Clear();
            if (cbxRegion.SelectedIndex == 0) {
                foreach (G4l.title k in G4l.titles_usa) {
                    if (txtSearch.Text.Count() == 0 || (txtSearch.Text.Count() > 0 && (k.name.ToUpper().Contains(txtSearch.Text.ToUpper()) || k.id.Contains(txtSearch.Text)))) {
                        ListViewItem item1 = new ListViewItem(k.name);
                        item1.SubItems.Add(k.price);
                        item1.SubItems.Add(k.id);
                        item1.SubItems.Add(k.region);
                        item1.Tag = k;

                        lstTitles.Items.Add(item1);
                    }
                }
            } else if (cbxRegion.SelectedIndex == 1) {
                foreach (G4l.title k in G4l.titles_eur) {
                    if (txtSearch.Text.Count() == 0 || (txtSearch.Text.Count() > 0 && (k.name.ToUpper().Contains(txtSearch.Text.ToUpper()) || k.id.Contains(txtSearch.Text)))) {
                        ListViewItem item1 = new ListViewItem(k.name);
                        item1.SubItems.Add(k.price);
                        item1.SubItems.Add(k.id);
                        item1.SubItems.Add(k.region);
                        item1.Tag = k;

                        lstTitles.Items.Add(item1);
                    }
                }
            } else {
                foreach (G4l.title k in G4l.titles_jpn) {
                    if (txtSearch.Text.Count() == 0 || (txtSearch.Text.Count() > 0 && (k.name.ToUpper().Contains(txtSearch.Text.ToUpper()) || k.id.Contains(txtSearch.Text)))) {
                        ListViewItem item1 = new ListViewItem(k.name);
                        item1.SubItems.Add(k.price);
                        item1.SubItems.Add(k.id);
                        item1.SubItems.Add(k.region);
                        item1.Tag = k;

                        lstTitles.Items.Add(item1);
                    }
                }
            }
        }

        private void cbxRegion_SelectedIndexChanged(object sender, EventArgs e) {
            U7s.log("User chose eShop region " + cbxRegion.SelectedText);
            txtSearch.Text = "";
            UpdateListing();
        }

        private void lstTitles_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e) {
            e.Cancel = true;
            e.NewWidth = lstTitles.Columns[e.ColumnIndex].Width;
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) UpdateListing();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) {
            if (txtSearch.Text.Count() == 0) UpdateListing();
        }

        private void lstTitles_SelectedIndexChanged(object sender, EventArgs e) {

            if (lstTitles.SelectedItems.Count > 0) {
                selectedTitle = (G4l.title)lstTitles.SelectedItems[0].Tag;
                lblSelected.Text = "Selected Title: " + selectedTitle.name;
                U7s.log("User selected title " + selectedTitle.name + " (" + selectedTitle.region + " | " + selectedTitle.id + ")");
            }

            btnQR.Enabled = (selectedTitle != null);
            btnContinue.Enabled = (selectedTitle != null);
            
            
        }

        private void btnQR_Click(object sender, EventArgs e) {
            new FormQR(selectedTitle.qrcode, selectedTitle.name + "(" + selectedTitle.region + ")").ShowDialog();
        }

        private void btnContinue_Click(object sender, EventArgs e) {
            U7s.log("User finished with title " + selectedTitle.name + " (" + selectedTitle.region + " | " + selectedTitle.id + ")");
            G4l.selectedTitle = selectedTitle;
            this.Close();
        }

        private void FormWares_Load(object sender, EventArgs e) {
            BringToFront();
        }
    }
}
