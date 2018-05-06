namespace ngitung_suhu
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
            this.txtawal = new System.Windows.Forms.TextBox();
            this.cmbpil1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txthasil = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbpilhasil = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtawal
            // 
            this.txtawal.Location = new System.Drawing.Point(75, 27);
            this.txtawal.Name = "txtawal";
            this.txtawal.Size = new System.Drawing.Size(100, 20);
            this.txtawal.TabIndex = 0;
            // 
            // cmbpil1
            // 
            this.cmbpil1.FormattingEnabled = true;
            this.cmbpil1.Items.AddRange(new object[] {
            "Celcius",
            "Reamur",
            "Fahrenheit"});
            this.cmbpil1.Location = new System.Drawing.Point(239, 26);
            this.cmbpil1.Name = "cmbpil1";
            this.cmbpil1.Size = new System.Drawing.Size(121, 21);
            this.cmbpil1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Konversi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Suhu :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ke : ";
            // 
            // txthasil
            // 
            this.txthasil.Location = new System.Drawing.Point(75, 189);
            this.txthasil.Name = "txthasil";
            this.txthasil.Size = new System.Drawing.Size(100, 20);
            this.txthasil.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Hasil";
            // 
            // cmbpilhasil
            // 
            this.cmbpilhasil.FormattingEnabled = true;
            this.cmbpilhasil.Items.AddRange(new object[] {
            "Celcius",
            "Reamur",
            "Fahrenheit"});
            this.cmbpilhasil.Location = new System.Drawing.Point(75, 109);
            this.cmbpilhasil.Name = "cmbpilhasil";
            this.cmbpilhasil.Size = new System.Drawing.Size(121, 21);
            this.cmbpilhasil.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 263);
            this.Controls.Add(this.cmbpilhasil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txthasil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbpil1);
            this.Controls.Add(this.txtawal);
            this.Name = "Form1";
            this.Text = "Ni\'am H S Suhu 14.11.0185";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtawal;
        private System.Windows.Forms.ComboBox cmbpil1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txthasil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbpilhasil;
    }
}

