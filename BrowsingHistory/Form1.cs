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
            //SQLiteDataAdapter sd = new SQLiteDataAdapter("select url, title, visit_count,last_visit_time from urls order by last_visit_time desc", cn);
            SQLiteDataAdapter sd = new SQLiteDataAdapter("select * from urls order by last_visit_time desc", cn);
            DataSet ds = new DataSet();
            sd.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            cn.Close();
        }

        /*private void opera_Click(object sender, EventArgs e)
        {

        }

        private void safari_Click(object sender, EventArgs e)
        {

        }
        private void firefox_Click(object sender, EventArgs e)
      {
          string mozilla = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Mozilla\Firefox\Profiles\bupbe9lk.default\places.sqlite";
          //string firefox = Environment.GetFolderPath(Environment.SpecialFolder.);
          SQLiteConnection cn = new SQLiteConnection("Data Source=" + mozilla + ";Version=3;New=False; Compress = True");
          cn.Open();
          //SQLiteDataAdapter sd = new SQLiteDataAdapter("select url, title, visit_count,last_visit_time from moz_places order by last_visit_time desc", cn);
          SQLiteDataAdapter sd = new SQLiteDataAdapter("select * from moz_places", cn);
          DataSet ds = new DataSet();
          sd.Fill(ds);
          dataGridView1.DataSource = ds.Tables[0];
          cn.Close();
      }*/
    }
}
