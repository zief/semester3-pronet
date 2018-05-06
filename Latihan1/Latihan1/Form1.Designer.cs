namespace Latihan1
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
            this.txtnama = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbya = new System.Windows.Forms.RadioButton();
            this.rbtidak = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cbsopayam = new System.Windows.Forms.CheckBox();
            this.cbayamrica2 = new System.Windows.Forms.CheckBox();
            this.cbestehmanis = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsopayam = new System.Windows.Forms.TextBox();
            this.txtayamrica2 = new System.Windows.Forms.TextBox();
            this.txtestehmanis = new System.Windows.Forms.TextBox();
            this.btnhitung = new System.Windows.Forms.Button();
            this.labeltotal = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NAMA";
            // 
            // txtnama
            // 
            this.txtnama.Location = new System.Drawing.Point(128, 21);
            this.txtnama.Name = "txtnama";
            this.txtnama.Size = new System.Drawing.Size(291, 20);
            this.txtnama.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "PELANGGAN";
            // 
            // rbya
            // 
            this.rbya.AutoSize = true;
            this.rbya.Location = new System.Drawing.Point(139, 70);
            this.rbya.Name = "rbya";
            this.rbya.Size = new System.Drawing.Size(39, 17);
            this.rbya.TabIndex = 3;
            this.rbya.TabStop = true;
            this.rbya.Text = "YA";
            this.rbya.UseVisualStyleBackColor = true;
            this.rbya.CheckedChanged += new System.EventHandler(this.rbya_CheckedChanged);
            // 
            // rbtidak
            // 
            this.rbtidak.AutoSize = true;
            this.rbtidak.Location = new System.Drawing.Point(254, 70);
            this.rbtidak.Name = "rbtidak";
            this.rbtidak.Size = new System.Drawing.Size(57, 17);
            this.rbtidak.TabIndex = 4;
            this.rbtidak.TabStop = true;
            this.rbtidak.Text = "TIDAK";
            this.rbtidak.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "MENU PILIHAN :";
            // 
            // cbsopayam
            // 
            this.cbsopayam.AutoSize = true;
            this.cbsopayam.Location = new System.Drawing.Point(51, 158);
            this.cbsopayam.Name = "cbsopayam";
            this.cbsopayam.Size = new System.Drawing.Size(137, 17);
            this.cbsopayam.TabIndex = 6;
            this.cbsopayam.Text = "SOP AYAM [ Rp 9.000]";
            this.cbsopayam.UseVisualStyleBackColor = true;
            this.cbsopayam.CheckedChanged += new System.EventHandler(this.cbsopayam_CheckedChanged);
            // 
            // cbayamrica2
            // 
            this.cbayamrica2.AutoSize = true;
            this.cbayamrica2.Location = new System.Drawing.Point(51, 190);
            this.cbayamrica2.Name = "cbayamrica2";
            this.cbayamrica2.Size = new System.Drawing.Size(168, 17);
            this.cbayamrica2.TabIndex = 7;
            this.cbayamrica2.Text = "AYAM RICA RICA [ Rp 8.500]";
            this.cbayamrica2.UseVisualStyleBackColor = true;
            this.cbayamrica2.CheckedChanged += new System.EventHandler(this.cbayamrica2_CheckedChanged);
            // 
            // cbestehmanis
            // 
            this.cbestehmanis.AutoSize = true;
            this.cbestehmanis.Location = new System.Drawing.Point(51, 223);
            this.cbestehmanis.Name = "cbestehmanis";
            this.cbestehmanis.Size = new System.Drawing.Size(155, 17);
            this.cbestehmanis.TabIndex = 8;
            this.cbestehmanis.Text = "ES TEH MANIS [Rp 2.000]";
            this.cbestehmanis.UseVisualStyleBackColor = true;
            this.cbestehmanis.CheckedChanged += new System.EventHandler(this.cbestehmanis_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "JUMLAH";
            // 
            // txtsopayam
            // 
            this.txtsopayam.Location = new System.Drawing.Point(319, 155);
            this.txtsopayam.Name = "txtsopayam";
            this.txtsopayam.Size = new System.Drawing.Size(100, 20);
            this.txtsopayam.TabIndex = 10;
            // 
            // txtayamrica2
            // 
            this.txtayamrica2.Location = new System.Drawing.Point(319, 187);
            this.txtayamrica2.Name = "txtayamrica2";
            this.txtayamrica2.Size = new System.Drawing.Size(100, 20);
            this.txtayamrica2.TabIndex = 11;
            // 
            // txtestehmanis
            // 
            this.txtestehmanis.Location = new System.Drawing.Point(319, 220);
            this.txtestehmanis.Name = "txtestehmanis";
            this.txtestehmanis.Size = new System.Drawing.Size(100, 20);
            this.txtestehmanis.TabIndex = 12;
            this.txtestehmanis.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnhitung
            // 
            this.btnhitung.Location = new System.Drawing.Point(33, 264);
            this.btnhitung.Name = "btnhitung";
            this.btnhitung.Size = new System.Drawing.Size(386, 33);
            this.btnhitung.TabIndex = 13;
            this.btnhitung.Text = "HITUNG";
            this.btnhitung.UseVisualStyleBackColor = true;
            this.btnhitung.Click += new System.EventHandler(this.btnhitung_Click);
            // 
            // labeltotal
            // 
            this.labeltotal.AutoSize = true;
            this.labeltotal.Location = new System.Drawing.Point(218, 321);
            this.labeltotal.Name = "labeltotal";
            this.labeltotal.Size = new System.Drawing.Size(59, 13);
            this.labeltotal.TabIndex = 14;
            this.labeltotal.Text = "TOTAL Rp";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(299, 314);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(120, 20);
            this.txttotal.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 371);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.labeltotal);
            this.Controls.Add(this.btnhitung);
            this.Controls.Add(this.txtestehmanis);
            this.Controls.Add(this.txtayamrica2);
            this.Controls.Add(this.txtsopayam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbestehmanis);
            this.Controls.Add(this.cbayamrica2);
            this.Controls.Add(this.cbsopayam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbtidak);
            this.Controls.Add(this.rbya);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnama);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "RUMAH MAKAN \"SUKA SUKA LO\"";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnama;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbya;
        private System.Windows.Forms.RadioButton rbtidak;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbsopayam;
        private System.Windows.Forms.CheckBox cbayamrica2;
        private System.Windows.Forms.CheckBox cbestehmanis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsopayam;
        private System.Windows.Forms.TextBox txtayamrica2;
        private System.Windows.Forms.TextBox txtestehmanis;
        private System.Windows.Forms.Button btnhitung;
        private System.Windows.Forms.Label labeltotal;
        private System.Windows.Forms.TextBox txttotal;
    }
}

