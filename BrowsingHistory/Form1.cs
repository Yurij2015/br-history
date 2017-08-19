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
            //SQLiteDataAdapter sd = new SQLiteDataAdapter("select * from urls order by last_visit_time desc", cn);
            DataSet ds = new DataSet();
            sd.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            cn.Close();
        }
    }
}
