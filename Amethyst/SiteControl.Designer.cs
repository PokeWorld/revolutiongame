namespace Amethyst
{
    partial class SiteControl
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
            this.lblSiteName = new System.Windows.Forms.Label();
            this.txtbxsetSiteName = new System.Windows.Forms.TextBox();
            this.btnSetName = new System.Windows.Forms.Button();
            this.trackbarAdIntense = new System.Windows.Forms.TrackBar();
            this.lblAdIntense = new System.Windows.Forms.Label();
            this.btnSetIntensity = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.trackbarAdIntense)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSiteName
            // 
            this.lblSiteName.AutoSize = true;
            this.lblSiteName.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.lblSiteName.Location = new System.Drawing.Point(13, 68);
            this.lblSiteName.Name = "lblSiteName";
            this.lblSiteName.Size = new System.Drawing.Size(303, 14);
            this.lblSiteName.TabIndex = 0;
            this.lblSiteName.Text = "Enter the name of your network below.";
            // 
            // txtbxsetSiteName
            // 
            this.txtbxsetSiteName.Location = new System.Drawing.Point(16, 85);
            this.txtbxsetSiteName.Name = "txtbxsetSiteName";
            this.txtbxsetSiteName.Size = new System.Drawing.Size(186, 20);
            this.txtbxsetSiteName.TabIndex = 1;
            // 
            // btnSetName
            // 
            this.btnSetName.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.btnSetName.Location = new System.Drawing.Point(208, 86);
            this.btnSetName.Name = "btnSetName";
            this.btnSetName.Size = new System.Drawing.Size(108, 21);
            this.btnSetName.TabIndex = 2;
            this.btnSetName.Text = "Set Name";
            this.btnSetName.UseVisualStyleBackColor = true;
            this.btnSetName.Click += new System.EventHandler(this.btnSetName_Click);
            // 
            // trackbarAdIntense
            // 
            this.trackbarAdIntense.Location = new System.Drawing.Point(8, 125);
            this.trackbarAdIntense.Maximum = 3;
            this.trackbarAdIntense.Minimum = 1;
            this.trackbarAdIntense.Name = "trackbarAdIntense";
            this.trackbarAdIntense.Size = new System.Drawing.Size(268, 45);
            this.trackbarAdIntense.TabIndex = 3;
            this.trackbarAdIntense.Value = 1;
            this.trackbarAdIntense.ValueChanged += new System.EventHandler(this.trackbarAdIntense_ValueChanged);
            // 
            // lblAdIntense
            // 
            this.lblAdIntense.AutoSize = true;
            this.lblAdIntense.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.lblAdIntense.Location = new System.Drawing.Point(13, 108);
            this.lblAdIntense.Name = "lblAdIntense";
            this.lblAdIntense.Size = new System.Drawing.Size(175, 14);
            this.lblAdIntense.TabIndex = 4;
            this.lblAdIntense.Text = "Advertising Intensity";
            // 
            // btnSetIntensity
            // 
            this.btnSetIntensity.Font = new System.Drawing.Font("Lucida Console", 9F);
            this.btnSetIntensity.Location = new System.Drawing.Point(282, 125);
            this.btnSetIntensity.Name = "btnSetIntensity";
            this.btnSetIntensity.Size = new System.Drawing.Size(110, 20);
            this.btnSetIntensity.TabIndex = 5;
            this.btnSetIntensity.Text = "Set Intensity";
            this.btnSetIntensity.UseVisualStyleBackColor = true;
            this.btnSetIntensity.Click += new System.EventHandler(this.btnSetIntensity_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Lucida Console", 20F);
            this.lblTitle.Location = new System.Drawing.Point(3, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(220, 27);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Control Panel";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Lucida Console", 12.5F);
            this.Label1.Location = new System.Drawing.Point(5, 36);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(758, 17);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "Control your site here. From intensity of ads, to the name of your network.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.Label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(927, 65);
            this.panel1.TabIndex = 8;
            // 
            // SiteControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSetIntensity);
            this.Controls.Add(this.lblAdIntense);
            this.Controls.Add(this.trackbarAdIntense);
            this.Controls.Add(this.btnSetName);
            this.Controls.Add(this.txtbxsetSiteName);
            this.Controls.Add(this.lblSiteName);
            this.Name = "SiteControl";
            this.Size = new System.Drawing.Size(927, 537);
            this.Load += new System.EventHandler(this.SiteControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackbarAdIntense)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label lblSiteName; 
        private System.Windows.Forms.TextBox txtbxsetSiteName; 
        private System.Windows.Forms.Button btnSetName;
        private System.Windows.Forms.TrackBar trackbarAdIntense; 
        private System.Windows.Forms.Label lblAdIntense;
        private System.Windows.Forms.Button btnSetIntensity; 
        private System.Windows.Forms.Label lblTitle; 
        private System.Windows.Forms.Label Label1;
        #endregion

        private System.Windows.Forms.Panel panel1;
    }
}
