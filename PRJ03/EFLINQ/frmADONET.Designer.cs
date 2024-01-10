
namespace EFLINQ
{
    partial class frmADONET
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.TableDgv = new System.Windows.Forms.DataGridView();
            this.NewBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.OpenEDIBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TableDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 77);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 2;
            // 
            // TableDgv
            // 
            this.TableDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableDgv.Location = new System.Drawing.Point(12, 126);
            this.TableDgv.Name = "TableDgv";
            this.TableDgv.RowHeadersWidth = 51;
            this.TableDgv.RowTemplate.Height = 24;
            this.TableDgv.Size = new System.Drawing.Size(776, 254);
            this.TableDgv.TabIndex = 3;
            // 
            // NewBtn
            // 
            this.NewBtn.Location = new System.Drawing.Point(12, 398);
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(75, 40);
            this.NewBtn.TabIndex = 4;
            this.NewBtn.Text = "New";
            this.NewBtn.UseVisualStyleBackColor = true;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(108, 398);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 40);
            this.UpdateBtn.TabIndex = 5;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "OpenEdiOfd";
            // 
            // OpenEDIBtn
            // 
            this.OpenEDIBtn.Location = new System.Drawing.Point(561, 40);
            this.OpenEDIBtn.Name = "OpenEDIBtn";
            this.OpenEDIBtn.Size = new System.Drawing.Size(93, 30);
            this.OpenEDIBtn.TabIndex = 6;
            this.OpenEDIBtn.Text = "Open .EDI";
            this.OpenEDIBtn.UseVisualStyleBackColor = true;
            this.OpenEDIBtn.Click += new System.EventHandler(this.OpenEDIBtn_Click);
            // 
            // frmADONET
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OpenEDIBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.NewBtn);
            this.Controls.Add(this.TableDgv);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "frmADONET";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmADONET_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridView TableDgv;
        private System.Windows.Forms.Button NewBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button OpenEDIBtn;
    }
}

