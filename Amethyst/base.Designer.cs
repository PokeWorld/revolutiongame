namespace Amethyst
{
    partial class @base
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblProg = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.tmClose = new System.Windows.Forms.Timer(this.components);
            this.tmOpen = new System.Windows.Forms.Timer(this.components);
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.White;
            this.pnlTitle.Controls.Add(this.pbIcon);
            this.pnlTitle.Controls.Add(this.btnMin);
            this.pnlTitle.Controls.Add(this.btnClose);
            this.pnlTitle.Controls.Add(this.lblProg);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(500, 30);
            this.pnlTitle.TabIndex = 0;
            this.pnlTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseDown);
            this.pnlTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseMove);
            this.pnlTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseUp);
            // 
            // pbIcon
            // 
            this.pbIcon.Location = new System.Drawing.Point(3, 3);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(25, 25);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIcon.TabIndex = 3;
            this.pbIcon.TabStop = false;
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.Yellow;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Location = new System.Drawing.Point(440, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(30, 30);
            this.btnMin.TabIndex = 2;
            this.btnMin.TabStop = false;
            this.btnMin.Text = "-";
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(470, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblProg
            // 
            this.lblProg.AutoSize = true;
            this.lblProg.BackColor = System.Drawing.Color.White;
            this.lblProg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProg.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.lblProg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblProg.Location = new System.Drawing.Point(34, 7);
            this.lblProg.Name = "lblProg";
            this.lblProg.Size = new System.Drawing.Size(118, 16);
            this.lblProg.TabIndex = 0;
            this.lblProg.Text = "ProgramName";
            this.lblProg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseDown);
            this.lblProg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseMove);
            this.lblProg.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlTitle_MouseUp);
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 30);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(500, 369);
            this.pnlContent.TabIndex = 1;
            // 
            // tmClose
            // 
            this.tmClose.Interval = 1;
            this.tmClose.Tick += new System.EventHandler(this.tmClose_Tick);
            // 
            // tmOpen
            // 
            this.tmOpen.Interval = 1;
            this.tmOpen.Tick += new System.EventHandler(this.tmOpen_Tick);
            // 
            // @base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 399);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "@base";
            this.Text = "base";
            this.Activated += new System.EventHandler(this.base_Activated);
            this.Deactivate += new System.EventHandler(this.base_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.base_FormClosing);
            this.Load += new System.EventHandler(this.base_Load);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Label lblProg;
        public System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Timer tmClose;
        private System.Windows.Forms.Timer tmOpen;
        #endregion

        public System.Windows.Forms.PictureBox pbIcon;
    }
}