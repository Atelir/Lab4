using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Zadanie5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Login_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ZgodaRodo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Zarejestruj_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(Login.Text))
            {
                MessageBox.Show("Nie wpisano loginu");
            }

            else if (string.IsNullOrWhiteSpace(Haslo.Text))
            {
                MessageBox.Show("Nie wpisano hasla");
            }

            else if (string.IsNullOrWhiteSpace(PowtorzHaslo.Text))
            {
                MessageBox.Show("Powtorz haslo");

                if (Haslo.Text != PowtorzHaslo.Text)
                {
                    MessageBox.Show("Hasla musza się zgadzać");
                }
            }

            else if (!ZgodaRodo.Checked){

                MessageBox.Show("Zaznacz zgodę Rodo");
            }

            else
            {
                User user = new User(Login.Text, Haslo.Text);
                User.AddUserToList(user);

                MessageBox.Show("Zarejestrowano się poprawnie");

            }
            

        }

        private void Zaloguj_Click(object sender, EventArgs e)
        {

            if(User.Users.Exists(x => x.Login == Login1.Text && x.Haslo == Haslo1.Text))

            {
                MessageBox.Show("Zalogowano sie poprawnie");

            }
            else
            {
                MessageBox.Show("Podano nie poprawne dane");
            }


        }
    }
}
