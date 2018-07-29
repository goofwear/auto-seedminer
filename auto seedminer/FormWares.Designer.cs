namespace auto_seedminer {
    partial class FormWares {
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblRegion = new System.Windows.Forms.Label();
            this.lstTitles = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnRegion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbxRegion = new System.Windows.Forms.ComboBox();
            this.btnQR = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.lblSelected = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(690, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(354, 320);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "To use Seedminer, you need a legitimately purchased, and compatible, DSiWare titl" +
    "e.";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(12, 428);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(124, 13);
            this.lblSearch.TabIndex = 2;
            this.lblSearch.Text = "Search (enter to search):";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(142, 425);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(542, 20);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(691, 373);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(78, 13);
            this.lblRegion.TabIndex = 4;
            this.lblRegion.Text = "eShop Region:";
            // 
            // lstTitles
            // 
            this.lstTitles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnPrice,
            this.columnID,
            this.columnRegion});
            this.lstTitles.FullRowSelect = true;
            this.lstTitles.Location = new System.Drawing.Point(12, 12);
            this.lstTitles.MultiSelect = false;
            this.lstTitles.Name = "lstTitles";
            this.lstTitles.Size = new System.Drawing.Size(672, 407);
            this.lstTitles.TabIndex = 8;
            this.lstTitles.UseCompatibleStateImageBehavior = false;
            this.lstTitles.View = System.Windows.Forms.View.Details;
            this.lstTitles.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.lstTitles_ColumnWidthChanging);
            this.lstTitles.SelectedIndexChanged += new System.EventHandler(this.lstTitles_SelectedIndexChanged);
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 455;
            // 
            // columnPrice
            // 
            this.columnPrice.Text = "Price";
            this.columnPrice.Width = 58;
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            this.columnID.Width = 94;
            // 
            // columnRegion
            // 
            this.columnRegion.Text = "Region";
            // 
            // cbxRegion
            // 
            this.cbxRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxRegion.FormattingEnabled = true;
            this.cbxRegion.Items.AddRange(new object[] {
            "USA",
            "EUR",
            "JPN"});
            this.cbxRegion.Location = new System.Drawing.Point(775, 370);
            this.cbxRegion.Name = "cbxRegion";
            this.cbxRegion.Size = new System.Drawing.Size(157, 21);
            this.cbxRegion.TabIndex = 9;
            this.cbxRegion.SelectedIndexChanged += new System.EventHandler(this.cbxRegion_SelectedIndexChanged);
            // 
            // btnQR
            // 
            this.btnQR.Enabled = false;
            this.btnQR.Location = new System.Drawing.Point(690, 423);
            this.btnQR.Name = "btnQR";
            this.btnQR.Size = new System.Drawing.Size(242, 23);
            this.btnQR.TabIndex = 10;
            this.btnQR.Text = "QR Code";
            this.btnQR.UseVisualStyleBackColor = true;
            this.btnQR.Click += new System.EventHandler(this.btnQR_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.Enabled = false;
            this.btnContinue.Location = new System.Drawing.Point(938, 423);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(114, 23);
            this.btnContinue.TabIndex = 11;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Location = new System.Drawing.Point(691, 406);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(89, 13);
            this.lblSelected.TabIndex = 12;
            this.lblSelected.Text = "No Title Selected";
            // 
            // FormWares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 450);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnQR);
            this.Controls.Add(this.cbxRegion);
            this.Controls.Add(this.lstTitles);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblInfo);
            this.Name = "FormWares";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormWares";
            this.Load += new System.EventHandler(this.FormWares_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnPrice;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnRegion;
        private System.Windows.Forms.ComboBox cbxRegion;
        private System.Windows.Forms.ListView lstTitles;
        private System.Windows.Forms.Button btnQR;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label lblSelected;
    }
}