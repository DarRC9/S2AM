
namespace CustomControls
{
    partial class frmCustomControls
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.NumeroLabel = new System.Windows.Forms.Label();
            this.TextLabel = new System.Windows.Forms.Label();
            this.CodiLabel = new System.Windows.Forms.Label();
            this.ComplementariTxt = new System.Windows.Forms.TextBox();
            this.TextTxt = new InheritedControls.SWTextbox();
            this.CodiTxt = new InheritedControls.SWTextbox();
            this.NumeroTxt = new InheritedControls.SWTextbox();
            this.swCodi1 = new Controls.SWCodi();
            this.appLauncher1 = new Controls.AppLauncher();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(102, 70);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(222, 38);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Custom Controls";
            // 
            // NumeroLabel
            // 
            this.NumeroLabel.AutoSize = true;
            this.NumeroLabel.Location = new System.Drawing.Point(641, 87);
            this.NumeroLabel.Name = "NumeroLabel";
            this.NumeroLabel.Size = new System.Drawing.Size(58, 17);
            this.NumeroLabel.TabIndex = 4;
            this.NumeroLabel.Text = "Numero";
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Location = new System.Drawing.Point(653, 154);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(35, 17);
            this.TextLabel.TabIndex = 5;
            this.TextLabel.Text = "Text";
            // 
            // CodiLabel
            // 
            this.CodiLabel.AutoSize = true;
            this.CodiLabel.Location = new System.Drawing.Point(653, 211);
            this.CodiLabel.Name = "CodiLabel";
            this.CodiLabel.Size = new System.Drawing.Size(36, 17);
            this.CodiLabel.TabIndex = 6;
            this.CodiLabel.Text = "Codi";
            // 
            // ComplementariTxt
            // 
            this.ComplementariTxt.Location = new System.Drawing.Point(382, 85);
            this.ComplementariTxt.Name = "ComplementariTxt";
            this.ComplementariTxt.Size = new System.Drawing.Size(68, 22);
            this.ComplementariTxt.TabIndex = 7;
            // 
            // TextTxt
            // 
            this.TextTxt.BackColor = System.Drawing.Color.LightGray;
            this.TextTxt.CampBuit = true;
            this.TextTxt.ClauForanea = true;
            this.TextTxt.ControlComplementari = null;
            this.TextTxt.DadaPermesa = InheritedControls.SWTextbox.TipusDada.Numero;
            this.TextTxt.ForeColor = System.Drawing.Color.Gray;
            this.TextTxt.Location = new System.Drawing.Point(472, 151);
            this.TextTxt.Name = "TextTxt";
            this.TextTxt.Placeholder = "Placeholder";
            this.TextTxt.Size = new System.Drawing.Size(100, 22);
            this.TextTxt.TabIndex = 11;
            this.TextTxt.Text = "Placeholder";
            // 
            // CodiTxt
            // 
            this.CodiTxt.BackColor = System.Drawing.Color.LightGray;
            this.CodiTxt.CampBuit = true;
            this.CodiTxt.ClauForanea = true;
            this.CodiTxt.ControlComplementari = null;
            this.CodiTxt.DadaPermesa = InheritedControls.SWTextbox.TipusDada.Numero;
            this.CodiTxt.ForeColor = System.Drawing.Color.Gray;
            this.CodiTxt.Location = new System.Drawing.Point(472, 211);
            this.CodiTxt.Name = "CodiTxt";
            this.CodiTxt.Placeholder = "Placeholder";
            this.CodiTxt.Size = new System.Drawing.Size(100, 22);
            this.CodiTxt.TabIndex = 10;
            this.CodiTxt.Text = "Placeholder";
            // 
            // NumeroTxt
            // 
            this.NumeroTxt.BackColor = System.Drawing.Color.LightGray;
            this.NumeroTxt.CampBuit = true;
            this.NumeroTxt.ClauForanea = true;
            this.NumeroTxt.ControlComplementari = null;
            this.NumeroTxt.DadaPermesa = InheritedControls.SWTextbox.TipusDada.Numero;
            this.NumeroTxt.ForeColor = System.Drawing.Color.Gray;
            this.NumeroTxt.Location = new System.Drawing.Point(472, 84);
            this.NumeroTxt.Name = "NumeroTxt";
            this.NumeroTxt.Placeholder = "Placeholder";
            this.NumeroTxt.Size = new System.Drawing.Size(100, 22);
            this.NumeroTxt.TabIndex = 9;
            this.NumeroTxt.Text = "Placeholder";
            // 
            // swCodi1
            // 
            this.swCodi1.Location = new System.Drawing.Point(109, 261);
            this.swCodi1.Name = "swCodi1";
            this.swCodi1.Nivell = Controls.SWCodi.TipusNivell.GM;
            this.swCodi1.Requerit = true;
            this.swCodi1.Size = new System.Drawing.Size(527, 111);
            this.swCodi1.TabIndex = 12;
            // 
            // appLauncher1
            // 
            this.appLauncher1.DadaPermesa = Controls.AppLauncher.TipusDada.Text;
            this.appLauncher1.Location = new System.Drawing.Point(51, 151);
            this.appLauncher1.Name = "appLauncher1";
            this.appLauncher1.Size = new System.Drawing.Size(446, 202);
            this.appLauncher1.TabIndex = 13;
            // 
            // frmCustomControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.appLauncher1);
            this.Controls.Add(this.swCodi1);
            this.Controls.Add(this.TextTxt);
            this.Controls.Add(this.CodiTxt);
            this.Controls.Add(this.NumeroTxt);
            this.Controls.Add(this.ComplementariTxt);
            this.Controls.Add(this.CodiLabel);
            this.Controls.Add(this.TextLabel);
            this.Controls.Add(this.NumeroLabel);
            this.Controls.Add(this.TitleLabel);
            this.Name = "frmCustomControls";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label NumeroLabel;
        private System.Windows.Forms.Label TextLabel;
        private System.Windows.Forms.Label CodiLabel;
        private System.Windows.Forms.TextBox ComplementariTxt;
        private InheritedControls.SWTextbox NumeroTxt;
        private InheritedControls.SWTextbox CodiTxt;
        private InheritedControls.SWTextbox TextTxt;
        private Controls.SWCodi swCodi1;
        private Controls.AppLauncher appLauncher1;
    }
}

