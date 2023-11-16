namespace PracticaHashing
{
    partial class frmHashing
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnValida = new System.Windows.Forms.Button();
            this.txtOriginalSalt = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtHashedPassword = new System.Windows.Forms.TextBox();
            this.txtOriginalPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnValida
            // 
            this.btnValida.BackColor = System.Drawing.SystemColors.Control;
            this.btnValida.Location = new System.Drawing.Point(364, 21);
            this.btnValida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnValida.Name = "btnValida";
            this.btnValida.Size = new System.Drawing.Size(100, 28);
            this.btnValida.TabIndex = 0;
            this.btnValida.Text = "Valida";
            this.btnValida.UseVisualStyleBackColor = false;
            this.btnValida.Click += new System.EventHandler(this.btnValida_Click);
            // 
            // txtOriginalSalt
            // 
            this.txtOriginalSalt.Enabled = false;
            this.txtOriginalSalt.Location = new System.Drawing.Point(223, 23);
            this.txtOriginalSalt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOriginalSalt.Name = "txtOriginalSalt";
            this.txtOriginalSalt.Size = new System.Drawing.Size(709, 22);
            this.txtOriginalSalt.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(223, 23);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(132, 22);
            this.txtPassword.TabIndex = 2;
            // 
            // txtHashedPassword
            // 
            this.txtHashedPassword.Enabled = false;
            this.txtHashedPassword.Location = new System.Drawing.Point(223, 55);
            this.txtHashedPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHashedPassword.Name = "txtHashedPassword";
            this.txtHashedPassword.Size = new System.Drawing.Size(709, 22);
            this.txtHashedPassword.TabIndex = 3;
            // 
            // txtOriginalPassword
            // 
            this.txtOriginalPassword.Enabled = false;
            this.txtOriginalPassword.Location = new System.Drawing.Point(223, 55);
            this.txtOriginalPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtOriginalPassword.Name = "txtOriginalPassword";
            this.txtOriginalPassword.Size = new System.Drawing.Size(709, 22);
            this.txtOriginalPassword.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hashed salt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hashed  && salted password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(47, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 38);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hashed && salted entered password";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.txtOriginalSalt);
            this.groupBox1.Controls.Add(this.txtOriginalPassword);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(44, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1008, 123);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database Simulation";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Controls.Add(this.btnValida);
            this.groupBox2.Controls.Add(this.txtPassword);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtHashedPassword);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(44, 192);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1008, 123);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Login Simulation";
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.MediumBlue;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.White;
            this.lblResult.Location = new System.Drawing.Point(296, 350);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(172, 46);
            this.lblResult.TabIndex = 12;
            this.lblResult.Text = "?";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmHashing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 432);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmHashing";
            this.Text = "Hashing test";
            this.Load += new System.EventHandler(this.frmHashing_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnValida;
        private System.Windows.Forms.TextBox txtOriginalSalt;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtHashedPassword;
        private System.Windows.Forms.TextBox txtOriginalPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblResult;
    }
}

