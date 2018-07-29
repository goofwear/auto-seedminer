namespace auto_seedminer {
    partial class FormSDCard {
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
            this.ddlDrives = new System.Windows.Forms.ComboBox();
            this.lblSDInfo = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ddlDrives
            // 
            this.ddlDrives.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlDrives.FormattingEnabled = true;
            this.ddlDrives.Location = new System.Drawing.Point(12, 15);
            this.ddlDrives.Name = "ddlDrives";
            this.ddlDrives.Size = new System.Drawing.Size(387, 21);
            this.ddlDrives.TabIndex = 0;
            // 
            // lblSDInfo
            // 
            this.lblSDInfo.Location = new System.Drawing.Point(405, 15);
            this.lblSDInfo.Name = "lblSDInfo";
            this.lblSDInfo.Size = new System.Drawing.Size(281, 99);
            this.lblSDInfo.TabIndex = 1;
            this.lblSDInfo.Text = "Insert the SD card you plan to use in your Nintendo 3DS, select it in the list, a" +
    "nd select Continue.";
            // 
            // btnContinue
            // 
            this.btnContinue.Enabled = false;
            this.btnContinue.Location = new System.Drawing.Point(12, 124);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(674, 23);
            this.btnContinue.TabIndex = 2;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // FormSDCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 159);
            this.ControlBox = false;
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.lblSDInfo);
            this.Controls.Add(this.ddlDrives);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormSDCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select SD Card";
            this.Load += new System.EventHandler(this.FormSDCard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ddlDrives;
        private System.Windows.Forms.Label lblSDInfo;
        private System.Windows.Forms.Button btnContinue;
    }
}