
namespace FileGenerator
{
    partial class FileGenerator
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
            this.lbl_FilesNumber = new System.Windows.Forms.Label();
            this.lbl_LetterNumber = new System.Windows.Forms.Label();
            this.txb_FilesNumber = new System.Windows.Forms.TextBox();
            this.txb_LettersNumber = new System.Windows.Forms.TextBox();
            this.btn_GenerateCodification = new System.Windows.Forms.Button();
            this.btn_GenerateFiles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_FilesNumber
            // 
            this.lbl_FilesNumber.AutoSize = true;
            this.lbl_FilesNumber.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FilesNumber.Location = new System.Drawing.Point(96, 106);
            this.lbl_FilesNumber.Name = "lbl_FilesNumber";
            this.lbl_FilesNumber.Size = new System.Drawing.Size(240, 45);
            this.lbl_FilesNumber.TabIndex = 0;
            this.lbl_FilesNumber.Text = "Number of files";
            // 
            // lbl_LetterNumber
            // 
            this.lbl_LetterNumber.AutoSize = true;
            this.lbl_LetterNumber.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LetterNumber.Location = new System.Drawing.Point(63, 178);
            this.lbl_LetterNumber.Name = "lbl_LetterNumber";
            this.lbl_LetterNumber.Size = new System.Drawing.Size(273, 45);
            this.lbl_LetterNumber.TabIndex = 1;
            this.lbl_LetterNumber.Text = "Number of letters";
            // 
            // txb_FilesNumber
            // 
            this.txb_FilesNumber.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_FilesNumber.Location = new System.Drawing.Point(415, 106);
            this.txb_FilesNumber.Name = "txb_FilesNumber";
            this.txb_FilesNumber.Size = new System.Drawing.Size(235, 50);
            this.txb_FilesNumber.TabIndex = 2;
            // 
            // txb_LettersNumber
            // 
            this.txb_LettersNumber.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_LettersNumber.Location = new System.Drawing.Point(415, 178);
            this.txb_LettersNumber.Name = "txb_LettersNumber";
            this.txb_LettersNumber.Size = new System.Drawing.Size(235, 50);
            this.txb_LettersNumber.TabIndex = 3;
            // 
            // btn_GenerateCodification
            // 
            this.btn_GenerateCodification.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GenerateCodification.Location = new System.Drawing.Point(117, 276);
            this.btn_GenerateCodification.Name = "btn_GenerateCodification";
            this.btn_GenerateCodification.Size = new System.Drawing.Size(219, 131);
            this.btn_GenerateCodification.TabIndex = 4;
            this.btn_GenerateCodification.Text = "Generate \r\nCodification";
            this.btn_GenerateCodification.UseVisualStyleBackColor = true;
            this.btn_GenerateCodification.Click += new System.EventHandler(this.btn_GenerateCodification_Click);
            // 
            // btn_GenerateFiles
            // 
            this.btn_GenerateFiles.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GenerateFiles.Location = new System.Drawing.Point(415, 276);
            this.btn_GenerateFiles.Name = "btn_GenerateFiles";
            this.btn_GenerateFiles.Size = new System.Drawing.Size(219, 131);
            this.btn_GenerateFiles.TabIndex = 5;
            this.btn_GenerateFiles.Text = "Generate \r\nFiles";
            this.btn_GenerateFiles.UseVisualStyleBackColor = true;
            this.btn_GenerateFiles.Click += new System.EventHandler(this.btn_GenerateFiles_Click);
            // 
            // FileGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_GenerateFiles);
            this.Controls.Add(this.btn_GenerateCodification);
            this.Controls.Add(this.txb_LettersNumber);
            this.Controls.Add(this.txb_FilesNumber);
            this.Controls.Add(this.lbl_LetterNumber);
            this.Controls.Add(this.lbl_FilesNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FileGenerator";
            this.Text = "FileGenerator";
            this.Load += new System.EventHandler(this.FileGenerator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_FilesNumber;
        private System.Windows.Forms.Label lbl_LetterNumber;
        private System.Windows.Forms.TextBox txb_FilesNumber;
        private System.Windows.Forms.TextBox txb_LettersNumber;
        private System.Windows.Forms.Button btn_GenerateCodification;
        private System.Windows.Forms.Button btn_GenerateFiles;
    }
}

