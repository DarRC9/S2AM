
namespace SpeciesManagement
{
    partial class SpeciesForm
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
            this.CodeSpecieTxt = new System.Windows.Forms.Label();
            this.DescSpecieTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(174, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 27);
            this.textBox1.TabIndex = 4;
            this.textBox1.Tag = "CodeSpecie";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(209, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(279, 27);
            this.textBox2.TabIndex = 5;
            this.textBox2.Tag = "DescSpecie";
            // 
            // CodeSpecieTxt
            // 
            this.CodeSpecieTxt.AutoSize = true;
            this.CodeSpecieTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeSpecieTxt.Location = new System.Drawing.Point(8, 15);
            this.CodeSpecieTxt.Name = "CodeSpecieTxt";
            this.CodeSpecieTxt.Size = new System.Drawing.Size(130, 25);
            this.CodeSpecieTxt.TabIndex = 6;
            this.CodeSpecieTxt.Text = "Specie Code";
            // 
            // DescSpecieTxt
            // 
            this.DescSpecieTxt.AutoSize = true;
            this.DescSpecieTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescSpecieTxt.Location = new System.Drawing.Point(8, 48);
            this.DescSpecieTxt.Name = "DescSpecieTxt";
            this.DescSpecieTxt.Size = new System.Drawing.Size(189, 25);
            this.DescSpecieTxt.TabIndex = 7;
            this.DescSpecieTxt.Text = "Specie Description";
            // 
            // SpeciesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DescSpecieTxt);
            this.Controls.Add(this.CodeSpecieTxt);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "SpeciesForm";
            this.Text = "Species Management";
            this.Controls.SetChildIndex(this.textBox1, 0);
            this.Controls.SetChildIndex(this.textBox2, 0);
            this.Controls.SetChildIndex(this.CodeSpecieTxt, 0);
            this.Controls.SetChildIndex(this.DescSpecieTxt, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label CodeSpecieTxt;
        private System.Windows.Forms.Label DescSpecieTxt;
    }
}

