
namespace CustomUserControls
{
    partial class AppLauncher
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
            this.components = new System.ComponentModel.Container();
            this.AppLauncherLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LaunchBtn = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AppLauncherLabel
            // 
            this.AppLauncherLabel.AutoSize = true;
            this.AppLauncherLabel.Location = new System.Drawing.Point(14, 14);
            this.AppLauncherLabel.Name = "AppLauncherLabel";
            this.AppLauncherLabel.Size = new System.Drawing.Size(97, 17);
            this.AppLauncherLabel.TabIndex = 0;
            this.AppLauncherLabel.Text = "App Launcher";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LaunchBtn);
            this.panel1.Controls.Add(this.AppLauncherLabel);
            this.panel1.Location = new System.Drawing.Point(31, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 56);
            this.panel1.TabIndex = 1;
            // 
            // LaunchBtn
            // 
            this.LaunchBtn.Location = new System.Drawing.Point(141, 11);
            this.LaunchBtn.Name = "LaunchBtn";
            this.LaunchBtn.Size = new System.Drawing.Size(75, 23);
            this.LaunchBtn.TabIndex = 1;
            this.LaunchBtn.Text = "Launch";
            this.LaunchBtn.UseVisualStyleBackColor = true;
            this.LaunchBtn.Click += new System.EventHandler(this.LaunchBtn_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // AppLauncher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "AppLauncher";
            this.Size = new System.Drawing.Size(301, 88);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label AppLauncherLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button LaunchBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
