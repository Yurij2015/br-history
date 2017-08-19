namespace BrowsingHistory
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
            this.chrome = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.opera = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chrome
            // 
            this.chrome.Location = new System.Drawing.Point(79, 69);
            this.chrome.Name = "chrome";
            this.chrome.Size = new System.Drawing.Size(580, 45);
            this.chrome.TabIndex = 1;
            this.chrome.Text = "Google Chrome";
            this.chrome.UseVisualStyleBackColor = true;
            this.chrome.Click += new System.EventHandler(this.chrome_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(79, 262);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(580, 239);
            this.dataGridView1.TabIndex = 4;
            // 
            // opera
            // 
            this.opera.Location = new System.Drawing.Point(79, 157);
            this.opera.Name = "opera";
            this.opera.Size = new System.Drawing.Size(580, 45);
            this.opera.TabIndex = 5;
            this.opera.Text = "Opera";
            this.opera.UseVisualStyleBackColor = true;
            this.opera.Click += new System.EventHandler(this.opera_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 513);
            this.Controls.Add(this.opera);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chrome);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button chrome;
        
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button opera;
    }
}

