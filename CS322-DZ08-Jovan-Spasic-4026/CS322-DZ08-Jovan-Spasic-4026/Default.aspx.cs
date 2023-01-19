using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Web.UI;
using System.Xml.Linq;

namespace CS322_DZ08_Jovan_Spasic_4026
{
    public partial class _Default : Page
    {
        private static String conStr = "datasource=localhost;database=cs322_dz08;port=3306;username=root;password=;";
        private static MySqlConnection con;
        private static MySqlCommand comm;
        private static MySqlDataAdapter adapter;

        protected void Page_Load(object sender, EventArgs e)
        {
            con = new MySqlConnection(conStr);
            loadData();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int n = Int32.Parse(TextBox1.Text);
            n = faktorijel(n);
            Label2.Text = "Faktorijel broja je: " + n;

            String query = "insert into faktorijel(broj, faktorijel_broja) values('" + TextBox1.Text + "', '" + n + "');";
            comm = new MySqlCommand(query, con);
            try
            {
                con.Open();
                comm.ExecuteNonQuery();
                con.Close();
                loadData();
            }
            catch (Exception ex)
            {
                con.Close();
            }

        }

        private int faktorijel(int n)
        {
            if(n == 0 || n == 1)
            {
                return 1;
            }
            return n * faktorijel(n - 1);
        }

        private void loadData()
        {
            con.Open();
            adapter = new MySqlDataAdapter();
            string query = "SELECT * FROM faktorijel;";
            adapter.SelectCommand = new MySqlCommand(query, con);

            DataTable table = new DataTable();
            adapter.Fill(table);

            GridView1.DataSource = table;
            GridView1.DataBind();
            con.Close();
        }

    }
}