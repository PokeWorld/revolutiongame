namespace Amethyst
{
    partial class InProgressPlaceholder
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
            this.lblX = new System.Windows.Forms.Label();
            this.lblErrorType = new System.Windows.Forms.Label();
            this.lblErrorDesc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Lucida Console", 75F);
            this.lblX.ForeColor = System.Drawing.Color.Red;
            this.lblX.Location = new System.Drawing.Point(27, 24);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(102, 100);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "X";
            // 
            // lblErrorType
            // 
            this.lblErrorType.AutoSize = true;
            this.lblErrorType.Font = new System.Drawing.Font("Lucida Console", 20F);
            this.lblErrorType.Location = new System.Drawing.Point(134, 39);
            this.lblErrorType.Name = "lblErrorType";
            this.lblErrorType.Size = new System.Drawing.Size(140, 27);
            this.lblErrorType.TabIndex = 1;
            this.lblErrorType.Text = "Critical";
            // 
            // lblErrorDesc
            // 
            this.lblErrorDesc.AutoSize = true;
            this.lblErrorDesc.Font = new System.Drawing.Font("Lucida Console", 12F);
            this.lblErrorDesc.Location = new System.Drawing.Point(136, 90);
            this.lblErrorDesc.Name = "lblErrorDesc";
            this.lblErrorDesc.Size = new System.Drawing.Size(288, 16);
            this.lblErrorDesc.TabIndex = 2;
            this.lblErrorDesc.Text = "An unexpected error occured.";
            // 
            // InProgressPlaceholder
            // 
            this.Controls.Add(this.lblErrorDesc);
            this.Controls.Add(this.lblErrorType);
            this.Controls.Add(this.lblX);
            this.Name = "InProgressPlaceholder";
            this.Size = new System.Drawing.Size(532, 150);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblErrorType;
        private System.Windows.Forms.Label lblErrorDesc;
    }
}
