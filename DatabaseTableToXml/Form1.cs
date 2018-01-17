using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DatabaseTableToXml
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

 

            // Create a DataSet and put both tables in it.

            DataSet set = new DataSet("office");

            // Create a database connection string
            String str = String.Format("SERVER=localhost;DATABASE=mysql;UID=root;PASSWORD=;");
            MySqlConnection con = new MySqlConnection();
            // Create the database connection object
            con = new MySqlConnection(str);
            con.Open(); // open it


            DataSet ds = new DataSet();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM db; SELECT * FROM user", con);
            adapter.TableMappings.Add("Table", "Tabela1");
            adapter.TableMappings.Add("Table1", "Tabela2");

            adapter.Fill(ds);
           
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView2.DataSource = ds.Tables[1];

            ds.WriteXml("D:\\test.xml");            
            dataGridView1.Refresh();
            
        }
    }
}
