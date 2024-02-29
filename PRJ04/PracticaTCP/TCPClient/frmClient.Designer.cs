namespace TCPClient
{
    partial class frmClient
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
            this.btn_config = new System.Windows.Forms.Button();
            this.btn_desconnect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_sendMessage = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_message = new System.Windows.Forms.TextBox();
            this.txb_port = new System.Windows.Forms.TextBox();
            this.txb_ip = new System.Windows.Forms.TextBox();
            this.btn_sendFile = new System.Windows.Forms.Button();
            this.gbx_comprovacions = new System.Windows.Forms.GroupBox();
            this.lb_statusInfo = new System.Windows.Forms.Label();
            this.pnl_status = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbx_console = new System.Windows.Forms.ListBox();
            this.btn_comprovarXarxa = new System.Windows.Forms.Button();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_browseFile = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txb_portA = new System.Windows.Forms.TextBox();
            this.txb_ipA = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.gbx_comprovacions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_config
            // 
            this.btn_config.Location = new System.Drawing.Point(891, 428);
            this.btn_config.Name = "btn_config";
            this.btn_config.Size = new System.Drawing.Size(129, 37);
            this.btn_config.TabIndex = 11;
            this.btn_config.Text = "Configuració";
            this.btn_config.UseVisualStyleBackColor = true;
            this.btn_config.Click += new System.EventHandler(this.btn_config_Click);
            // 
            // btn_desconnect
            // 
            this.btn_desconnect.Location = new System.Drawing.Point(1030, 428);
            this.btn_desconnect.Name = "btn_desconnect";
            this.btn_desconnect.Size = new System.Drawing.Size(130, 37);
            this.btn_desconnect.TabIndex = 12;
            this.btn_desconnect.Text = "Desconnectar";
            this.btn_desconnect.UseVisualStyleBackColor = true;
            this.btn_desconnect.Click += new System.EventHandler(this.btn_desconnect_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_sendMessage);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txb_message);
            this.groupBox2.Controls.Add(this.txb_port);
            this.groupBox2.Controls.Add(this.txb_ip);
            this.groupBox2.Location = new System.Drawing.Point(668, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(495, 340);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enviament dades";
            // 
            // btn_sendMessage
            // 
            this.btn_sendMessage.Location = new System.Drawing.Point(302, 246);
            this.btn_sendMessage.Name = "btn_sendMessage";
            this.btn_sendMessage.Size = new System.Drawing.Size(147, 42);
            this.btn_sendMessage.TabIndex = 6;
            this.btn_sendMessage.Text = "Enviar missatge";
            this.btn_sendMessage.UseVisualStyleBackColor = true;
            this.btn_sendMessage.Click += new System.EventHandler(this.btn_sendMessage_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Missatge";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "IP";
            // 
            // txb_message
            // 
            this.txb_message.Location = new System.Drawing.Point(114, 163);
            this.txb_message.Multiline = true;
            this.txb_message.Name = "txb_message";
            this.txb_message.Size = new System.Drawing.Size(334, 55);
            this.txb_message.TabIndex = 2;
            // 
            // txb_port
            // 
            this.txb_port.Location = new System.Drawing.Point(344, 71);
            this.txb_port.Name = "txb_port";
            this.txb_port.Size = new System.Drawing.Size(80, 26);
            this.txb_port.TabIndex = 1;
            // 
            // txb_ip
            // 
            this.txb_ip.Location = new System.Drawing.Point(78, 71);
            this.txb_ip.Name = "txb_ip";
            this.txb_ip.Size = new System.Drawing.Size(150, 26);
            this.txb_ip.TabIndex = 0;
            // 
            // btn_sendFile
            // 
            this.btn_sendFile.Location = new System.Drawing.Point(277, 236);
            this.btn_sendFile.Name = "btn_sendFile";
            this.btn_sendFile.Size = new System.Drawing.Size(147, 42);
            this.btn_sendFile.TabIndex = 7;
            this.btn_sendFile.Text = "Enviar arxiu";
            this.btn_sendFile.UseVisualStyleBackColor = true;
            this.btn_sendFile.Click += new System.EventHandler(this.btn_sendFile_Click);
            // 
            // gbx_comprovacions
            // 
            this.gbx_comprovacions.Controls.Add(this.lb_statusInfo);
            this.gbx_comprovacions.Controls.Add(this.pnl_status);
            this.gbx_comprovacions.Controls.Add(this.label1);
            this.gbx_comprovacions.Controls.Add(this.lbx_console);
            this.gbx_comprovacions.Controls.Add(this.btn_comprovarXarxa);
            this.gbx_comprovacions.Location = new System.Drawing.Point(44, 49);
            this.gbx_comprovacions.Name = "gbx_comprovacions";
            this.gbx_comprovacions.Size = new System.Drawing.Size(579, 346);
            this.gbx_comprovacions.TabIndex = 9;
            this.gbx_comprovacions.TabStop = false;
            this.gbx_comprovacions.Text = "Comprovacions";
            // 
            // lb_statusInfo
            // 
            this.lb_statusInfo.AutoSize = true;
            this.lb_statusInfo.Location = new System.Drawing.Point(30, 309);
            this.lb_statusInfo.Name = "lb_statusInfo";
            this.lb_statusInfo.Size = new System.Drawing.Size(0, 20);
            this.lb_statusInfo.TabIndex = 4;
            // 
            // pnl_status
            // 
            this.pnl_status.BackColor = System.Drawing.Color.Red;
            this.pnl_status.Location = new System.Drawing.Point(64, 137);
            this.pnl_status.Name = "pnl_status";
            this.pnl_status.Size = new System.Drawing.Size(82, 88);
            this.pnl_status.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "status";
            // 
            // lbx_console
            // 
            this.lbx_console.BackColor = System.Drawing.Color.Black;
            this.lbx_console.ForeColor = System.Drawing.SystemColors.Info;
            this.lbx_console.FormattingEnabled = true;
            this.lbx_console.ItemHeight = 20;
            this.lbx_console.Location = new System.Drawing.Point(231, 49);
            this.lbx_console.Name = "lbx_console";
            this.lbx_console.Size = new System.Drawing.Size(300, 244);
            this.lbx_console.TabIndex = 1;
            // 
            // btn_comprovarXarxa
            // 
            this.btn_comprovarXarxa.Location = new System.Drawing.Point(33, 49);
            this.btn_comprovarXarxa.Name = "btn_comprovarXarxa";
            this.btn_comprovarXarxa.Size = new System.Drawing.Size(156, 29);
            this.btn_comprovarXarxa.TabIndex = 0;
            this.btn_comprovarXarxa.Text = " Comprovar xarxa";
            this.btn_comprovarXarxa.UseVisualStyleBackColor = true;
            this.btn_comprovarXarxa.Click += new System.EventHandler(this.btn_comprovarXarxa_Click);
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(50, 247);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(64, 20);
            this.lbl_Status.TabIndex = 13;
            this.lbl_Status.Text = "Estatus";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_browseFile);
            this.groupBox1.Controls.Add(this.lbl_Status);
            this.groupBox1.Controls.Add(this.btn_sendFile);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txb_portA);
            this.groupBox1.Controls.Add(this.txb_ipA);
            this.groupBox1.Location = new System.Drawing.Point(63, 428);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(495, 340);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enviament arxius";
            // 
            // btn_browseFile
            // 
            this.btn_browseFile.Location = new System.Drawing.Point(167, 152);
            this.btn_browseFile.Name = "btn_browseFile";
            this.btn_browseFile.Size = new System.Drawing.Size(257, 42);
            this.btn_browseFile.TabIndex = 8;
            this.btn_browseFile.Text = "Seleccionar arxiu";
            this.btn_browseFile.UseVisualStyleBackColor = true;
            this.btn_browseFile.Click += new System.EventHandler(this.btn_browseFile_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Port";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 163);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Missatge";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "IP";
            // 
            // txb_portA
            // 
            this.txb_portA.Location = new System.Drawing.Point(344, 71);
            this.txb_portA.Name = "txb_portA";
            this.txb_portA.Size = new System.Drawing.Size(80, 26);
            this.txb_portA.TabIndex = 1;
            // 
            // txb_ipA
            // 
            this.txb_ipA.Location = new System.Drawing.Point(78, 71);
            this.txb_ipA.Name = "txb_ipA";
            this.txb_ipA.Size = new System.Drawing.Size(150, 26);
            this.txb_ipA.TabIndex = 0;
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 835);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_config);
            this.Controls.Add(this.btn_desconnect);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbx_comprovacions);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmClient";
            this.Text = "Client TCP-IP";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbx_comprovacions.ResumeLayout(false);
            this.gbx_comprovacions.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_config;
        private System.Windows.Forms.Button btn_desconnect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_sendMessage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_message;
        private System.Windows.Forms.TextBox txb_port;
        private System.Windows.Forms.TextBox txb_ip;
        private System.Windows.Forms.GroupBox gbx_comprovacions;
        private System.Windows.Forms.Label lb_statusInfo;
        private System.Windows.Forms.Panel pnl_status;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbx_console;
        private System.Windows.Forms.Button btn_comprovarXarxa;
        private System.Windows.Forms.Button btn_sendFile;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txb_portA;
        private System.Windows.Forms.TextBox txb_ipA;
        private System.Windows.Forms.Button btn_browseFile;
    }
}

