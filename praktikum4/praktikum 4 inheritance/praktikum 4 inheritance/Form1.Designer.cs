namespace praktikum_4_inheritance
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtlabel1 = new System.Windows.Forms.TextBox();
            this.txtnama = new System.Windows.Forms.TextBox();
            this.txtlabel3 = new System.Windows.Forms.TextBox();
            this.txtgender = new System.Windows.Forms.TextBox();
            this.txttinggibadan = new System.Windows.Forms.TextBox();
            this.btnmanusia = new System.Windows.Forms.Button();
            this.btnpegawai = new System.Windows.Forms.Button();
            this.btnmahasiswa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tinggi Badan";
            // 
            // txtlabel1
            // 
            this.txtlabel1.Location = new System.Drawing.Point(154, 21);
            this.txtlabel1.Name = "txtlabel1";
            this.txtlabel1.Size = new System.Drawing.Size(125, 20);
            this.txtlabel1.TabIndex = 5;
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(154, 58);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(125, 20);
            this.txtnama.TabIndex = 6;
            // 
            // txtlabel3
            // 
            this.txtlabel3.Location = new System.Drawing.Point(154, 92);
            this.txtlabel3.Name = "txtlabel3";
            this.txtlabel3.Size = new System.Drawing.Size(125, 20);
            this.txtlabel3.TabIndex = 7;
            // 
            // txtgender
            // 
            this.txtgender.Location = new System.Drawing.Point(154, 130);
            this.txtgender.Name = "txtgender";
            this.txtgender.Size = new System.Drawing.Size(125, 20);
            this.txtgender.TabIndex = 8;
            // 
            // txttinggibadan
            // 
            this.txttinggibadan.Location = new System.Drawing.Point(154, 168);
            this.txttinggibadan.Name = "txttinggibadan";
            this.txttinggibadan.Size = new System.Drawing.Size(125, 20);
            this.txttinggibadan.TabIndex = 9;
            // 
            // btnmanusia
            // 
            this.btnmanusia.Location = new System.Drawing.Point(326, 37);
            this.btnmanusia.Name = "btnmanusia";
            this.btnmanusia.Size = new System.Drawing.Size(106, 41);
            this.btnmanusia.TabIndex = 10;
            this.btnmanusia.Text = "Manusia";
            this.btnmanusia.UseVisualStyleBackColor = true;
            this.btnmanusia.Click += new System.EventHandler(this.btnmanusia_Click);
            // 
            // btnpegawai
            // 
            this.btnpegawai.Location = new System.Drawing.Point(326, 89);
            this.btnpegawai.Name = "btnpegawai";
            this.btnpegawai.Size = new System.Drawing.Size(106, 38);
            this.btnpegawai.TabIndex = 11;
            this.btnpegawai.Text = "Pegawai";
            this.btnpegawai.UseVisualStyleBackColor = true;
            this.btnpegawai.Click += new System.EventHandler(this.btnpegawai_Click);
            // 
            // btnmahasiswa
            // 
            this.btnmahasiswa.Location = new System.Drawing.Point(326, 137);
            this.btnmahasiswa.Name = "btnmahasiswa";
            this.btnmahasiswa.Size = new System.Drawing.Size(106, 40);
            this.btnmahasiswa.TabIndex = 12;
            this.btnmahasiswa.Text = "Mahasiswa";
            this.btnmahasiswa.UseVisualStyleBackColor = true;
            this.btnmahasiswa.Click += new System.EventHandler(this.btnmahasiswa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 228);
            this.Controls.Add(this.btnmahasiswa);
            this.Controls.Add(this.btnpegawai);
            this.Controls.Add(this.btnmanusia);
            this.Controls.Add(this.txttinggibadan);
            this.Controls.Add(this.txtgender);
            this.Controls.Add(this.txtlabel3);
            this.Controls.Add(this.txtnama);
            this.Controls.Add(this.txtlabel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Inheritance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtlabel1;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.TextBox txtlabel3;
        private System.Windows.Forms.TextBox txtgender;
        private System.Windows.Forms.TextBox txttinggibadan;
        private System.Windows.Forms.Button btnmanusia;
        private System.Windows.Forms.Button btnpegawai;
        private System.Windows.Forms.Button btnmahasiswa;
    }
}

