﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Projekt
{
    public partial class PodgladDlaUzytkownika : Form
    {
        public PodgladDlaUzytkownika()
        {
            InitializeComponent();
        }

        private void PodgladDlaUzytkownika_Load(object sender, EventArgs e)
        {
            Nazwa.Text = Logowanie.Nazwa;
        }
        string con = (@"Data Source=ELO420\SQLEXPRESS;Initial Catalog = Delegacje; Integrated Security = True");


        private void button3_Click_1(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(con);
            connect.Open();
            SqlDataAdapter da = new SqlDataAdapter("select p.Imie,p.Nazwisko,l.Kraj from Delegacja d inner join Lokalizacja l on d.IdLokalizacji=l.IdLokalizacji INNER join Pracownik p on d.IdPracownika=p.IdPracownika where StatusDelegacji = 1;", connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Podglad.DataSource = dt;
            connect.Close();
        }

        private void Wyloguj_Click_1(object sender, EventArgs e)
        {
            Logowanie logowanie = new Logowanie();
            this.Hide();
            logowanie.Show();
        }

        private void Nazwa_Click(object sender, EventArgs e)
        {

        }
    }
}
