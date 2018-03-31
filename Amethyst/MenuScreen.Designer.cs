namespace Amethyst
{
    partial class MenuScreen
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
            this.tmText = new System.Windows.Forms.Timer(this.components);
            this.tmGraphic = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAdvice = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblAmethyst = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmText
            // 
            this.tmText.Enabled = true;
            this.tmText.Interval = 10000;
            this.tmText.Tick += new System.EventHandler(this.tmText_Tick);
            // 
            // tmGraphic
            // 
            this.tmGraphic.Interval = 1;
            this.tmGraphic.Tick += new System.EventHandler(this.tmGraphic_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblAdvice);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.Controls.Add(this.lblAmethyst);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(353, 600);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(42, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome to the media revolution.";
            // 
            // lblAdvice
            // 
            this.lblAdvice.AutoSize = true;
            this.lblAdvice.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblAdvice.Font = new System.Drawing.Font("Lucida Console", 11F);
            this.lblAdvice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAdvice.Location = new System.Drawing.Point(0, 580);
            this.lblAdvice.Name = "lblAdvice";
            this.lblAdvice.Padding = new System.Windows.Forms.Padding(5, 0, 0, 5);
            this.lblAdvice.Size = new System.Drawing.Size(264, 20);
            this.lblAdvice.TabIndex = 3;
            this.lblAdvice.Text = "More gameplay than ForumLife";
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.btnExit.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExit.Location = new System.Drawing.Point(85, 132);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(189, 29);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnPlay
            // 
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.btnPlay.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPlay.Location = new System.Drawing.Point(85, 97);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(189, 29);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click_1);
            // 
            // lblAmethyst
            // 
            this.lblAmethyst.AutoSize = true;
            this.lblAmethyst.Font = new System.Drawing.Font("Lucida Console", 40F);
            this.lblAmethyst.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAmethyst.Location = new System.Drawing.Point(3, 20);
            this.lblAmethyst.Name = "lblAmethyst";
            this.lblAmethyst.Size = new System.Drawing.Size(353, 54);
            this.lblAmethyst.TabIndex = 0;
            this.lblAmethyst.Text = "Revolution";
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuScreen";
            this.Text = "Project Amethyst";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MenuScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmText;
        private System.Windows.Forms.Timer tmGraphic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAdvice;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblAmethyst;
        private System.Windows.Forms.Label label1;
    }
}

