using System;
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
    public partial class Okno : Form
    {
        public Okno()
        {
            InitializeComponent();
            
        }

        string con = (@"Data Source=ELO420\SQLEXPRESS;Initial Catalog = Delegacje; Integrated Security = True");


        private void Okno_Load(object sender, EventArgs e)
        {
            Nazwa.Text = Logowanie.Nazwa;
        }

        private void label1_Click(object sender, EventArgs e)
        {

            

        }

        private void Wyloguj_Click(object sender, EventArgs e)
        {
            Logowanie logowanie = new Logowanie();
            this.Hide();
            logowanie.Show();

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Podglad_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            SqlConnection connect = new SqlConnection(con);
            //SqlCommand czytaj = new SqlCommand("select d.StatusDelegacji,p.Imie,p.Nazwisko from Delegacja d INNER join Pracownik p on d.IdPracownika=p.IdPracownika", connect);

            connect.Open();
            SqlDataAdapter da = new SqlDataAdapter("select Imie,Nazwisko, Plec,Email,s.Nazwa from Pracownik p inner join stanowisko s on p.IdStanowiska=s.IdStanowiska", connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Podglad.DataSource = dt;

            connect.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(con);
            connect.Open();
            SqlDataAdapter da = new SqlDataAdapter("select p.Imie,p.Nazwisko,l.Kraj from Delegacja d inner join Lokalizacja l on d.IdLokalizacji=l.IdLokalizacji INNER join Pracownik p on d.IdPracownika=p.IdPracownika where StatusDelegacji = 1;", connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            Podglad.DataSource = dt;
            connect.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DelegationControl delegationControl = new DelegationControl();
            this.Hide();
            delegationControl.Show();

        }
    }
}
