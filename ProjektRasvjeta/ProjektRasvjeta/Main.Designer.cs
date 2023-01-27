namespace ProjektRasvjeta
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.seToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewlampe = new System.Windows.Forms.ListView();
            this.column_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_upaljen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_zona = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_snaga = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewse = new System.Windows.Forms.ListView();
            this.column_seid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_seupaljen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_sestatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_seaktivan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_zona_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_sesvjetlo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttondodaj = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxdodajzonu = new System.Windows.Forms.TextBox();
            this.buttondodajz = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.buttondodajse = new System.Windows.Forms.Button();
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.IzvanrednoON = new System.Windows.Forms.Button();
            this.IzvanrednoOFF = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // seToolStripMenuItem
            // 
            this.seToolStripMenuItem.Name = "seToolStripMenuItem";
            this.seToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // listViewlampe
            // 
            this.listViewlampe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_id,
            this.column_upaljen,
            this.column_status,
            this.column_zona,
            this.column_snaga});
            this.listViewlampe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.listViewlampe.HideSelection = false;
            this.listViewlampe.Location = new System.Drawing.Point(12, 12);
            this.listViewlampe.Name = "listViewlampe";
            this.listViewlampe.Size = new System.Drawing.Size(459, 281);
            this.listViewlampe.TabIndex = 1;
            this.listViewlampe.UseCompatibleStateImageBehavior = false;
            this.listViewlampe.View = System.Windows.Forms.View.Details;
            this.listViewlampe.SelectedIndexChanged += new System.EventHandler(this.listViewlampe_SelectedIndexChanged);
            // 
            // column_id
            // 
            this.column_id.Text = "ID";
            this.column_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_id.Width = 44;
            // 
            // column_upaljen
            // 
            this.column_upaljen.Text = "On/Off";
            // 
            // column_status
            // 
            this.column_status.Text = "Status";
            this.column_status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_status.Width = 154;
            // 
            // column_zona
            // 
            this.column_zona.Text = "Zona";
            this.column_zona.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_zona.Width = 57;
            // 
            // column_snaga
            // 
            this.column_snaga.Text = "Snaga%";
            this.column_snaga.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_snaga.Width = 96;
            // 
            // listViewse
            // 
            this.listViewse.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_seid,
            this.column_seupaljen,
            this.column_sestatus,
            this.column_seaktivan,
            this.column_zona_id,
            this.column_sesvjetlo});
            this.listViewse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.listViewse.HideSelection = false;
            this.listViewse.Location = new System.Drawing.Point(488, 12);
            this.listViewse.Name = "listViewse";
            this.listViewse.Size = new System.Drawing.Size(559, 281);
            this.listViewse.TabIndex = 3;
            this.listViewse.UseCompatibleStateImageBehavior = false;
            this.listViewse.View = System.Windows.Forms.View.Details;
            // 
            // column_seid
            // 
            this.column_seid.Text = "ID";
            this.column_seid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_seid.Width = 53;
            // 
            // column_seupaljen
            // 
            this.column_seupaljen.Text = "On/Off";
            this.column_seupaljen.Width = 63;
            // 
            // column_sestatus
            // 
            this.column_sestatus.Text = "Status";
            this.column_sestatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_sestatus.Width = 157;
            // 
            // column_seaktivan
            // 
            this.column_seaktivan.Text = "Aktivan";
            this.column_seaktivan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_seaktivan.Width = 108;
            // 
            // column_zona_id
            // 
            this.column_zona_id.Text = "Zona";
            this.column_zona_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_zona_id.Width = 77;
            // 
            // column_sesvjetlo
            // 
            this.column_sesvjetlo.Text = "Svjetlo";
            this.column_sesvjetlo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.column_sesvjetlo.Width = 70;
            // 
            // buttondodaj
            // 
            this.buttondodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.buttondodaj.Location = new System.Drawing.Point(194, 591);
            this.buttondodaj.Name = "buttondodaj";
            this.buttondodaj.Size = new System.Drawing.Size(145, 59);
            this.buttondodaj.TabIndex = 4;
            this.buttondodaj.Text = "Dodaj";
            this.buttondodaj.UseVisualStyleBackColor = true;
            this.buttondodaj.Click += new System.EventHandler(this.buttondodaj_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 605);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(176, 33);
            this.comboBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(7, 530);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dodaj lampu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(361, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dodaj zonu:";
            // 
            // textBoxdodajzonu
            // 
            this.textBoxdodajzonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.textBoxdodajzonu.Location = new System.Drawing.Point(366, 373);
            this.textBoxdodajzonu.Name = "textBoxdodajzonu";
            this.textBoxdodajzonu.Size = new System.Drawing.Size(176, 32);
            this.textBoxdodajzonu.TabIndex = 8;
            // 
            // buttondodajz
            // 
            this.buttondodajz.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.buttondodajz.Location = new System.Drawing.Point(548, 358);
            this.buttondodajz.Name = "buttondodajz";
            this.buttondodajz.Size = new System.Drawing.Size(145, 59);
            this.buttondodajz.TabIndex = 9;
            this.buttondodajz.Text = "Dodaj";
            this.buttondodajz.UseVisualStyleBackColor = true;
            this.buttondodajz.Click += new System.EventHandler(this.buttondodajz_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(719, 562);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Odaberi zonu kojoj pripada:";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(724, 607);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(176, 33);
            this.comboBox2.TabIndex = 11;
            // 
            // buttondodajse
            // 
            this.buttondodajse.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.buttondodajse.Location = new System.Drawing.Point(906, 593);
            this.buttondodajse.Name = "buttondodajse";
            this.buttondodajse.Size = new System.Drawing.Size(145, 59);
            this.buttondodajse.TabIndex = 10;
            this.buttondodajse.Text = "Dodaj";
            this.buttondodajse.UseVisualStyleBackColor = true;
            this.buttondodajse.Click += new System.EventHandler(this.buttondodajse_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label5.Location = new System.Drawing.Point(719, 536);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 26);
            this.label5.TabIndex = 16;
            this.label5.Text = "Dodaj senzor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label6.Location = new System.Drawing.Point(7, 562);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(277, 26);
            this.label6.TabIndex = 17;
            this.label6.Text = "Odaberi zonu kojoj pripada:";
            // 
            // comboBox4
            // 
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(121, 333);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(93, 33);
            this.comboBox4.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label7.Location = new System.Drawing.Point(32, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 26);
            this.label7.TabIndex = 21;
            this.label7.Text = "ID:";
            // 
            // comboBox5
            // 
            this.comboBox5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "ok",
            "kvar",
            "popravak",
            "Disconnected",
            "Izvanredno"});
            this.comboBox5.Location = new System.Drawing.Point(121, 372);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(195, 33);
            this.comboBox5.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label9.Location = new System.Drawing.Point(32, 379);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 26);
            this.label9.TabIndex = 25;
            this.label9.Text = "Status:";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.radioButton3.Location = new System.Drawing.Point(15, 13);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(59, 30);
            this.radioButton3.TabIndex = 26;
            this.radioButton3.Text = "On";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.radioButton4.Location = new System.Drawing.Point(146, 13);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(59, 30);
            this.radioButton4.TabIndex = 27;
            this.radioButton4.Text = "Off";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.button1.Location = new System.Drawing.Point(48, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 59);
            this.button1.TabIndex = 28;
            this.button1.Text = "UPDATE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(496, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 26);
            this.label4.TabIndex = 13;
            this.label4.Text = "Zone";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(424, 486);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(195, 33);
            this.comboBox3.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label8.Location = new System.Drawing.Point(390, 457);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(271, 26);
            this.label8.TabIndex = 29;
            this.label8.Text = "Izvanredno stanje u zoni";
            // 
            // IzvanrednoON
            // 
            this.IzvanrednoON.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.IzvanrednoON.Location = new System.Drawing.Point(460, 520);
            this.IzvanrednoON.Name = "IzvanrednoON";
            this.IzvanrednoON.Size = new System.Drawing.Size(59, 59);
            this.IzvanrednoON.TabIndex = 30;
            this.IzvanrednoON.Text = "On";
            this.IzvanrednoON.UseVisualStyleBackColor = true;
            this.IzvanrednoON.Click += new System.EventHandler(this.button2_Click);
            // 
            // IzvanrednoOFF
            // 
            this.IzvanrednoOFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.IzvanrednoOFF.Location = new System.Drawing.Point(525, 520);
            this.IzvanrednoOFF.Name = "IzvanrednoOFF";
            this.IzvanrednoOFF.Size = new System.Drawing.Size(59, 59);
            this.IzvanrednoOFF.TabIndex = 31;
            this.IzvanrednoOFF.Text = "Off";
            this.IzvanrednoOFF.UseVisualStyleBackColor = true;
            this.IzvanrednoOFF.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Location = new System.Drawing.Point(48, 411);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 49);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label11.Location = new System.Drawing.Point(844, 304);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 26);
            this.label11.TabIndex = 34;
            this.label11.Text = "Senzor";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.button4.Location = new System.Drawing.Point(774, 440);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(236, 59);
            this.button4.TabIndex = 39;
            this.button4.Text = "UPDATE";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label12.Location = new System.Drawing.Point(747, 383);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 26);
            this.label12.TabIndex = 38;
            this.label12.Text = "Status:";
            // 
            // comboBox6
            // 
            this.comboBox6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "ok",
            "kvar",
            "popravak"});
            this.comboBox6.Location = new System.Drawing.Point(836, 376);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(195, 33);
            this.comboBox6.TabIndex = 37;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label13.Location = new System.Drawing.Point(747, 340);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 26);
            this.label13.TabIndex = 36;
            this.label13.Text = "ID:";
            // 
            // comboBox7
            // 
            this.comboBox7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(836, 337);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(93, 33);
            this.comboBox7.TabIndex = 35;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label14.Location = new System.Drawing.Point(130, 304);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 26);
            this.label14.TabIndex = 41;
            this.label14.Text = "Lampa";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 660);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.IzvanrednoOFF);
            this.Controls.Add(this.IzvanrednoON);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.buttondodajse);
            this.Controls.Add(this.buttondodajz);
            this.Controls.Add(this.textBoxdodajzonu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttondodaj);
            this.Controls.Add(this.listViewse);
            this.Controls.Add(this.listViewlampe);
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_Closing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem seToolStripMenuItem;
        private System.Windows.Forms.ListView listViewlampe;
        private System.Windows.Forms.ColumnHeader column_id;
        private System.Windows.Forms.ColumnHeader column_status;
        private System.Windows.Forms.ColumnHeader column_zona;
        private System.Windows.Forms.ListView listViewse;
        private System.Windows.Forms.ColumnHeader column_seid;
        private System.Windows.Forms.ColumnHeader column_sestatus;
        private System.Windows.Forms.ColumnHeader column_seaktivan;
        private System.Windows.Forms.ColumnHeader column_zona_id;
        private System.Windows.Forms.ColumnHeader column_upaljen;
        private System.Windows.Forms.ColumnHeader column_seupaljen;
        private System.Windows.Forms.ColumnHeader column_snaga;
        private System.Windows.Forms.ColumnHeader column_sesvjetlo;
        private System.Windows.Forms.Button buttondodaj;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxdodajzonu;
        private System.Windows.Forms.Button buttondodajz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button buttondodajse;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button IzvanrednoON;
        private System.Windows.Forms.Button IzvanrednoOFF;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.Label label14;
    }
}