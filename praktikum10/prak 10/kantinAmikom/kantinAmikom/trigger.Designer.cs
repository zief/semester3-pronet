namespace kantinAmikom
{
    partial class trigger
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
            this.txtno = new System.Windows.Forms.TextBox();
            this.txttgl = new System.Windows.Forms.TextBox();
            this.txtidcust = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbomenu = new System.Windows.Forms.ComboBox();
            this.txtharga = new System.Windows.Forms.TextBox();
            this.txtidmenu = new System.Windows.Forms.TextBox();
            this.btninsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "No transaksi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tanggal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "id Customer";
            // 
            // txtno
            // 
            this.txtno.Location = new System.Drawing.Point(134, 26);
            this.txtno.Name = "txtno";
            this.txtno.Size = new System.Drawing.Size(158, 20);
            this.txtno.TabIndex = 3;
            this.txtno.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txttgl
            // 
            this.txttgl.Location = new System.Drawing.Point(134, 63);
            this.txttgl.Name = "txttgl";
            this.txttgl.Size = new System.Drawing.Size(158, 20);
            this.txttgl.TabIndex = 4;
            // 
            // txtidcust
            // 
            this.txtidcust.Location = new System.Drawing.Point(134, 101);
            this.txtidcust.Name = "txtidcust";
            this.txtidcust.Size = new System.Drawing.Size(158, 20);
            this.txtidcust.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nama Menu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Harga";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cbomenu
            // 
            this.cbomenu.FormattingEnabled = true;
            this.cbomenu.Location = new System.Drawing.Point(134, 188);
            this.cbomenu.Name = "cbomenu";
            this.cbomenu.Size = new System.Drawing.Size(158, 21);
            this.cbomenu.TabIndex = 8;
            this.cbomenu.SelectedIndexChanged += new System.EventHandler(this.cbomenu_SelectedIndexChanged);
            // 
            // txtharga
            // 
            this.txtharga.Location = new System.Drawing.Point(138, 235);
            this.txtharga.Name = "txtharga";
            this.txtharga.Size = new System.Drawing.Size(154, 20);
            this.txtharga.TabIndex = 9;
            // 
            // txtidmenu
            // 
            this.txtidmenu.Location = new System.Drawing.Point(327, 188);
            this.txtidmenu.Name = "txtidmenu";
            this.txtidmenu.Size = new System.Drawing.Size(74, 20);
            this.txtidmenu.TabIndex = 10;
            // 
            // btninsert
            // 
            this.btninsert.Location = new System.Drawing.Point(342, 275);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(75, 23);
            this.btninsert.TabIndex = 11;
            this.btninsert.Text = "OK";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // trigger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 334);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.txtidmenu);
            this.Controls.Add(this.txtharga);
            this.Controls.Add(this.cbomenu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtidcust);
            this.Controls.Add(this.txttgl);
            this.Controls.Add(this.txtno);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "trigger";
            this.Text = "Penjualan";
            this.Load += new System.EventHandler(this.trigger_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtno;
        private System.Windows.Forms.TextBox txttgl;
        private System.Windows.Forms.TextBox txtidcust;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbomenu;
        private System.Windows.Forms.TextBox txtharga;
        private System.Windows.Forms.TextBox txtidmenu;
        private System.Windows.Forms.Button btninsert;
    }
}