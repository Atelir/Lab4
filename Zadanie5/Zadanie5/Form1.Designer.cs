
namespace Zadanie5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Login = new System.Windows.Forms.TextBox();
            this.PowtorzHaslo = new System.Windows.Forms.TextBox();
            this.ZgodaRodo = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Haslo = new System.Windows.Forms.TextBox();
            this.Zarejestruj = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Login1 = new System.Windows.Forms.TextBox();
            this.Haslo1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Zaloguj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(102, 63);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(100, 23);
            this.Login.TabIndex = 0;
            this.Login.Tag = "";
            this.Login.TextChanged += new System.EventHandler(this.Login_TextChanged);
            // 
            // PowtorzHaslo
            // 
            this.PowtorzHaslo.Location = new System.Drawing.Point(102, 164);
            this.PowtorzHaslo.Name = "PowtorzHaslo";
            this.PowtorzHaslo.Size = new System.Drawing.Size(100, 23);
            this.PowtorzHaslo.TabIndex = 2;
            this.PowtorzHaslo.UseSystemPasswordChar = true;
            // 
            // ZgodaRodo
            // 
            this.ZgodaRodo.AutoSize = true;
            this.ZgodaRodo.Location = new System.Drawing.Point(102, 216);
            this.ZgodaRodo.Name = "ZgodaRodo";
            this.ZgodaRodo.Size = new System.Drawing.Size(91, 19);
            this.ZgodaRodo.TabIndex = 3;
            this.ZgodaRodo.Text = "Zgoda Rodo\r\n";
            this.ZgodaRodo.UseVisualStyleBackColor = true;
            this.ZgodaRodo.CheckedChanged += new System.EventHandler(this.ZgodaRodo_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hasło:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Powtórz hasło:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(74, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Rejestracja";
            // 
            // Haslo
            // 
            this.Haslo.Location = new System.Drawing.Point(102, 115);
            this.Haslo.Name = "Haslo";
            this.Haslo.Size = new System.Drawing.Size(100, 23);
            this.Haslo.TabIndex = 8;
            this.Haslo.UseSystemPasswordChar = true;
            this.Haslo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Zarejestruj
            // 
            this.Zarejestruj.Location = new System.Drawing.Point(102, 262);
            this.Zarejestruj.Name = "Zarejestruj";
            this.Zarejestruj.Size = new System.Drawing.Size(75, 23);
            this.Zarejestruj.TabIndex = 9;
            this.Zarejestruj.Text = "Zarejestruj";
            this.Zarejestruj.UseVisualStyleBackColor = true;
            this.Zarejestruj.Click += new System.EventHandler(this.Zarejestruj_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(469, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Zaloguj";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(420, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Login:";
            // 
            // Login1
            // 
            this.Login1.Location = new System.Drawing.Point(485, 68);
            this.Login1.Name = "Login1";
            this.Login1.Size = new System.Drawing.Size(100, 23);
            this.Login1.TabIndex = 12;
            this.Login1.Tag = "";
            // 
            // Haslo1
            // 
            this.Haslo1.Location = new System.Drawing.Point(485, 120);
            this.Haslo1.Name = "Haslo1";
            this.Haslo1.Size = new System.Drawing.Size(100, 23);
            this.Haslo1.TabIndex = 13;
            this.Haslo1.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(420, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Hasło:";
            // 
            // Zaloguj
            // 
            this.Zaloguj.Location = new System.Drawing.Point(485, 172);
            this.Zaloguj.Name = "Zaloguj";
            this.Zaloguj.Size = new System.Drawing.Size(75, 23);
            this.Zaloguj.TabIndex = 15;
            this.Zaloguj.Text = "Zaloguj";
            this.Zaloguj.UseVisualStyleBackColor = true;
            this.Zaloguj.Click += new System.EventHandler(this.Zaloguj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Zaloguj);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Haslo1);
            this.Controls.Add(this.Login1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Zarejestruj);
            this.Controls.Add(this.Haslo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ZgodaRodo);
            this.Controls.Add(this.PowtorzHaslo);
            this.Controls.Add(this.Login);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox PowtorzHaslo;
        private System.Windows.Forms.CheckBox ZgodaRodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Haslo;
        private System.Windows.Forms.Button Zarejestruj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Login1;
        private System.Windows.Forms.TextBox Haslo1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Zaloguj;
    }
}

