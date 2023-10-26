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
            this.CodiLabel = new System.Windows.Forms.Label();
            this.DescripcioLabel = new System.Windows.Forms.Label();
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
            // CodiLabel
            // 
            this.CodiLabel.AutoSize = true;
            this.CodiLabel.Location = new System.Drawing.Point(28, 15);
            this.CodiLabel.Name = "CodiLabel";
            this.CodiLabel.Size = new System.Drawing.Size(36, 17);
            this.CodiLabel.TabIndex = 2;
            this.CodiLabel.Text = "Codi";
            // 
            // DescripcioLabel
            // 
            this.DescripcioLabel.AutoSize = true;
            this.DescripcioLabel.Location = new System.Drawing.Point(172, 15);
            this.DescripcioLabel.Name = "DescripcioLabel";
            this.DescripcioLabel.Size = new System.Drawing.Size(74, 17);
            this.DescripcioLabel.TabIndex = 3;
            this.DescripcioLabel.Text = "Descripcio";
            // 
            // SWCodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DescripcioLabel);
            this.Controls.Add(this.CodiLabel);
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
        private System.Windows.Forms.Label CodiLabel;
        private System.Windows.Forms.Label DescripcioLabel;
    }
}
