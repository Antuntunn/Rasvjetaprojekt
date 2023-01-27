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

namespace ProjektRasvjeta
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username, password;

            username = textBoxUName.Text;
            password = textBoxPWord.Text;
            try
            {
                string connstring = "server=localhost;uid=root;pwd=1234;database=rasvjetadb";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();
                string sql = "SELECT * FROM korisnik where username = '" + username + "' AND password = '" + password + "'";
                MySqlCommand cmd = new MySqlCommand(sql, con);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count > 0)
                {
                    Main main = new Main(this);
                    this.Hide();
                    main.Show();
                    
                }
                else
                {
                    MessageBox.Show("Krivi username ili password");
                }
                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }



        }
    }
}
