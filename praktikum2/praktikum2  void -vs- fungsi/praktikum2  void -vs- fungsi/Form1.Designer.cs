namespace praktikum2__void__vs__fungsi
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
            this.txtpanjang = new System.Windows.Forms.TextBox();
            this.txtlebar = new System.Windows.Forms.TextBox();
            this.txthasilvoid = new System.Windows.Forms.TextBox();
            this.txthasilfungsi = new System.Windows.Forms.TextBox();
            this.btnluasvoid = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Panjang";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lebar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hasil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hasil";
            // 
            // txtpanjang
            // 
            this.txtpanjang.Location = new System.Drawing.Point(101, 23);
            this.txtpanjang.Name = "txtpanjang";
            this.txtpanjang.Size = new System.Drawing.Size(100, 20);
            this.txtpanjang.TabIndex = 4;
            // 
            // txtlebar
            // 
            this.txtlebar.Location = new System.Drawing.Point(320, 23);
            this.txtlebar.Name = "txtlebar";
            this.txtlebar.Size = new System.Drawing.Size(100, 20);
            this.txtlebar.TabIndex = 5;
            this.txtlebar.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txthasilvoid
            // 
            this.txthasilvoid.Location = new System.Drawing.Point(101, 127);
            this.txthasilvoid.Name = "txthasilvoid";
            this.txthasilvoid.Size = new System.Drawing.Size(100, 20);
            this.txthasilvoid.TabIndex = 6;
            // 
            // txthasilfungsi
            // 
            this.txthasilfungsi.Location = new System.Drawing.Point(320, 127);
            this.txthasilfungsi.Name = "txthasilfungsi";
            this.txthasilfungsi.Size = new System.Drawing.Size(100, 20);
            this.txthasilfungsi.TabIndex = 7;
            this.txthasilfungsi.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // btnluasvoid
            // 
            this.btnluasvoid.Location = new System.Drawing.Point(39, 73);
            this.btnluasvoid.Name = "btnluasvoid";
            this.btnluasvoid.Size = new System.Drawing.Size(162, 32);
            this.btnluasvoid.TabIndex = 8;
            this.btnluasvoid.Text = "LUAS (void)";
            this.btnluasvoid.UseVisualStyleBackColor = true;
            this.btnluasvoid.Click += new System.EventHandler(this.btnluasvoid_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(269, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 30);
            this.button2.TabIndex = 9;
            this.button2.Text = "LUAS (fungsi)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 240);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnluasvoid);
            this.Controls.Add(this.txthasilfungsi);
            this.Controls.Add(this.txthasilvoid);
            this.Controls.Add(this.txtlebar);
            this.Controls.Add(this.txtpanjang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ni\'am HS 14.11.0185";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpanjang;
        private System.Windows.Forms.TextBox txtlebar;
        private System.Windows.Forms.TextBox txthasilvoid;
        private System.Windows.Forms.TextBox txthasilfungsi;
        private System.Windows.Forms.Button btnluasvoid;
        private System.Windows.Forms.Button button2;
    }
}

