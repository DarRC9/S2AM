
namespace DataAcces
{
    partial class frmADO
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
            this.components = new System.ComponentModel.Container();
            this.dtgSpecies = new System.Windows.Forms.DataGridView();
            this.codeSpecieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descSpecieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.secureCoreDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SpecieCodeLabel = new System.Windows.Forms.Label();
            this.SpecieDescLabel = new System.Windows.Forms.Label();
            this.SpecieCodeTxt = new System.Windows.Forms.TextBox();
            this.SpecieDescTxt = new System.Windows.Forms.TextBox();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DataSetBtn = new System.Windows.Forms.Button();
            this.XMLTxt = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSpecies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speciesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secureCoreDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgSpecies
            // 
            this.dtgSpecies.AutoGenerateColumns = false;
            this.dtgSpecies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSpecies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeSpecieDataGridViewTextBoxColumn,
            this.descSpecieDataGridViewTextBoxColumn});
            this.dtgSpecies.DataSource = this.speciesBindingSource;
            this.dtgSpecies.Location = new System.Drawing.Point(72, 242);
            this.dtgSpecies.Name = "dtgSpecies";
            this.dtgSpecies.RowHeadersWidth = 51;
            this.dtgSpecies.RowTemplate.Height = 24;
            this.dtgSpecies.Size = new System.Drawing.Size(438, 206);
            this.dtgSpecies.TabIndex = 0;
            // 
            // codeSpecieDataGridViewTextBoxColumn
            // 
            this.codeSpecieDataGridViewTextBoxColumn.DataPropertyName = "CodeSpecie";
            this.codeSpecieDataGridViewTextBoxColumn.HeaderText = "CodeSpecie";
            this.codeSpecieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codeSpecieDataGridViewTextBoxColumn.Name = "codeSpecieDataGridViewTextBoxColumn";
            this.codeSpecieDataGridViewTextBoxColumn.Width = 125;
            // 
            // descSpecieDataGridViewTextBoxColumn
            // 
            this.descSpecieDataGridViewTextBoxColumn.DataPropertyName = "DescSpecie";
            this.descSpecieDataGridViewTextBoxColumn.HeaderText = "DescSpecie";
            this.descSpecieDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descSpecieDataGridViewTextBoxColumn.Name = "descSpecieDataGridViewTextBoxColumn";
            this.descSpecieDataGridViewTextBoxColumn.Width = 125;
            // 
            // speciesBindingSource
            // 
            this.speciesBindingSource.DataMember = "Species";
            this.speciesBindingSource.DataSource = this.secureCoreDataSetBindingSource;
            // 
            // secureCoreDataSetBindingSource
            // 
            this.secureCoreDataSetBindingSource.Position = 0;
            // 
            // secure_CoreDataSet
            // 
            // 
            // speciesTableAdapter
            // 
            // 
            // SpecieCodeLabel
            // 
            this.SpecieCodeLabel.AutoSize = true;
            this.SpecieCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpecieCodeLabel.Location = new System.Drawing.Point(67, 59);
            this.SpecieCodeLabel.Name = "SpecieCodeLabel";
            this.SpecieCodeLabel.Size = new System.Drawing.Size(126, 25);
            this.SpecieCodeLabel.TabIndex = 1;
            this.SpecieCodeLabel.Text = "Specie Code";
            // 
            // SpecieDescLabel
            // 
            this.SpecieDescLabel.AutoSize = true;
            this.SpecieDescLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpecieDescLabel.Location = new System.Drawing.Point(67, 123);
            this.SpecieDescLabel.Name = "SpecieDescLabel";
            this.SpecieDescLabel.Size = new System.Drawing.Size(175, 25);
            this.SpecieDescLabel.TabIndex = 2;
            this.SpecieDescLabel.Text = "Specie Description";
            // 
            // SpecieCodeTxt
            // 
            this.SpecieCodeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpecieCodeTxt.Location = new System.Drawing.Point(323, 59);
            this.SpecieCodeTxt.Name = "SpecieCodeTxt";
            this.SpecieCodeTxt.Size = new System.Drawing.Size(139, 30);
            this.SpecieCodeTxt.TabIndex = 3;
            // 
            // SpecieDescTxt
            // 
            this.SpecieDescTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpecieDescTxt.Location = new System.Drawing.Point(323, 123);
            this.SpecieDescTxt.Name = "SpecieDescTxt";
            this.SpecieDescTxt.Size = new System.Drawing.Size(478, 30);
            this.SpecieDescTxt.TabIndex = 4;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.Location = new System.Drawing.Point(72, 179);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(104, 44);
            this.UpdateBtn.TabIndex = 5;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DataSetBtn
            // 
            this.DataSetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataSetBtn.Location = new System.Drawing.Point(205, 179);
            this.DataSetBtn.Name = "DataSetBtn";
            this.DataSetBtn.Size = new System.Drawing.Size(123, 44);
            this.DataSetBtn.TabIndex = 6;
            this.DataSetBtn.Text = "Data Set";
            this.DataSetBtn.UseVisualStyleBackColor = true;
            this.DataSetBtn.Click += new System.EventHandler(this.DataSetBtn_Click);
            // 
            // XMLTxt
            // 
            this.XMLTxt.Location = new System.Drawing.Point(574, 242);
            this.XMLTxt.Name = "XMLTxt";
            this.XMLTxt.Size = new System.Drawing.Size(337, 206);
            this.XMLTxt.TabIndex = 7;
            this.XMLTxt.Text = "";
            // 
            // frmADO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 494);
            this.Controls.Add(this.XMLTxt);
            this.Controls.Add(this.DataSetBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.SpecieDescTxt);
            this.Controls.Add(this.SpecieCodeTxt);
            this.Controls.Add(this.SpecieDescLabel);
            this.Controls.Add(this.SpecieCodeLabel);
            this.Controls.Add(this.dtgSpecies);
            this.Name = "frmADO";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgSpecies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speciesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secureCoreDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgSpecies;
        private System.Windows.Forms.BindingSource secureCoreDataSetBindingSource;
        private System.Windows.Forms.BindingSource speciesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeSpecieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descSpecieDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label SpecieCodeLabel;
        private System.Windows.Forms.Label SpecieDescLabel;
        private System.Windows.Forms.TextBox SpecieCodeTxt;
        private System.Windows.Forms.TextBox SpecieDescTxt;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DataSetBtn;
        private System.Windows.Forms.RichTextBox XMLTxt;
    }
}

