using MySql.Data.MySqlClient;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace CS322_DZ12_Jovan_Spasic_4026
{
    public partial class Form1 : Form
    {
        private static String connectionString = "datasource=localhost;port=3306;database=cs322-dz12;username=root;password=;";
        private static MySqlCommand comm;
        private static MySqlConnection con;
        private static String text;
        public Form1()
        {
            InitializeComponent();
            con = new MySqlConnection(connectionString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "")
            {
                try
                {
                    con.Open();
                    string query = "INSERT INTO korisnik(username, password) VALUES('" + textBox1.Text + "', '" + textBox2.Text + "');";
                    comm = new MySqlCommand(query, con);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Podatak je sacuvan");
                }
                catch(SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                MessageBox.Show("Popunite sva polja");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "TXT files|*.txt";
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (openFileDialog1.OpenFile() != null)
                    {
                        using (StreamReader reader = new StreamReader(openFileDialog1.OpenFile()))
                        {
                            string line;
                            while ((line = reader.ReadLine()) != null)
                            {
                                text += line + "\n";
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "TXT files|*.txt";
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog1.FileName))
                    {
                        await writer.WriteAsync(text);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
