using Azure.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DACS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void b1_Click(object sender, EventArgs e)
        {
            string connectionString = @"data source=DESKTOP-1FRTHP2\SQLEXPRESS; initial catalog=dacs ;integrated security=true";
            SqlConnection cn = new SqlConnection(connectionString);
            //try
            //{
            //    cn.Open();
            //    MessageBox.Show(cn.State.ToString());

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);






            //}

            //SqlConnection cn2 = new SqlConnection(connectionString);

            cn.Open();
            string query = "SELECT * FROM utilisateur WHERE Login = @Login AND Password = @Password";

            //string query = "SELECT * FROM utilisateur WHERE Login =@Login" + tb1.Text + "'"+"  AND Password = '" + tb2.Text;
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@Login", tb1.Text);
            cmd.Parameters.AddWithValue("@Password", tb2.Text);
            SqlDataReader dr;
            dr=cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                Form nouvelleFenetre = new Form();
                this.Hide();
                nouvelleFenetre.ShowDialog();
                MessageBox.Show("Exisste");
            }
            else
            {
                MessageBox.Show("Not Exist");
            }
            cn.Close();



            


            

        }
    }
}