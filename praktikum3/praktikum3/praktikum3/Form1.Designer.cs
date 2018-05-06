namespace praktikum3
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
            this.txtplat = new System.Windows.Forms.TextBox();
            this.txtmodel = new System.Windows.Forms.TextBox();
            this.txtmanufaktur = new System.Windows.Forms.TextBox();
            this.txtspeed = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttahun = new System.Windows.Forms.TextBox();
            this.btntampil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plat Nomor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Manufaktur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "SpeedMax";
            // 
            // txtplat
            // 
            this.txtplat.Location = new System.Drawing.Point(116, 24);
            this.txtplat.Name = "txtplat";
            this.txtplat.Size = new System.Drawing.Size(114, 20);
            this.txtplat.TabIndex = 4;
            // 
            // txtmodel
            // 
            this.txtmodel.Location = new System.Drawing.Point(116, 60);
            this.txtmodel.Name = "txtmodel";
            this.txtmodel.Size = new System.Drawing.Size(114, 20);
            this.txtmodel.TabIndex = 5;
            // 
            // txtmanufaktur
            // 
            this.txtmanufaktur.Location = new System.Drawing.Point(116, 101);
            this.txtmanufaktur.Name = "txtmanufaktur";
            this.txtmanufaktur.Size = new System.Drawing.Size(114, 20);
            this.txtmanufaktur.TabIndex = 6;
            // 
            // txtspeed
            // 
            this.txtspeed.Location = new System.Drawing.Point(116, 141);
            this.txtspeed.Name = "txtspeed";
            this.txtspeed.Size = new System.Drawing.Size(114, 20);
            this.txtspeed.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tahun Produksi";
            // 
            // txttahun
            // 
            this.txttahun.Location = new System.Drawing.Point(116, 183);
            this.txttahun.Name = "txttahun";
            this.txttahun.Size = new System.Drawing.Size(114, 20);
            this.txttahun.TabIndex = 9;
            // 
            // btntampil
            // 
            this.btntampil.Location = new System.Drawing.Point(93, 237);
            this.btntampil.Name = "btntampil";
            this.btntampil.Size = new System.Drawing.Size(75, 23);
            this.btntampil.TabIndex = 10;
            this.btntampil.Text = "Tampil";
            this.btntampil.UseVisualStyleBackColor = true;
            this.btntampil.Click += new System.EventHandler(this.btntampil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 284);
            this.Controls.Add(this.btntampil);
            this.Controls.Add(this.txttahun);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtspeed);
            this.Controls.Add(this.txtmanufaktur);
            this.Controls.Add(this.txtmodel);
            this.Controls.Add(this.txtplat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtplat;
        private System.Windows.Forms.TextBox txtmodel;
        private System.Windows.Forms.TextBox txtmanufaktur;
        private System.Windows.Forms.TextBox txtspeed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttahun;
        private System.Windows.Forms.Button btntampil;
    }
}

