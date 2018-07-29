namespace auto_seedminer {
    partial class FormLanding {
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
            this.lblRequiredReading = new System.Windows.Forms.Label();
            this.lblPreRead = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.cbxConfirm = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblRequiredReading
            // 
            this.lblRequiredReading.AutoSize = true;
            this.lblRequiredReading.Location = new System.Drawing.Point(12, 9);
            this.lblRequiredReading.Name = "lblRequiredReading";
            this.lblRequiredReading.Size = new System.Drawing.Size(96, 13);
            this.lblRequiredReading.TabIndex = 0;
            this.lblRequiredReading.Text = "Required Reading:";
            // 
            // lblPreRead
            // 
            this.lblPreRead.Location = new System.Drawing.Point(28, 29);
            this.lblPreRead.Name = "lblPreRead";
            this.lblPreRead.Size = new System.Drawing.Size(760, 320);
            this.lblPreRead.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 375);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(776, 63);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Lets Begin!";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cbxConfirm
            // 
            this.cbxConfirm.AutoSize = true;
            this.cbxConfirm.Location = new System.Drawing.Point(15, 352);
            this.cbxConfirm.Name = "cbxConfirm";
            this.cbxConfirm.Size = new System.Drawing.Size(185, 17);
            this.cbxConfirm.TabIndex = 3;
            this.cbxConfirm.Text = "I have read the information above";
            this.cbxConfirm.UseVisualStyleBackColor = true;
            // 
            // FormLanding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.cbxConfirm);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblPreRead);
            this.Controls.Add(this.lblRequiredReading);
            this.Name = "FormLanding";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "auto seedminer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRequiredReading;
        private System.Windows.Forms.Label lblPreRead;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.CheckBox cbxConfirm;
    }
}

