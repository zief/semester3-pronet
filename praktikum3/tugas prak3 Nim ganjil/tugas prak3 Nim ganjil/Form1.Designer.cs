namespace tugas_prak3_Nim_ganjil
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
            this.txttambah1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttambah1overload = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pertambahan awal";
            // 
            // txttambah1
            // 
            this.txttambah1.Location = new System.Drawing.Point(163, 53);
            this.txttambah1.Name = "txttambah1";
            this.txttambah1.Size = new System.Drawing.Size(100, 20);
            this.txttambah1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pertambahan setelah overload";
            // 
            // txttambah1overload
            // 
            this.txttambah1overload.Location = new System.Drawing.Point(182, 145);
            this.txttambah1overload.Name = "txttambah1overload";
            this.txttambah1overload.Size = new System.Drawing.Size(100, 20);
            this.txttambah1overload.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tambah";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(55, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(208, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Tambah Overload";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txttambah1overload);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttambah1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttambah1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttambah1overload;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

