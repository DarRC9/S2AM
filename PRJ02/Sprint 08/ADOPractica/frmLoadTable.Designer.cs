﻿
namespace ADOPractica
{
    partial class frmLoadTable
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
            this.CodeLabel = new System.Windows.Forms.Label();
            this.DescLabel = new System.Windows.Forms.Label();
            this.CodeTxt = new System.Windows.Forms.TextBox();
            this.DescTxt = new System.Windows.Forms.TextBox();
            this.XMLTxt = new System.Windows.Forms.RichTextBox();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DataSetBtn = new System.Windows.Forms.Button();
            this.NewBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // CodeLabel
            // 
            this.CodeLabel.AutoSize = true;
            this.CodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeLabel.Location = new System.Drawing.Point(12, 26);
            this.CodeLabel.Name = "CodeLabel";
            this.CodeLabel.Size = new System.Drawing.Size(126, 25);
            this.CodeLabel.TabIndex = 0;
            this.CodeLabel.Text = "Specie Code";
            // 
            // DescLabel
            // 
            this.DescLabel.AutoSize = true;
            this.DescLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescLabel.Location = new System.Drawing.Point(12, 82);
            this.DescLabel.Name = "DescLabel";
            this.DescLabel.Size = new System.Drawing.Size(175, 25);
            this.DescLabel.TabIndex = 1;
            this.DescLabel.Text = "Specie Description";
            // 
            // CodeTxt
            // 
            this.CodeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeTxt.Location = new System.Drawing.Point(159, 26);
            this.CodeTxt.Name = "CodeTxt";
            this.CodeTxt.Size = new System.Drawing.Size(260, 30);
            this.CodeTxt.TabIndex = 2;
            // 
            // DescTxt
            // 
            this.DescTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescTxt.Location = new System.Drawing.Point(211, 79);
            this.DescTxt.Name = "DescTxt";
            this.DescTxt.Size = new System.Drawing.Size(577, 30);
            this.DescTxt.TabIndex = 3;
            // 
            // XMLTxt
            // 
            this.XMLTxt.Location = new System.Drawing.Point(420, 173);
            this.XMLTxt.Name = "XMLTxt";
            this.XMLTxt.Size = new System.Drawing.Size(368, 265);
            this.XMLTxt.TabIndex = 4;
            this.XMLTxt.Text = "";
            // 
            // dgvTable
            // 
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Location = new System.Drawing.Point(12, 173);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.ReadOnly = true;
            this.dgvTable.RowHeadersWidth = 51;
            this.dgvTable.RowTemplate.Height = 24;
            this.dgvTable.Size = new System.Drawing.Size(393, 265);
            this.dgvTable.TabIndex = 5;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.Location = new System.Drawing.Point(17, 119);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(105, 39);
            this.UpdateBtn.TabIndex = 6;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            // 
            // DataSetBtn
            // 
            this.DataSetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataSetBtn.Location = new System.Drawing.Point(420, 121);
            this.DataSetBtn.Name = "DataSetBtn";
            this.DataSetBtn.Size = new System.Drawing.Size(137, 37);
            this.DataSetBtn.TabIndex = 7;
            this.DataSetBtn.Text = "Data Set";
            this.DataSetBtn.UseVisualStyleBackColor = true;
            // 
            // NewBtn
            // 
            this.NewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewBtn.Location = new System.Drawing.Point(150, 121);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(94, 37);
            this.NewBtn.TabIndex = 8;
            this.NewBtn.Text = "New";
            this.NewBtn.UseVisualStyleBackColor = true;
            // 
            // frmLoadTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NewBtn);
            this.Controls.Add(this.DataSetBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.dgvTable);
            this.Controls.Add(this.XMLTxt);
            this.Controls.Add(this.DescTxt);
            this.Controls.Add(this.CodeTxt);
            this.Controls.Add(this.DescLabel);
            this.Controls.Add(this.CodeLabel);
            this.Name = "frmLoadTable";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CodeLabel;
        private System.Windows.Forms.Label DescLabel;
        private System.Windows.Forms.TextBox CodeTxt;
        private System.Windows.Forms.TextBox DescTxt;
        private System.Windows.Forms.RichTextBox XMLTxt;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DataSetBtn;
        private System.Windows.Forms.Button NewBtn;
    }
}

