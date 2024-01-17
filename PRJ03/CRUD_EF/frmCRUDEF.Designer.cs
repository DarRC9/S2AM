
namespace CRUD_EF
{
    partial class frmCRUDEF
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
            this.TableDgv = new System.Windows.Forms.DataGridView();
            this.CodeRankLbl = new System.Windows.Forms.Label();
            this.DescRankTxt = new System.Windows.Forms.TextBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.CodeDescLbl = new System.Windows.Forms.Label();
            this.CodeRankTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TableDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // TableDgv
            // 
            this.TableDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableDgv.Location = new System.Drawing.Point(12, 133);
            this.TableDgv.Name = "TableDgv";
            this.TableDgv.RowHeadersWidth = 51;
            this.TableDgv.RowTemplate.Height = 24;
            this.TableDgv.Size = new System.Drawing.Size(605, 261);
            this.TableDgv.TabIndex = 0;
            // 
            // CodeRankLbl
            // 
            this.CodeRankLbl.AutoSize = true;
            this.CodeRankLbl.Location = new System.Drawing.Point(12, 41);
            this.CodeRankLbl.Name = "CodeRankLbl";
            this.CodeRankLbl.Size = new System.Drawing.Size(78, 17);
            this.CodeRankLbl.TabIndex = 1;
            this.CodeRankLbl.Text = "Rank Code";
            // 
            // DescRankTxt
            // 
            this.DescRankTxt.Location = new System.Drawing.Point(162, 82);
            this.DescRankTxt.Name = "DescRankTxt";
            this.DescRankTxt.Size = new System.Drawing.Size(136, 22);
            this.DescRankTxt.TabIndex = 2;
            this.DescRankTxt.Tag = "DescRank";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(461, 400);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 38);
            this.AddBtn.TabIndex = 3;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(542, 400);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 38);
            this.UpdateBtn.TabIndex = 4;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // CodeDescLbl
            // 
            this.CodeDescLbl.AutoSize = true;
            this.CodeDescLbl.Location = new System.Drawing.Point(12, 82);
            this.CodeDescLbl.Name = "CodeDescLbl";
            this.CodeDescLbl.Size = new System.Drawing.Size(116, 17);
            this.CodeDescLbl.TabIndex = 5;
            this.CodeDescLbl.Text = "Rank Description";
            // 
            // CodeRankTxt
            // 
            this.CodeRankTxt.Location = new System.Drawing.Point(96, 38);
            this.CodeRankTxt.Name = "CodeRankTxt";
            this.CodeRankTxt.Size = new System.Drawing.Size(136, 22);
            this.CodeRankTxt.TabIndex = 6;
            this.CodeRankTxt.Tag = "CodeRank";
            // 
            // frmCRUDEF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 450);
            this.Controls.Add(this.CodeRankTxt);
            this.Controls.Add(this.CodeDescLbl);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.DescRankTxt);
            this.Controls.Add(this.CodeRankLbl);
            this.Controls.Add(this.TableDgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCRUDEF";
            this.Text = "CRUD";
            this.Load += new System.EventHandler(this.frmCRUDEF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TableDgv;
        private System.Windows.Forms.Label CodeRankLbl;
        private System.Windows.Forms.TextBox DescRankTxt;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Label CodeDescLbl;
        private System.Windows.Forms.TextBox CodeRankTxt;
    }
}

