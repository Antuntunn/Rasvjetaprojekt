using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Threading;
using System.Collections.Generic;

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

                        string updat = $"UPDATE svjetlo SET snaga = 0";
                        using (MySqlCommand cmd = new MySqlCommand(updat, connection))
                            cmd.ExecuteNonQuery();

                        int idz = -1;
                        Random random = new Random();

                        foreach (Data data in dataList)
                        {
                            string genaktivan;
                            string updatesenzor;
                            string snaga = "25";

                            double randombroj = random.NextDouble();

                            if (data.ZonaID != idz)
                            {
                                idz = data.ZonaID;
                            }

                            if (data.Svjetlo > 90 || data.Status != "ok")
                            {
                                updatesenzor = $"UPDATE senzor SET aktivan = '0' WHERE id = {data.ID}";
                                using (MySqlCommand cmd = new MySqlCommand(updatesenzor, connection))
                                    cmd.ExecuteNonQuery();

                                string updatelampa = $"UPDATE svjetlo SET snaga = 0 WHERE zona_id = {data.ZonaID}";
                                using (MySqlCommand cmd = new MySqlCommand(updatelampa, connection))
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
                                snaga = "90";
                            }

                            if (snaga == "90")
                            {
                                string updatelampa = $"UPDATE svjetlo SET snaga = {snaga} WHERE zona_id = {data.ZonaID}";
                                using (MySqlCommand cmd = new MySqlCommand(updatelampa, connection))
                                    cmd.ExecuteNonQuery();
                            }

                            updatesenzor = $"UPDATE senzor SET aktivan = '{genaktivan}' WHERE id = {data.ID}";
                            using (MySqlCommand cmd = new MySqlCommand(updatesenzor, connection))
                                cmd.ExecuteNonQuery();

                        }
                        updat = $"UPDATE svjetlo SET snaga = 0 WHERE status != 'ok' ";
                        using (MySqlCommand cmd = new MySqlCommand(updat, connection))
                            cmd.ExecuteNonQuery();
                        connection.Close();
                    }
                    update();

                    Thread.Sleep(10000);
                }
            }).Start();
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
            string connectionString = "server=localhost;uid=root;pwd=1234;database=rasvjetadb";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                int idzone = 1;
                using (MySqlCommand cmd = new MySqlCommand("SELECT id FROM zona WHERE ime = '" + comboBox1.Text + "';", connection))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                    while (reader.Read())
                        idzone = reader.GetInt32(0);
                string sql = "INSERT INTO `svjetlo` (`status`, `zona_id`, `upaljeno`, `snaga`) VALUES ('disconnected', '" + idzone.ToString() + "', '0', '0');";
                using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    cmd.ExecuteNonQuery();
                update();
                MessageBox.Show("Dodana je lampa!");
            }
        }

        private void buttondodajse_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;uid=root;pwd=1234;database=rasvjetadb";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                int idzone = 1;
                using (MySqlCommand cmd = new MySqlCommand("SELECT id FROM zona WHERE ime = '" + comboBox2.Text + "';", connection))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                    while (reader.Read())
                        idzone = reader.GetInt32(0);
                string sql = "INSERT INTO `rasvjetadb`.`senzor` (`status`, `aktivan`, `zona_id`, `svjetlo`) VALUES ('ok', '0', '" + idzone.ToString() + "', '0');";
                using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    cmd.ExecuteNonQuery();
                update();
                MessageBox.Show("Dodan je senzor!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;uid=root;pwd=1234;database=rasvjetadb";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                int idzone = 1;
                using (MySqlCommand cmd = new MySqlCommand("SELECT id FROM zona WHERE ime = '" + comboBox3.Text + "';", connection))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                    while (reader.Read())
                        idzone = reader.GetInt32(0);
                string sql = "UPDATE `rasvjetadb`.`svjetlo` SET `status` = 'Izvanredno', `snaga` = '100' WHERE status = 'ok' and zona_id = '" + idzone.ToString() + "';";
                using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    cmd.ExecuteNonQuery();
                update();
                MessageBox.Show($"Izvanredno stanje upaljeno u zoni {idzone}!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;uid=root;pwd=1234;database=rasvjetadb";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                int idzone = 1;
                using (MySqlCommand cmd = new MySqlCommand("SELECT id FROM zona WHERE ime = '" + comboBox3.Text + "';", connection))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                    while (reader.Read())
                        idzone = reader.GetInt32(0);
                string sql = "UPDATE `rasvjetadb`.`svjetlo` SET `status` = 'Ok', `snaga` = '25' WHERE status = 'Izvanredno' and zona_id = '" + idzone.ToString() + "';";
                using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    cmd.ExecuteNonQuery();
                update();
                MessageBox.Show($"Izvanredno stanje ugašeno u zoni {idzone}!");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string sql;
            if (radioButton3.Checked)
                sql = "UPDATE `rasvjetadb`.`svjetlo` SET `status` = '" + comboBox4.Text + "', upaljeno = '1'  WHERE id = '" + comboBox5.Text.ToString() + "'; ";
            else
                sql = "UPDATE `rasvjetadb`.`svjetlo` SET `status` = '" + comboBox4.Text + "', upaljeno = '0' WHERE id = '" + comboBox5.Text.ToString() + "'; ";
            string connectionString = "server=localhost;uid=root;pwd=1234;database=rasvjetadb";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    cmd.ExecuteNonQuery();
                update();
                MessageBox.Show($"Lampa je updateana!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;uid=root;pwd=1234;database=rasvjetadb";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string sql = "UPDATE `rasvjetadb`.`senzor` SET `status` = '" + comboBox6.Text + "' WHERE id = '" + comboBox7.Text + "'; ";
                using (MySqlCommand cmd = new MySqlCommand(sql, connection))
                    cmd.ExecuteNonQuery();
                update();
                MessageBox.Show($"Senzor je updatean!");
            }
        }

        public void update()
        {
            listViewlampe.Items.Clear();
            listViewse.Items.Clear();
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox7.Items.Clear();

            string connstring = "server=localhost;uid=root;pwd=1234;database=rasvjetadb";
            using (MySqlConnection con = new MySqlConnection(connstring))
            {
                con.Open();
                string sql = "SELECT * FROM svjetlo";
                using (MySqlCommand command = new MySqlCommand(sql, con))
                using (MySqlDataReader reader = command.ExecuteReader())
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
                using (MySqlCommand command = new MySqlCommand("SELECT * FROM senzor", con))
                using (MySqlDataReader reader = command.ExecuteReader())
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
                using (MySqlCommand command = new MySqlCommand("SELECT id FROM svjetlo", con))
                using (MySqlDataReader reader = command.ExecuteReader())
                    while (reader.Read())
                    {
                        string value = reader.GetString(0);
                        comboBox4.Items.Add(value);
                    }
                using (MySqlCommand command = new MySqlCommand("SELECT ime FROM zona", con))
                using (MySqlDataReader reader = command.ExecuteReader())
                    while (reader.Read())
                    {
                        string value = reader.GetString(0);
                        comboBox2.Items.Add(value);
                        comboBox1.Items.Add(value);
                        comboBox3.Items.Add(value);
                    }
                using (MySqlCommand command = new MySqlCommand("SELECT id FROM senzor", con))
                using (MySqlDataReader reader = command.ExecuteReader())
                    while (reader.Read())
                    {
                        string value = reader.GetInt32(0).ToString();
                        comboBox7.Items.Add(value);
                    }
            }
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
            comboBox6.SelectedIndex = 0;
            comboBox7.SelectedIndex = 0;
        }
    }
}
