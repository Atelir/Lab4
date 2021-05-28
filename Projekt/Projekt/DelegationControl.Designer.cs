
namespace Projekt
{
    partial class DelegationControl
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
            this.PodgladDelegacje = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Imie = new System.Windows.Forms.TextBox();
            this.Nazwisko = new System.Windows.Forms.TextBox();
            this.Miejscowosc = new System.Windows.Forms.TextBox();
            this.KodPocztowy = new System.Windows.Forms.TextBox();
            this.Kraj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DataWyjazdu = new System.Windows.Forms.DateTimePicker();
            this.Ulica = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Podglad = new System.Windows.Forms.Button();
            this.Wróć = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PodgladDelegacje)).BeginInit();
            this.SuspendLayout();
            // 
            // PodgladDelegacje
            // 
            this.PodgladDelegacje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PodgladDelegacje.Location = new System.Drawing.Point(26, 270);
            this.PodgladDelegacje.Name = "PodgladDelegacje";
            this.PodgladDelegacje.RowTemplate.Height = 25;
            this.PodgladDelegacje.Size = new System.Drawing.Size(737, 220);
            this.PodgladDelegacje.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(250, 238);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Usuń";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Imie
            // 
            this.Imie.Location = new System.Drawing.Point(98, 35);
            this.Imie.Name = "Imie";
            this.Imie.Size = new System.Drawing.Size(100, 23);
            this.Imie.TabIndex = 5;
            // 
            // Nazwisko
            // 
            this.Nazwisko.Location = new System.Drawing.Point(98, 64);
            this.Nazwisko.Name = "Nazwisko";
            this.Nazwisko.Size = new System.Drawing.Size(100, 23);
            this.Nazwisko.TabIndex = 6;
            // 
            // Miejscowosc
            // 
            this.Miejscowosc.Location = new System.Drawing.Point(98, 93);
            this.Miejscowosc.Name = "Miejscowosc";
            this.Miejscowosc.Size = new System.Drawing.Size(100, 23);
            this.Miejscowosc.TabIndex = 7;
            // 
            // KodPocztowy
            // 
            this.KodPocztowy.Location = new System.Drawing.Point(98, 122);
            this.KodPocztowy.Name = "KodPocztowy";
            this.KodPocztowy.Size = new System.Drawing.Size(100, 23);
            this.KodPocztowy.TabIndex = 8;
            // 
            // Kraj
            // 
            this.Kraj.Location = new System.Drawing.Point(98, 151);
            this.Kraj.Name = "Kraj";
            this.Kraj.Size = new System.Drawing.Size(100, 23);
            this.Kraj.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Imie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nazwisko";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Miejscowosc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Kod pocztowy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Kraj";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "DataWyjazdu";
            // 
            // DataWyjazdu
            // 
            this.DataWyjazdu.CustomFormat = "yyyy-MM-dd";
            this.DataWyjazdu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DataWyjazdu.Location = new System.Drawing.Point(98, 180);
            this.DataWyjazdu.Name = "DataWyjazdu";
            this.DataWyjazdu.Size = new System.Drawing.Size(137, 23);
            this.DataWyjazdu.TabIndex = 18;
            this.DataWyjazdu.Value = new System.DateTime(2021, 5, 28, 19, 1, 23, 0);
            // 
            // Ulica
            // 
            this.Ulica.Location = new System.Drawing.Point(98, 209);
            this.Ulica.Name = "Ulica";
            this.Ulica.Size = new System.Drawing.Size(100, 23);
            this.Ulica.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "Ulica";
            // 
            // Podglad
            // 
            this.Podglad.Location = new System.Drawing.Point(331, 238);
            this.Podglad.Name = "Podglad";
            this.Podglad.Size = new System.Drawing.Size(75, 23);
            this.Podglad.TabIndex = 21;
            this.Podglad.Text = "Podglad";
            this.Podglad.UseVisualStyleBackColor = true;
            this.Podglad.Click += new System.EventHandler(this.Podglad_Click);
            // 
            // Wróć
            // 
            this.Wróć.Location = new System.Drawing.Point(713, 7);
            this.Wróć.Name = "Wróć";
            this.Wróć.Size = new System.Drawing.Size(75, 23);
            this.Wróć.TabIndex = 22;
            this.Wróć.Text = "Wróć";
            this.Wróć.UseVisualStyleBackColor = true;
            this.Wróć.Click += new System.EventHandler(this.Wróć_Click);
            // 
            // DelegationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 502);
            this.Controls.Add(this.Wróć);
            this.Controls.Add(this.Podglad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Ulica);
            this.Controls.Add(this.DataWyjazdu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Kraj);
            this.Controls.Add(this.KodPocztowy);
            this.Controls.Add(this.Miejscowosc);
            this.Controls.Add(this.Nazwisko);
            this.Controls.Add(this.Imie);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PodgladDelegacje);
            this.Name = "DelegationControl";
            this.Text = "DelegationControl";
            ((System.ComponentModel.ISupportInitialize)(this.PodgladDelegacje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PodgladDelegacje;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox Imie;
        private System.Windows.Forms.TextBox Nazwisko;
        private System.Windows.Forms.TextBox Miejscowosc;
        private System.Windows.Forms.TextBox KodPocztowy;
        private System.Windows.Forms.TextBox Kraj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DataWyjazdu;
        private System.Windows.Forms.TextBox Ulica;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Podglad;
        private System.Windows.Forms.Button Wróć;
    }
}