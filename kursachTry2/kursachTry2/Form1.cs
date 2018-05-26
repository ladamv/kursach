using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace kursachTry2
{
    public partial class Form1 : Form
    {
        private SqlConnection cnn = null;
        public Form1()
        {
            InitializeComponent();
        }
        string itemChngd;

        private async void Form1_Load(object sender, EventArgs e)
        {
            string cnnSQl = ConfigurationManager.ConnectionStrings["DBSTRING"].ConnectionString;
            cnn = new SqlConnection(cnnSQl);
            await cnn.OpenAsync();

            TableList.GridLines = true;
            TableList.FullRowSelect = true;

            TableList.View = View.Details;
            if (itemChngd == "Cars")
            {
                TableList.Columns.Add("Smth");
            }


            //.ToString();
            //SelectedItem.ToString();


            //TableList.Columns.Add("Car");
            //TableList.Columns.Add("Carrrrr");

            /* else if (Combo.SelectedItem.ToString() == "Cars")
             {
                 TableList.Columns.Add("Smth");
             }*/

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {

        }

        public void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
    
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cnn != null && cnn.State != ConnectionState.Closed)
                cnn.Close();

        }

        public void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            
        }

        public void Selected(object sender, EventArgs e)
        {
             itemChngd = Combo.SelectedIndex.ToString();
         
        }
    }
}
