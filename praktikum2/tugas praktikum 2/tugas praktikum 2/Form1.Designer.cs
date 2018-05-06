namespace tugas_praktikum_2
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtbil = new System.Windows.Forms.TextBox();
            this.txtstatik = new System.Windows.Forms.TextBox();
            this.txtnonstatik = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bilangan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasil Static";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hasil Non-Static";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 72);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Static dan Non-Static";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtbil
            // 
            this.txtbil.Location = new System.Drawing.Point(135, 30);
            this.txtbil.Name = "txtbil";
            this.txtbil.Size = new System.Drawing.Size(111, 20);
            this.txtbil.TabIndex = 4;
            // 
            // txtstatik
            // 
            this.txtstatik.Location = new System.Drawing.Point(135, 129);
            this.txtstatik.Name = "txtstatik";
            this.txtstatik.Size = new System.Drawing.Size(111, 20);
            this.txtstatik.TabIndex = 5;
            // 
            // txtnonstatik
            // 
            this.txtnonstatik.Location = new System.Drawing.Point(135, 174);
            this.txtnonstatik.Name = "txtnonstatik";
            this.txtnonstatik.Size = new System.Drawing.Size(111, 20);
            this.txtnonstatik.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 251);
            this.Controls.Add(this.txtnonstatik);
            this.Controls.Add(this.txtstatik);
            this.Controls.Add(this.txtbil);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Static & Non static";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtbil;
        private System.Windows.Forms.TextBox txtstatik;
        private System.Windows.Forms.TextBox txtnonstatik;
    }
}

