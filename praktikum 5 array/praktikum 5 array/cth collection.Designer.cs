namespace praktikum_5_array
{
    partial class cth_collection
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
            this.btnlist = new System.Windows.Forms.Button();
            this.btnqueue = new System.Windows.Forms.Button();
            this.btnstack = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnlist
            // 
            this.btnlist.Location = new System.Drawing.Point(12, 12);
            this.btnlist.Name = "btnlist";
            this.btnlist.Size = new System.Drawing.Size(75, 23);
            this.btnlist.TabIndex = 0;
            this.btnlist.Text = "List";
            this.btnlist.UseVisualStyleBackColor = true;
            this.btnlist.Click += new System.EventHandler(this.btnlist_Click);
            // 
            // btnqueue
            // 
            this.btnqueue.Location = new System.Drawing.Point(105, 12);
            this.btnqueue.Name = "btnqueue";
            this.btnqueue.Size = new System.Drawing.Size(75, 23);
            this.btnqueue.TabIndex = 1;
            this.btnqueue.Text = "Queue";
            this.btnqueue.UseVisualStyleBackColor = true;
            this.btnqueue.Click += new System.EventHandler(this.btnqueue_Click);
            // 
            // btnstack
            // 
            this.btnstack.Location = new System.Drawing.Point(204, 12);
            this.btnstack.Name = "btnstack";
            this.btnstack.Size = new System.Drawing.Size(75, 23);
            this.btnstack.TabIndex = 2;
            this.btnstack.Text = "Stack";
            this.btnstack.UseVisualStyleBackColor = true;
            this.btnstack.Click += new System.EventHandler(this.btnstack_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 53);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(267, 238);
            this.listBox1.TabIndex = 3;
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(12, 308);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(267, 23);
            this.btnclear.TabIndex = 4;
            this.btnclear.Text = "Clear List";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // cth_collection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 361);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnstack);
            this.Controls.Add(this.btnqueue);
            this.Controls.Add(this.btnlist);
            this.Name = "cth_collection";
            this.Text = "cth_collection";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnlist;
        private System.Windows.Forms.Button btnqueue;
        private System.Windows.Forms.Button btnstack;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnclear;
    }
}