
namespace Projekt
{
    partial class Okno
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
            this.Nazwa = new System.Windows.Forms.Label();
            this.Wyloguj = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Podglad = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Podglad)).BeginInit();
            this.SuspendLayout();
            // 
            // Nazwa
            // 
            this.Nazwa.AutoSize = true;
            this.Nazwa.Location = new System.Drawing.Point(23, 23);
            this.Nazwa.Name = "Nazwa";
            this.Nazwa.Size = new System.Drawing.Size(30, 15);
            this.Nazwa.TabIndex = 0;
            this.Nazwa.Text = "Imie";
            this.Nazwa.Click += new System.EventHandler(this.label1_Click);
            // 
            // Wyloguj
            // 
            this.Wyloguj.Location = new System.Drawing.Point(860, 15);
            this.Wyloguj.Name = "Wyloguj";
            this.Wyloguj.Size = new System.Drawing.Size(75, 23);
            this.Wyloguj.TabIndex = 1;
            this.Wyloguj.Text = "Wyloguj";
            this.Wyloguj.UseVisualStyleBackColor = true;
            this.Wyloguj.Click += new System.EventHandler(this.Wyloguj_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Dodaj delegacje";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(120, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Edytuj delegacje";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(120, 172);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Wyświetl delegacje";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(120, 120);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(163, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Wyświetl użytkowników";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Podglad
            // 
            this.Podglad.AllowUserToAddRows = false;
            this.Podglad.AllowUserToDeleteRows = false;
            this.Podglad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Podglad.Location = new System.Drawing.Point(371, 102);
            this.Podglad.Name = "Podglad";
            this.Podglad.ReadOnly = true;
            this.Podglad.RowTemplate.Height = 25;
            this.Podglad.Size = new System.Drawing.Size(526, 237);
            this.Podglad.TabIndex = 6;
            // 
            // Okno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 450);
            this.Controls.Add(this.Podglad);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Wyloguj);
            this.Controls.Add(this.Nazwa);
            this.Name = "Okno";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Okno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Podglad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nazwa;
        private System.Windows.Forms.Button Wyloguj;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView Podglad;
    }
}