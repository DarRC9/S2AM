
namespace AppDraft_WookieJoy
{
    partial class SplashScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.NameLabel = new System.Windows.Forms.Label();
            this.RightArrowPic = new System.Windows.Forms.PictureBox();
            this.LeftArrowPic = new System.Windows.Forms.PictureBox();
            this.LogoPic = new System.Windows.Forms.PictureBox();
            this.SplashTmr = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RightArrowPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftArrowPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("OCR A Extended", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(39)))), ((int)(((byte)(10)))));
            this.NameLabel.Location = new System.Drawing.Point(598, 462);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(215, 39);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "WookieJoy";
            // 
            // RightArrowPic
            // 
            this.RightArrowPic.Image = global::AppDraft_WookieJoy.Properties.Resources.output_onlinepngtools__1_;
            this.RightArrowPic.Location = new System.Drawing.Point(783, 374);
            this.RightArrowPic.Name = "RightArrowPic";
            this.RightArrowPic.Size = new System.Drawing.Size(100, 163);
            this.RightArrowPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RightArrowPic.TabIndex = 2;
            this.RightArrowPic.TabStop = false;
            // 
            // LeftArrowPic
            // 
            this.LeftArrowPic.Image = global::AppDraft_WookieJoy.Properties.Resources.output_onlinepngtools__2_;
            this.LeftArrowPic.Location = new System.Drawing.Point(524, 374);
            this.LeftArrowPic.Name = "LeftArrowPic";
            this.LeftArrowPic.Size = new System.Drawing.Size(100, 163);
            this.LeftArrowPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LeftArrowPic.TabIndex = 1;
            this.LeftArrowPic.TabStop = false;
            // 
            // LogoPic
            // 
            this.LogoPic.Image = global::AppDraft_WookieJoy.Properties.Resources.wookiejoybrown;
            this.LogoPic.InitialImage = ((System.Drawing.Image)(resources.GetObject("LogoPic.InitialImage")));
            this.LogoPic.Location = new System.Drawing.Point(594, 248);
            this.LogoPic.Name = "LogoPic";
            this.LogoPic.Size = new System.Drawing.Size(208, 196);
            this.LogoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPic.TabIndex = 0;
            this.LogoPic.TabStop = false;
            // 
            // SplashTmr
            // 
            this.SplashTmr.Enabled = true;
            this.SplashTmr.Interval = 1000;
            this.SplashTmr.Tick += new System.EventHandler(this.SplashTmr_Tick);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(246)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.RightArrowPic);
            this.Controls.Add(this.LeftArrowPic);
            this.Controls.Add(this.LogoPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RightArrowPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftArrowPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoPic;
        private System.Windows.Forms.PictureBox LeftArrowPic;
        private System.Windows.Forms.PictureBox RightArrowPic;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Timer SplashTmr;
    }
}

