namespace Amethyst
{
    partial class DodgeTheAd
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboxYesOrNo = new System.Windows.Forms.ComboBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblAd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboxYesOrNo
            // 
            this.comboxYesOrNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxYesOrNo.Items.AddRange(new object[] {
            "Select An Option",
            "Yes",
            "No"});
            this.comboxYesOrNo.Location = new System.Drawing.Point(13, 63);
            this.comboxYesOrNo.Name = "comboxYesOrNo";
            this.comboxYesOrNo.Size = new System.Drawing.Size(121, 21);
            this.comboxYesOrNo.TabIndex = 8;
            this.comboxYesOrNo.TabStop = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.lblScore.Location = new System.Drawing.Point(581, 7);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(15, 14);
            this.lblScore.TabIndex = 7;
            this.lblScore.Text = "0";
            // 
            // btnCheck
            // 
            this.btnCheck.FlatAppearance.BorderSize = 0;
            this.btnCheck.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnCheck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnCheck.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.btnCheck.Location = new System.Drawing.Point(450, 51);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(144, 42);
            this.btnCheck.TabIndex = 6;
            this.btnCheck.TabStop = false;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Lucida Console", 15F);
            this.lblAd.Location = new System.Drawing.Point(9, 19);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(561, 20);
            this.lblAd.TabIndex = 5;
            this.lblAd.Text = "Ad for the newest version of Microsoft Windows";
            // 
            // DodgeTheAd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboxYesOrNo);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblAd);
            this.Name = "DodgeTheAd";
            this.Size = new System.Drawing.Size(605, 100);
            this.Load += new System.EventHandler(this.dodgeTheAd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ComboBox comboxYesOrNo;
        internal System.Windows.Forms.Label lblScore;
        internal System.Windows.Forms.Button btnCheck;
        internal System.Windows.Forms.Label lblAd;
    }
}
