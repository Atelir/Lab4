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


namespace Projekt
{
    public partial class Logowanie : Form
    {

        //SqlCommand checkusers = new SqlCommand("Select * from Pracownicy"); // błedne

        string con = (@"Data Source=ELO420\SQLEXPRESS;Initial Catalog = Delegacje; Integrated Security = True");

        public Logowanie()
        {
            InitializeComponent();
            
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void Logowanie_Load(object sender, EventArgs e)
        {

        }

        public static string Nazwa = "";

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(loginbox.Text))
            {
                MessageBox.Show("Nie wpisano loginu");
            }

            else if (string.IsNullOrWhiteSpace(passbox.Text))
            {
                MessageBox.Show("Nie wpisano hasla");
            }

            else
            {
                
                SqlConnection connect = new SqlConnection(con);
                SqlCommand test = new SqlCommand("Select Imie,Nazwisko, IdStanowiska from Pracownik where Imie=@Imie and Nazwisko=@Pass", connect);
                
                test.Parameters.AddWithValue("@Imie", loginbox.Text);
                test.Parameters.AddWithValue("@Pass", passbox.Text);
                //test.Parameters.AddWithValue("@Stan", 0);
                var user = test.Parameters.ToString();
                connect.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(test);
                DataTable ds = new System.Data.DataTable();
                adapter.Fill(ds);
                connect.Close();
                if (ds.Rows.Count == 1)
                {
                    Nazwa = loginbox.Text + " " + passbox.Text;
                    switch (ds.Rows[0]["IdStanowiska"])
                    {
                        case 0:
                            {
                                Okno okno = new Okno();
                                this.Hide();
                                okno.Show();
                                break;
                            }

                        case 1:
                            {
                                Okno okno = new Okno();
                                this.Hide();
                                okno.Show();
                                break;
                            }
                        case 2:
                            {
                                Okno okno = new Okno();
                                this.Hide();
                                okno.Show();
                                break;
                            }
                        case 3:
                            {
                                this.Hide();
                                PodgladDlaUzytkownika podgladDlaUzytkownika = new PodgladDlaUzytkownika();
                                podgladDlaUzytkownika.Show();
                                break;
                            }
                        case 4:
                            {
                                this.Hide();
                                PodgladDlaUzytkownika podgladDlaUzytkownika = new PodgladDlaUzytkownika();
                                podgladDlaUzytkownika.Show();
                                break;
                            }
                        default:
                            {
                                MessageBox.Show("Niepoprawne dane logowania");
                                break;
                            }
                    }
                    
                }

            }
        }

    }
}
