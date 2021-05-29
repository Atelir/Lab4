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
    public partial class DelegationControl : Form
    {
        static string con = (@"Data Source=ELO420\SQLEXPRESS;Initial Catalog = Delegacje; Integrated Security = True");
        SqlConnection connect = new SqlConnection(con);
        SqlCommand sql;
        SqlCommand sql1;
        public DelegationControl()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
        //Czyszczenie textboxow
        void ClearParmts()
        {

            Imie.Text = "";
            Nazwisko.Text = "";
            Miejscowosc.Text = "";
            KodPocztowy.Text = "";
            Kraj.Text = "";
            Ulica.Text = "";
        }
        //Zapisanie nowej delegacji
        private void button1_Click(object sender, EventArgs e) //Dodanie
        {
            try
            {

            
            DialogResult result = MessageBox.Show("Czy chcesz zapisać ten wpis?", "Zapisać ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                connect.Open();
                //Sprawdzenie czy podany adres znajduje sie w naszej bazie
                sql = new SqlCommand("select IdLokalizacji,Miejscowosc,Ulica,KodPocztowy, Kraj from Lokalizacja WHERE Miejscowosc = '"+Miejscowosc.Text+"' AND Ulica='"+Ulica.Text+"' AND KodPocztowy='"+KodPocztowy.Text+"' AND Kraj='"+Kraj.Text+"'",connect);
                SqlDataAdapter adap = new SqlDataAdapter(sql);
                DataSet dt = new DataSet();
                adap.Fill(dt);
                if (dt.Tables[0].Rows.Count == 1)
                {

                    MessageBox.Show("Ten adres już istnieje w bazie");

                }
                else
                {
                    //Wpisanie nowego adresu
                    SqlCommand sql2 = new SqlCommand("insert into Lokalizacja (Miejscowosc,Ulica,KodPocztowy, Kraj) values ('"+Miejscowosc.Text+"', '"+Ulica.Text+"','"+KodPocztowy.Text+"', '"+Kraj.Text+"')",connect);
                    sql2.ExecuteNonQuery();
                    SqlDataAdapter adap1 = new SqlDataAdapter(sql);
                    DataSet dt2 = new DataSet();
                    adap1.Fill(dt2);

                    //Wyszukanie idpracownika na bazie wpisanego imienia i nazwiska
                    string txtIdLokalizacji = dt2.Tables[0].Rows[0]["IdLokalizacji"].ToString();
                    sql1 = new SqlCommand("select IdPracownika from Pracownik where Imie = '" + Imie.Text + "' AND Nazwisko = '" + Nazwisko.Text + "'", connect);
                    SqlDataAdapter adapter = new SqlDataAdapter(sql1);
                    DataSet dt1 = new DataSet();
                    adapter.Fill(dt1);
                    if (dt1.Tables[0].Rows.Count == 1)
                    {
                        //Wpisanie do tabeli delagacja podanych parametrow
                        string txtIdPracownika = dt1.Tables[0].Rows[0]["IdPracownika"].ToString();
                        sql = new SqlCommand("insert into Delegacja (IdPracownika,IdLokalizacji,StatusDelegacji,DataWyjazdu) values ('" + txtIdPracownika + "','" + txtIdLokalizacji + "',1,'" + DataWyjazdu.Value.ToString("yyyy-MM-dd") + "')", connect);
                        sql.ExecuteNonQuery();
                    }
                }
                    //Wyswietlenie aktualnych delegacji w datagrid
                    SqlDataAdapter da = new SqlDataAdapter("select d.IdDelegacji,p.Imie,p.Nazwisko,l.ULica,l.Miejscowosc,l.KodPocztowy,l.Kraj,d.DataWyjazdu from Delegacja d inner join Lokalizacja l on d.IdLokalizacji=l.IdLokalizacji INNER join Pracownik p on d.IdPracownika=p.IdPracownika where StatusDelegacji = 1;", connect);
                    DataTable dt3 = new DataTable();
                    da.Fill(dt3);
                    PodgladDelegacje.DataSource = dt3;

                    connect.Close();
                ClearParmts();
                MessageBox.Show("Zapisano pomyślnie");

            }

            }
            catch (Exception x) 
            {
            MessageBox.Show(x.ToString(), "Wiadomość", MessageBoxButtons.OK, MessageBoxIcon.Error);   
            }
    }

        //Zmiana statusu delegacji
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                connect.Open();
                sql = new SqlCommand("select d.IdDelegacji,d.DataWyjazdu,l.Miejscowosc,l.Kraj,l.Ulica,l.KodPocztowy,p.Imie,p.Nazwisko from Delegacja d inner join Pracownik p on d.IdPracownika=p.IdPracownika inner join Lokalizacja l on d.IdLokalizacji=l.IdLokalizacji where d.DataWyjazdu='"+DataWyjazdu.Value.ToString("yyyy-MM-dd") +"' AND l.Miejscowosc='"+Miejscowosc.Text+"' AND l.Kraj='"+Kraj.Text+"' AND l.Ulica='"+Ulica.Text+"' AND l.KodPocztowy='"+KodPocztowy.Text+"' AND p.Imie='"+Imie.Text+"' AND p.Nazwisko='"+Nazwisko.Text+"'", connect);
                SqlDataAdapter adapter = new SqlDataAdapter(sql);
                DataSet dt = new DataSet();
                adapter.Fill(dt);
                if (dt.Tables[0].Rows.Count == 1)
                {
                    string txtIdDelegacji = dt.Tables[0].Rows[0]["IdDelegacji"].ToString();
                    sql1 = new SqlCommand("update Delegacja set StatusDelegacji=0 WHERE IdDelegacji= '" + txtIdDelegacji + "'", connect);
                    sql1.ExecuteNonQuery();
                }
                ClearParmts();
            
                connect.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString(), "Wiadomość", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Podglad aktualnych delegacji
        private void Podglad_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(con);
            connect.Open();
            SqlDataAdapter da = new SqlDataAdapter("select d.IdDelegacji,p.Imie,p.Nazwisko,l.ULica,l.Miejscowosc,l.KodPocztowy,l.Kraj,d.DataWyjazdu from Delegacja d inner join Lokalizacja l on d.IdLokalizacji=l.IdLokalizacji INNER join Pracownik p on d.IdPracownika=p.IdPracownika where StatusDelegacji = 1;", connect);
            DataTable dt = new DataTable();
            da.Fill(dt);
            PodgladDelegacje.DataSource = dt;
            connect.Close();
        }

        private void Wróć_Click(object sender, EventArgs e)
        {
            Okno okno = new Okno();
            this.Hide();
            okno.Show();
        }

        private void DelegationControl_Load(object sender, EventArgs e)
        {

        }
    }
}
