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
using System.Threading;

namespace ProjektRasvjeta
{
    class Data
    {
        public int ID { get; set; }
        public string Status { get; set; }
        public int Aktivan { get; set; }
        public int ZonaID { get; set; }
        public int Svjetlo { get; set; }
    }

    public partial class Main : Form
    {
        readonly Login login;

        public Main(Login login)
        {
            this.login = login;
            InitializeComponent();
        }

        private void onoffbutton_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            update();
            StartBackgroundTask();
        }

        private void Main_Closing(object sender, FormClosingEventArgs e)
        {
            login.Close();
        }

        void StartBackgroundTask()
        {
            new Thread(() =>
            {
                while (true)
                {
                    // MessageBox.Show("Zona je dodana!");

                    string connectionString = "server=localhost;uid=root;pwd=1234;database=rasvjetadb";
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        List<Data> dataList = new List<Data>();

                        using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM senzor ORDER BY zona_id", connection))
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Data data = new Data();
                                data.ID = reader.GetInt32(0);
                                data.Status = reader.GetString(1);
                                data.Aktivan = reader.GetInt32(2);
                                data.ZonaID = reader.GetInt32(3);
                                data.Svjetlo = reader.GetInt32(4);
                                dataList.Add(data);
                            }
                        }

                        int idz = -1;
                        int pamti = 0;
                        Random random = new Random();

                        pamti = 1;
                        string updat = $"UPDATE svjetlo SET snaga = 0";
                        using (MySqlCommand cmd = new MySqlCommand(updat, connection))
                            cmd.ExecuteNonQuery();


                        foreach (Data data in dataList)
                        {
                            string genaktivan;
                            string updatesenzor = "";
                            string snaga = "0";

                            double randombroj = random.NextDouble();

                            if (data.ZonaID != idz)
                            {
                                idz = data.ZonaID;
                                pamti = 0;
                            }

                            if (data.Svjetlo > 75 || data.Status != "ok")
                            {
                                updatesenzor = $"UPDATE senzor SET aktivan = '0' WHERE id = {data.ID.ToString()}";

                                using (MySqlCommand cmd = new MySqlCommand(updatesenzor, connection))
                                    cmd.ExecuteNonQuery();
                                
                                continue;
                            }
                            if (randombroj < 0.9)
                            {
                                genaktivan = "0";
                                snaga = "0";
                            }                            
                            else
                            {
                                genaktivan = "1";
                                snaga = "75";
                            }

                            if (snaga == "75")
                            {
                                pamti = 1;
                                string updatelampa = $"UPDATE svjetlo SET snaga = {snaga} WHERE zona_id = {data.ZonaID.ToString()}";
                                using (MySqlCommand cmd = new MySqlCommand(updatelampa, connection))
                                    cmd.ExecuteNonQuery();
                            }

                            updatesenzor = $"UPDATE senzor SET aktivan = '{genaktivan}' WHERE id = {data.ID.ToString()}";
                            using (MySqlCommand cmd = new MySqlCommand(updatesenzor, connection))
                                cmd.ExecuteNonQuery();
                            
                        }
                        connection.Close();
                    }
                    update();
                    
                Thread.Sleep(5000);
            }
            }).Start();
    } 

        private void onoffbuttonse_Click(object sender, EventArgs e)
        {

        }

        private void listViewlampe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttondodajz_Click(object sender, EventArgs e)
        {

            try
            {
                string sql = "SELECT COUNT(*) FROM zona WHERE ime = @valueToCheck;";

                string conn = "server=localhost;uid=root;pwd=1234;database=rasvjetadb";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = conn;
                con.Open();

                MySqlCommand command = new MySqlCommand(sql, con);

                command.Parameters.AddWithValue("@valueToCheck", textBoxdodajzonu.Text);
                int count = Convert.ToInt32(command.ExecuteScalar());
                if (count > 0)
                {
                    MessageBox.Show("Zona već postoji. Molimo unesite neko drugo ime.");
                }
                else
                {
                    string insertSql = "INSERT INTO `zona` (`ime`) VALUES ('" + textBoxdodajzonu.Text + "');";
                    using (MySqlCommand insertCommand = new MySqlCommand(insertSql, con))
                    {
                        insertCommand.ExecuteReader();
                        MessageBox.Show("Zona je dodana!");
                        update();
                    }
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttondodaj_Click(object sender, EventArgs e)
        {
            try
            {
                string conn = "server=localhost;uid=root;pwd=1234;database=rasvjetadb";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = conn;
                con.Open();

                int idz;
                string sql = "SELECT id FROM zona WHERE ime = '"+ comboBox1.Text+"';";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                
                idz = reader.GetInt32(0);
                reader.Close();
                sql = "INSERT INTO `svjetlo` (`status`, `aktivan`, `zona_id`, `upaljno`, `snaga`) VALUES ('disconnected', '0', '" +idz.ToString()+"', '0', '0');";
                cmd = new MySqlCommand(sql, con);
                cmd.ExecuteReader();
                con.Close();
                update();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttondodajse_Click(object sender, EventArgs e)
        {
            try
            {
                string conn = "server=localhost;uid=root;pwd=1234;database=rasvjetadb";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = conn;
                con.Open();

                string sql = "INSERT INTO `rasvjetadb`.`senzor` (`status`, `aktivan`, `zona_id`, `svjetlo`) VALUES ('disconnected', '0', '"+comboBox2.Text+"', '0');";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteReader();
                con.Close();
                update();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string conn = "server=localhost;uid=root;pwd=1234;database=rasvjetadb";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = conn;
                con.Open();
                int idz;
                string sql = "SELECT id FROM zona WHERE ime = '" + comboBox3.Text + "';";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                idz = reader.GetInt32(0);
                reader.Close();
                sql = "UPDATE `rasvjetadb`.`svjetlo` SET `status` = 'Izvanredno', `snaga` = '100' WHERE status = 'ok' and zona_id = '" + idz.ToString()+"';";
                cmd = new MySqlCommand(sql, con);
                cmd.ExecuteReader();
                con.Close();
                update();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string conn = "server=localhost;uid=root;pwd=1234;database=rasvjetadb";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = conn;
                con.Open();
                int idz;
                string sql = "SELECT id FROM zona WHERE ime = '" + comboBox3.Text + "';";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();

                idz = reader.GetInt32(0);
                reader.Close();
                sql = "UPDATE `rasvjetadb`.`svjetlo` SET `status` = 'Ok', `snaga` = '25' WHERE status = 'Izvanredno' and zona_id = '" + idz.ToString() + "';";
                cmd = new MySqlCommand(sql, con);
                cmd.ExecuteReader();
                con.Close();
                update();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string conn = "server=localhost;uid=root;pwd=1234;database=rasvjetadb";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = conn;
                con.Open();
                string sql;
                if (radioButton3.Checked)
                {
                    sql = "UPDATE `rasvjetadb`.`svjetlo` SET `status` = '" + comboBox4.Text + "', upaljeno = '1'  WHERE id = '" + comboBox5.Text.ToString() + "'; ";
                }
                else
                {
                    sql = "UPDATE `rasvjetadb`.`svjetlo` SET `status` = '" + comboBox4.Text + "', upaljeno = '0' WHERE id = '" + comboBox5.Text.ToString() + "'; ";
                }
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteReader();
                con.Close();
                update();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string conn = "server=localhost;uid=root;pwd=1234;database=rasvjetadb";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = conn;
                con.Open();
                
                string sql = "UPDATE `rasvjetadb`.`senzor` SET `status` = '"+comboBox6.Text+"' WHERE id = '" + comboBox7.Text + "';";
                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.ExecuteReader();
                con.Close();
                update();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }       

        public void update()
        {
            listViewlampe.Items.Clear();
            listViewse.Items.Clear();
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            string connstring = "server=localhost;uid=root;pwd=1234;database=rasvjetadb";
            using (MySqlConnection con = new MySqlConnection(connstring))
            {
                con.Open();
                string sql = "SELECT * FROM svjetlo";
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string status = reader.GetString(1);
                            int zona_id = reader.GetInt32(2);
                            int upaljen = reader.GetInt32(3);
                            string snaga = reader.GetInt32(4).ToString() + "%";

                            if (status == "kvar")
                                status = "U kvaru";
                            else if (status == "popravak")
                                status = "U popravku";

                            ListViewItem item = new ListViewItem(id.ToString());
                            if (upaljen == 0)
                                item.SubItems.Add("Off");
                            else
                                item.SubItems.Add("On");
                            item.SubItems.Add(status);
                            item.SubItems.Add(zona_id.ToString());
                            item.SubItems.Add(snaga);

                            listViewlampe.Items.Add(item);
                        }
                    }
                }
            }
            using (MySqlConnection con = new MySqlConnection(connstring))
            {
                con.Open();
                string sql = "SELECT * FROM senzor";
                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string status = reader.GetString(1);
                            int aktivan = reader.GetInt32(2);
                            int svjetlo_id = reader.GetInt32(3);
                            int svjetlost = reader.GetInt32(4);
                            string svjetlostpo = svjetlost.ToString() + "%";
                            string aktivann = "";

                            if (status == "kvar")
                                status = "U kvaru";
                            else if (status == "popravak")
                                status = "U popravku";

                            if (aktivan == 0)
                                aktivann = "Ne";
                            else
                                aktivann = "Da";

                            ListViewItem item = new ListViewItem(id.ToString());
                            item.SubItems.Add("On");
                            item.SubItems.Add(status);
                            item.SubItems.Add(aktivann);
                            item.SubItems.Add(svjetlo_id.ToString());
                            item.SubItems.Add(svjetlostpo);

                            listViewse.Items.Add(item);

                        }
                    }
                }
            }
            using (MySqlConnection con = new MySqlConnection(connstring))
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand("SELECT id FROM svjetlo", con))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string value = reader.GetString(0);                          
                            comboBox4.Items.Add(value);
                        }
                    }
                }
            }
            using (MySqlConnection con = new MySqlConnection(connstring))
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand("SELECT ime FROM zona", con))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string value = reader.GetString(0);
                            comboBox2.Items.Add(value);
                            comboBox1.Items.Add(value);
                            comboBox3.Items.Add(value);
                        }
                    }
                }
            }
            using (MySqlConnection con = new MySqlConnection(connstring))
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand("SELECT id FROM zona", con))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string value = reader.GetInt32(0).ToString();
                            comboBox7.Items.Add(value);  
                        }
                    }
                }
            }
        }
    }
}
