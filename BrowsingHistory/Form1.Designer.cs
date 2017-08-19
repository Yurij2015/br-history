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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chrome = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.opera = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chrome
            // 
            this.chrome.BackColor = System.Drawing.Color.Transparent;
            this.chrome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chrome.BackgroundImage")));
            this.chrome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.chrome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chrome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chrome.Location = new System.Drawing.Point(177, 47);
            this.chrome.Name = "chrome";
            this.chrome.Size = new System.Drawing.Size(136, 129);
            this.chrome.TabIndex = 1;
            this.chrome.Text = "\r\n";
            this.chrome.UseVisualStyleBackColor = false;
            this.chrome.Click += new System.EventHandler(this.chrome_Click);
            this.chrome.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chrome_MouseClick);
            this.chrome.MouseLeave += new System.EventHandler(this.chrome_MouseLeave);
            this.chrome.MouseHover += new System.EventHandler(this.chrome_MouseHover);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(98, 235);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Size = new System.Drawing.Size(580, 282);
            this.dataGridView1.TabIndex = 4;
            // 
            // opera
            // 
            this.opera.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.opera.BackColor = System.Drawing.Color.Transparent;
            this.opera.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("opera.BackgroundImage")));
            this.opera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.opera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.opera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.opera.Location = new System.Drawing.Point(451, 47);
            this.opera.Name = "opera";
            this.opera.Size = new System.Drawing.Size(136, 129);
            this.opera.TabIndex = 5;
            this.opera.UseVisualStyleBackColor = false;
            this.opera.Click += new System.EventHandler(this.opera_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(801, 547);
            this.Controls.Add(this.opera);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chrome);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HelpButton = true;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Browsing History";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button chrome;
        
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button opera;
    }
}

