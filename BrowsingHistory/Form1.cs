using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace BrowsingHistory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void chrome_Click(object sender, EventArgs e)
        {
            string google = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Google\Chrome\User Data\Default\History";
            SQLiteConnection cn = new SQLiteConnection("Data Source=" + google + ";Version=3;New=False; Compress = True");
            cn.Open();
            SQLiteDataAdapter sd = new SQLiteDataAdapter("select url, title, visit_count,datetime((last_visit_time/1000000)-11644473600, 'unixepoch', 'localtime') as last_visit_time from urls order by last_visit_time desc", cn);
            
            DataSet ds = new DataSet();
            sd.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            cn.Close();
        }


        private void opera_Click(object sender, EventArgs e)
        {
            string opera = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Opera Software\Opera Stable\", "History");
          
            SQLiteConnection cn = new SQLiteConnection("Data Source=" + opera + ";Version=3;New=False; Compress = True");
            cn.Open();
            
            SQLiteDataAdapter sd = new SQLiteDataAdapter("select url, title, visit_count,datetime((last_visit_time/1000000)-11644473600, 'unixepoch', 'localtime') as last_visit_time from urls order by last_visit_time desc", cn);
            DataSet ds = new DataSet();
            sd.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            cn.Close();
        }

        private void chrome_MouseHover(object sender, EventArgs e)
        {
            chrome.BackColor = Color.Blue;
           
        }

        private void chrome_MouseLeave(object sender, EventArgs e)
        {
            chrome.BackColor = Color.Transparent;
        }

        private void chrome_MouseClick(object sender, MouseEventArgs e)
        {
            chrome.BringToFront();
        }
    }
}
