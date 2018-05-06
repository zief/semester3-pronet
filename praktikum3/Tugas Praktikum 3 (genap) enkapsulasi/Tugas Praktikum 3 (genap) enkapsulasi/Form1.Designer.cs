namespace Tugas_Praktikum_3__genap__enkapsulasi
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbnama = new System.Windows.Forms.TextBox();
            this.tbnim = new System.Windows.Forms.TextBox();
            this.tbnilai = new System.Windows.Forms.TextBox();
            this.btntampil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NIM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nilai";
            // 
            // tbnama
            // 
            this.tbnama.Location = new System.Drawing.Point(83, 25);
            this.tbnama.Name = "tbnama";
            this.tbnama.Size = new System.Drawing.Size(217, 20);
            this.tbnama.TabIndex = 3;
            // 
            // tbnim
            // 
            this.tbnim.Location = new System.Drawing.Point(83, 64);
            this.tbnim.Name = "tbnim";
            this.tbnim.Size = new System.Drawing.Size(217, 20);
            this.tbnim.TabIndex = 4;
            // 
            // tbnilai
            // 
            this.tbnilai.Location = new System.Drawing.Point(83, 102);
            this.tbnilai.Name = "tbnilai";
            this.tbnilai.Size = new System.Drawing.Size(217, 20);
            this.tbnilai.TabIndex = 5;
            // 
            // btntampil
            // 
            this.btntampil.Location = new System.Drawing.Point(29, 147);
            this.btntampil.Name = "btntampil";
            this.btntampil.Size = new System.Drawing.Size(271, 23);
            this.btntampil.TabIndex = 6;
            this.btntampil.Text = "Tampilkan";
            this.btntampil.UseVisualStyleBackColor = true;
            this.btntampil.Click += new System.EventHandler(this.btntampil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 195);
            this.Controls.Add(this.btntampil);
            this.Controls.Add(this.tbnilai);
            this.Controls.Add(this.tbnim);
            this.Controls.Add(this.tbnama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Encapsulasi 14.11.0194";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbnama;
        private System.Windows.Forms.TextBox tbnim;
        private System.Windows.Forms.TextBox tbnilai;
        private System.Windows.Forms.Button btntampil;
    }
}

