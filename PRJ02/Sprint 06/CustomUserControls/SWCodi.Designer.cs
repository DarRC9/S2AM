namespace CustomUserControls
{
    partial class SWCodi
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
            this.CodiTxt = new System.Windows.Forms.TextBox();
            this.DescTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CodiTxt
            // 
            this.CodiTxt.Location = new System.Drawing.Point(31, 35);
            this.CodiTxt.Name = "CodiTxt";
            this.CodiTxt.Size = new System.Drawing.Size(100, 22);
            this.CodiTxt.TabIndex = 0;
            this.CodiTxt.Leave += new System.EventHandler(this.CodiTxt_Leave);
            // 
            // DescTxt
            // 
            this.DescTxt.Location = new System.Drawing.Point(175, 35);
            this.DescTxt.Name = "DescTxt";
            this.DescTxt.Size = new System.Drawing.Size(412, 22);
            this.DescTxt.TabIndex = 1;
            // 
            // SWCodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DescTxt);
            this.Controls.Add(this.CodiTxt);
            this.Name = "SWCodi";
            this.Size = new System.Drawing.Size(620, 90);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CodiTxt;
        private System.Windows.Forms.TextBox DescTxt;
    }
}
