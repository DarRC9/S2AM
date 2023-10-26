
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
            this.SWcodiLabel = new System.Windows.Forms.Label();
            this.SWTextboxLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.appLauncher2 = new CustomUserControls.AppLauncher();
            this.swCodi1 = new CustomUserControls.SWCodi();
            this.TextTxt = new InheritedControls.SWTextbox();
            this.CodiTxt = new InheritedControls.SWTextbox();
            this.NumeroTxt = new InheritedControls.SWTextbox();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(60, 43);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(222, 38);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Custom Controls";
            // 
            // NumeroLabel
            // 
            this.NumeroLabel.AutoSize = true;
            this.NumeroLabel.Location = new System.Drawing.Point(358, 133);
            this.NumeroLabel.Name = "NumeroLabel";
            this.NumeroLabel.Size = new System.Drawing.Size(58, 17);
            this.NumeroLabel.TabIndex = 4;
            this.NumeroLabel.Text = "Numero";
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Location = new System.Drawing.Point(370, 205);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(35, 17);
            this.TextLabel.TabIndex = 5;
            this.TextLabel.Text = "Text";
            // 
            // CodiLabel
            // 
            this.CodiLabel.AutoSize = true;
            this.CodiLabel.Location = new System.Drawing.Point(369, 268);
            this.CodiLabel.Name = "CodiLabel";
            this.CodiLabel.Size = new System.Drawing.Size(36, 17);
            this.CodiLabel.TabIndex = 6;
            this.CodiLabel.Text = "Codi";
            // 
            // ComplementariTxt
            // 
            this.ComplementariTxt.Enabled = false;
            this.ComplementariTxt.Location = new System.Drawing.Point(99, 131);
            this.ComplementariTxt.Name = "ComplementariTxt";
            this.ComplementariTxt.ReadOnly = true;
            this.ComplementariTxt.Size = new System.Drawing.Size(68, 22);
            this.ComplementariTxt.TabIndex = 7;
            // 
            // SWcodiLabel
            // 
            this.SWcodiLabel.AutoSize = true;
            this.SWcodiLabel.Location = new System.Drawing.Point(90, 346);
            this.SWcodiLabel.Name = "SWcodiLabel";
            this.SWcodiLabel.Size = new System.Drawing.Size(58, 17);
            this.SWcodiLabel.TabIndex = 13;
            this.SWcodiLabel.Text = "SWCodi";
            // 
            // SWTextboxLabel
            // 
            this.SWTextboxLabel.AutoSize = true;
            this.SWTextboxLabel.Location = new System.Drawing.Point(90, 97);
            this.SWTextboxLabel.Name = "SWTextboxLabel";
            this.SWTextboxLabel.Size = new System.Drawing.Size(79, 17);
            this.SWTextboxLabel.TabIndex = 16;
            this.SWTextboxLabel.Text = "SWTextbox";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 459);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "FormLauncher";
            // 
            // appLauncher2
            // 
            this.appLauncher2.Classe = "ShowForm";
            this.appLauncher2.Desc = "App";
            this.appLauncher2.Form = "FormToShow";
            this.appLauncher2.Location = new System.Drawing.Point(96, 497);
            this.appLauncher2.Name = "appLauncher2";
            this.appLauncher2.Size = new System.Drawing.Size(315, 150);
            this.appLauncher2.TabIndex = 15;
            // 
            // swCodi1
            // 
            this.swCodi1.Location = new System.Drawing.Point(67, 366);
            this.swCodi1.Name = "swCodi1";
            this.swCodi1.Nivell = CustomUserControls.SWCodi.TipusNivell.GS;
            this.swCodi1.Requerit = true;
            this.swCodi1.Size = new System.Drawing.Size(606, 87);
            this.swCodi1.TabIndex = 12;
            // 
            // TextTxt
            // 
            this.TextTxt.BackColor = System.Drawing.Color.LightGray;
            this.TextTxt.CampBuit = true;
            this.TextTxt.ClauForanea = true;
            this.TextTxt.ControlComplementari = "ComplementariTxt";
            this.TextTxt.DadaPermesa = InheritedControls.SWTextbox.TipusDada.Codi;
            this.TextTxt.ForeColor = System.Drawing.Color.Gray;
            this.TextTxt.Location = new System.Drawing.Point(189, 265);
            this.TextTxt.Name = "TextTxt";
            this.TextTxt.Placeholder = "Placeholder3";
            this.TextTxt.Size = new System.Drawing.Size(100, 22);
            this.TextTxt.TabIndex = 11;
            this.TextTxt.Text = "Placeholder3";
            // 
            // CodiTxt
            // 
            this.CodiTxt.BackColor = System.Drawing.Color.LightGray;
            this.CodiTxt.CampBuit = false;
            this.CodiTxt.ClauForanea = false;
            this.CodiTxt.ControlComplementari = "ComplementariTxt";
            this.CodiTxt.DadaPermesa = InheritedControls.SWTextbox.TipusDada.Text;
            this.CodiTxt.ForeColor = System.Drawing.Color.Gray;
            this.CodiTxt.Location = new System.Drawing.Point(189, 200);
            this.CodiTxt.Name = "CodiTxt";
            this.CodiTxt.Placeholder = "Placeholder2";
            this.CodiTxt.Size = new System.Drawing.Size(100, 22);
            this.CodiTxt.TabIndex = 10;
            this.CodiTxt.Text = "Placeholder2";
            // 
            // NumeroTxt
            // 
            this.NumeroTxt.BackColor = System.Drawing.Color.LightGray;
            this.NumeroTxt.CampBuit = true;
            this.NumeroTxt.ClauForanea = true;
            this.NumeroTxt.ControlComplementari = "ComplementariTxt";
            this.NumeroTxt.DadaPermesa = InheritedControls.SWTextbox.TipusDada.Numero;
            this.NumeroTxt.ForeColor = System.Drawing.Color.Gray;
            this.NumeroTxt.Location = new System.Drawing.Point(189, 130);
            this.NumeroTxt.Name = "NumeroTxt";
            this.NumeroTxt.Placeholder = "Placeholder1";
            this.NumeroTxt.Size = new System.Drawing.Size(100, 22);
            this.NumeroTxt.TabIndex = 9;
            this.NumeroTxt.Text = "Placeholder1";
            // 
            // frmCustomControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 707);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SWTextboxLabel);
            this.Controls.Add(this.appLauncher2);
            this.Controls.Add(this.SWcodiLabel);
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
        private CustomUserControls.SWCodi swCodi1;
        private System.Windows.Forms.Label SWcodiLabel;
        private CustomUserControls.AppLauncher appLauncher2;
        private System.Windows.Forms.Label SWTextboxLabel;
        private System.Windows.Forms.Label label1;
    }
}

