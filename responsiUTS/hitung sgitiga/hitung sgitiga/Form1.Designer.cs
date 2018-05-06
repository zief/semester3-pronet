namespace hitung_sgitiga
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
            this.txtalas = new System.Windows.Forms.TextBox();
            this.txttinggi = new System.Windows.Forms.TextBox();
            this.hitung = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txthasil = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "tinggi";
            // 
            // txtalas
            // 
            this.txtalas.Location = new System.Drawing.Point(107, 33);
            this.txtalas.Name = "txtalas";
            this.txtalas.Size = new System.Drawing.Size(100, 20);
            this.txtalas.TabIndex = 2;
            // 
            // txttinggi
            // 
            this.txttinggi.Location = new System.Drawing.Point(107, 69);
            this.txttinggi.Name = "txttinggi";
            this.txttinggi.Size = new System.Drawing.Size(100, 20);
            this.txttinggi.TabIndex = 3;
            // 
            // hitung
            // 
            this.hitung.Location = new System.Drawing.Point(76, 121);
            this.hitung.Name = "hitung";
            this.hitung.Size = new System.Drawing.Size(75, 23);
            this.hitung.TabIndex = 4;
            this.hitung.Text = "Hitung";
            this.hitung.UseVisualStyleBackColor = true;
            this.hitung.Click += new System.EventHandler(this.hitung_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "hasil";
            // 
            // txthasil
            // 
            this.txthasil.Location = new System.Drawing.Point(107, 166);
            this.txthasil.Name = "txthasil";
            this.txthasil.Size = new System.Drawing.Size(100, 20);
            this.txthasil.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ni\'am H Sahid 14.11.0185";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txthasil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hitung);
            this.Controls.Add(this.txttinggi);
            this.Controls.Add(this.txtalas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtalas;
        private System.Windows.Forms.TextBox txttinggi;
        private System.Windows.Forms.Button hitung;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txthasil;
        private System.Windows.Forms.Label label4;
    }
}

