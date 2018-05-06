namespace praktikum_5_array
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
            this.txtmasuk = new System.Windows.Forms.TextBox();
            this.btnfarray = new System.Windows.Forms.Button();
            this.btnfstring = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Masukkan Kata";
            // 
            // txtmasuk
            // 
            this.txtmasuk.Location = new System.Drawing.Point(119, 12);
            this.txtmasuk.Name = "txtmasuk";
            this.txtmasuk.Size = new System.Drawing.Size(124, 20);
            this.txtmasuk.TabIndex = 1;
            // 
            // btnfarray
            // 
            this.btnfarray.Location = new System.Drawing.Point(19, 67);
            this.btnfarray.Name = "btnfarray";
            this.btnfarray.Size = new System.Drawing.Size(98, 23);
            this.btnfarray.TabIndex = 2;
            this.btnfarray.Text = "Foreach array";
            this.btnfarray.UseVisualStyleBackColor = true;
            this.btnfarray.Click += new System.EventHandler(this.btnfarray_Click);
            // 
            // btnfstring
            // 
            this.btnfstring.Location = new System.Drawing.Point(138, 67);
            this.btnfstring.Name = "btnfstring";
            this.btnfstring.Size = new System.Drawing.Size(105, 23);
            this.btnfstring.TabIndex = 3;
            this.btnfstring.Text = "Foreach string";
            this.btnfstring.UseVisualStyleBackColor = true;
            this.btnfstring.Click += new System.EventHandler(this.btnfstring_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(292, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(184, 212);
            this.listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 243);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnfstring);
            this.Controls.Add(this.btnfarray);
            this.Controls.Add(this.txtmasuk);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Foreach ni\'am hs 14.11.0185";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmasuk;
        private System.Windows.Forms.Button btnfarray;
        private System.Windows.Forms.Button btnfstring;
        private System.Windows.Forms.ListBox listBox1;
    }
}

