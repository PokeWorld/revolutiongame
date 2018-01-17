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
            this.lblAmethyst = new System.Windows.Forms.Label();
            this.lblAdvice = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tmText = new System.Windows.Forms.Timer(this.components);
            this.tmGraphic = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblAmethyst
            // 
            this.lblAmethyst.AutoSize = true;
            this.lblAmethyst.Font = new System.Drawing.Font("Lucida Console", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmethyst.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAmethyst.Location = new System.Drawing.Point(19, 19);
            this.lblAmethyst.Name = "lblAmethyst";
            this.lblAmethyst.Size = new System.Drawing.Size(252, 48);
            this.lblAmethyst.TabIndex = 0;
            this.lblAmethyst.Text = "Amethyst";
            // 
            // lblAdvice
            // 
            this.lblAdvice.AutoSize = true;
            this.lblAdvice.Font = new System.Drawing.Font("Lucida Console", 18F);
            this.lblAdvice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAdvice.Location = new System.Drawing.Point(22, 208);
            this.lblAdvice.Name = "lblAdvice";
            this.lblAdvice.Size = new System.Drawing.Size(402, 24);
            this.lblAdvice.TabIndex = 2;
            this.lblAdvice.Text = "More gameplay than ForumLife";
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Purple;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Lucida Console", 14F);
            this.btnPlay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPlay.Location = new System.Drawing.Point(27, 103);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(244, 40);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Purple;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Lucida Console", 14F);
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(27, 149);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(244, 40);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Close Game";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
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
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lblAmethyst);
            this.Controls.Add(this.lblAdvice);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuScreen";
            this.Text = "Project Amethyst";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAmethyst;
        private System.Windows.Forms.Label lblAdvice;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Timer tmText;
        private System.Windows.Forms.Timer tmGraphic;
    }
}

