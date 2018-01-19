namespace Amethyst
{
    partial class SiteAnalytics
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
            this.components = new System.ComponentModel.Container();
            this.lblSiteName = new System.Windows.Forms.Label();
            this.tmData = new System.Windows.Forms.Timer(this.components);
            this.lblAdIntensity = new System.Windows.Forms.Label();
            this.lblUserCount = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblAdsense = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSiteName
            // 
            this.lblSiteName.AutoSize = true;
            this.lblSiteName.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.lblSiteName.Location = new System.Drawing.Point(14, 109);
            this.lblSiteName.Name = "lblSiteName";
            this.lblSiteName.Size = new System.Drawing.Size(151, 14);
            this.lblSiteName.TabIndex = 0;
            this.lblSiteName.Text = "Network Name: null";
            // 
            // tmData
            // 
            this.tmData.Enabled = true;
            this.tmData.Interval = 10;
            this.tmData.Tick += new System.EventHandler(this.tmData_Tick);
            // 
            // lblAdIntensity
            // 
            this.lblAdIntensity.AutoSize = true;
            this.lblAdIntensity.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.lblAdIntensity.Location = new System.Drawing.Point(14, 95);
            this.lblAdIntensity.Name = "lblAdIntensity";
            this.lblAdIntensity.Size = new System.Drawing.Size(159, 14);
            this.lblAdIntensity.TabIndex = 1;
            this.lblAdIntensity.Text = "Ad Intensity = null";
            // 
            // lblUserCount
            // 
            this.lblUserCount.AutoSize = true;
            this.lblUserCount.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.lblUserCount.Location = new System.Drawing.Point(14, 81);
            this.lblUserCount.Name = "lblUserCount";
            this.lblUserCount.Size = new System.Drawing.Size(95, 14);
            this.lblUserCount.TabIndex = 2;
            this.lblUserCount.Text = "Users: null";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Lucida Console", 20F);
            this.lblTitle.Location = new System.Drawing.Point(12, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(156, 27);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Analytics";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Lucida Console", 12.5F);
            this.lblDesc.Location = new System.Drawing.Point(14, 44);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(508, 17);
            this.lblDesc.TabIndex = 4;
            this.lblDesc.Text = "Here, you will find the \"numbers\" of your network.";
            // 
            // lblAdsense
            // 
            this.lblAdsense.AutoSize = true;
            this.lblAdsense.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.lblAdsense.Location = new System.Drawing.Point(14, 123);
            this.lblAdsense.Name = "lblAdsense";
            this.lblAdsense.Size = new System.Drawing.Size(127, 14);
            this.lblAdsense.TabIndex = 5;
            this.lblAdsense.Text = "AdSense? : null";
            // 
            // SiteAnalytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblAdsense);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblUserCount);
            this.Controls.Add(this.lblAdIntensity);
            this.Controls.Add(this.lblSiteName);
            this.Name = "SiteAnalytics";
            this.Size = new System.Drawing.Size(747, 491);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSiteName;
        private System.Windows.Forms.Timer tmData;
        private System.Windows.Forms.Label lblAdIntensity;
        private System.Windows.Forms.Label lblUserCount;
        private System.Windows.Forms.Label  lblTitle;
        private System.Windows.Forms.Label  lblDesc;
        private System.Windows.Forms.Label lblAdsense;
    }
}
