namespace praktikum3
{
    partial class Clas_method
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnim = new System.Windows.Forms.TextBox();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.txtinggris = new System.Windows.Forms.TextBox();
            this.txtmanajemen = new System.Windows.Forms.TextBox();
            this.txtindo = new System.Windows.Forms.TextBox();
            this.btnhitung = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nilai Inggris";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nilai Manajemen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nilai bahasa indo";
            // 
            // txtnim
            // 
            this.txtnim.Location = new System.Drawing.Point(129, 28);
            this.txtnim.Name = "txtnim";
            this.txtnim.Size = new System.Drawing.Size(100, 20);
            this.txtnim.TabIndex = 5;
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(129, 64);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(100, 20);
            this.txtnama.TabIndex = 6;
            // 
            // txtinggris
            // 
            this.txtinggris.Location = new System.Drawing.Point(129, 103);
            this.txtinggris.Name = "txtinggris";
            this.txtinggris.Size = new System.Drawing.Size(100, 20);
            this.txtinggris.TabIndex = 7;
            // 
            // txtmanajemen
            // 
            this.txtmanajemen.Location = new System.Drawing.Point(129, 139);
            this.txtmanajemen.Name = "txtmanajemen";
            this.txtmanajemen.Size = new System.Drawing.Size(100, 20);
            this.txtmanajemen.TabIndex = 8;
            // 
            // txtindo
            // 
            this.txtindo.Location = new System.Drawing.Point(129, 173);
            this.txtindo.Name = "txtindo";
            this.txtindo.Size = new System.Drawing.Size(100, 20);
            this.txtindo.TabIndex = 9;
            // 
            // btnhitung
            // 
            this.btnhitung.Location = new System.Drawing.Point(96, 218);
            this.btnhitung.Name = "btnhitung";
            this.btnhitung.Size = new System.Drawing.Size(75, 23);
            this.btnhitung.TabIndex = 10;
            this.btnhitung.Text = "Hitung";
            this.btnhitung.UseVisualStyleBackColor = true;
            this.btnhitung.Click += new System.EventHandler(this.btnhitung_Click);
            // 
            // Clas_method
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 286);
            this.Controls.Add(this.btnhitung);
            this.Controls.Add(this.txtindo);
            this.Controls.Add(this.txtmanajemen);
            this.Controls.Add(this.txtinggris);
            this.Controls.Add(this.txtnama);
            this.Controls.Add(this.txtnim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Clas_method";
            this.Text = "Clas_method";
            this.Load += new System.EventHandler(this.Clas_method_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnim;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.TextBox txtinggris;
        private System.Windows.Forms.TextBox txtmanajemen;
        private System.Windows.Forms.TextBox txtindo;
        private System.Windows.Forms.Button btnhitung;
    }
}