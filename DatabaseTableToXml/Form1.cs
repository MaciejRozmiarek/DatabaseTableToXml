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


            try
            {
                DataSet set = new DataSet("office");

                // Create a database connection string
                String str = String.Format("SERVER=" + IpBazyTextBox.Text + "; DATABASE=" + nazwaBazyTextBox.Text + "; UID=" + loginTextBox.Text + "; PASSWORD=" + hasłoTextBox.Text + "; ");
                MySqlConnection con = new MySqlConnection();
                // Create the database connection object
                con = new MySqlConnection(str);
                con.Open(); // open it


                DataSet ds = new DataSet();
                MySqlDataAdapter adapter = new MySqlDataAdapter(queryTextBox1.Text + "; " + queryTextBox2.Text + "; " + queryTextBox3.Text + ";", con);

                adapter.TableMappings.Add("Table", "Tabela1");
                adapter.TableMappings.Add("Table1", "Tabela2");
                adapter.TableMappings.Add("Table3", "Tabela3");
                adapter.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
                dataGridView2.DataSource = ds.Tables[1];
                dataGridView3.DataSource = ds.Tables[2];
                dataGridView1.Refresh();

                ds.WriteXml(textBox1.Text);
                

                MessageBox.Show("Plik zapisany do lokalizacji " + textBox1.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(""+ex);
            }
  
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath + "ExportDoXml.xml";
            }
        }
    }
}
