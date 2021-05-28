
namespace Projekt
{
    partial class PodgladDlaUzytkownika
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
            this.Podglad = new System.Windows.Forms.DataGridView();
            this.Nazwa = new System.Windows.Forms.Label();
            this.Wyloguj = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Podglad)).BeginInit();
            this.SuspendLayout();
            // 
            // Podglad
            // 
            this.Podglad.AllowUserToAddRows = false;
            this.Podglad.AllowUserToDeleteRows = false;
            this.Podglad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Podglad.Location = new System.Drawing.Point(307, 125);
            this.Podglad.Name = "Podglad";
            this.Podglad.ReadOnly = true;
            this.Podglad.RowTemplate.Height = 25;
            this.Podglad.Size = new System.Drawing.Size(450, 237);
            this.Podglad.TabIndex = 7;
            // 
            // Nazwa
            // 
            this.Nazwa.AutoSize = true;
            this.Nazwa.Location = new System.Drawing.Point(24, 33);
            this.Nazwa.Name = "Nazwa";
            this.Nazwa.Size = new System.Drawing.Size(30, 15);
            this.Nazwa.TabIndex = 8;
            this.Nazwa.Text = "Imie";
            this.Nazwa.Click += new System.EventHandler(this.Nazwa_Click);
            // 
            // Wyloguj
            // 
            this.Wyloguj.Location = new System.Drawing.Point(699, 25);
            this.Wyloguj.Name = "Wyloguj";
            this.Wyloguj.Size = new System.Drawing.Size(75, 23);
            this.Wyloguj.TabIndex = 9;
            this.Wyloguj.Text = "Wyloguj";
            this.Wyloguj.UseVisualStyleBackColor = true;
            this.Wyloguj.Click += new System.EventHandler(this.Wyloguj_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(120, 152);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(163, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Wyświetl delegacje";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // PodgladDlaUzytkownika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Wyloguj);
            this.Controls.Add(this.Nazwa);
            this.Controls.Add(this.Podglad);
            this.Name = "PodgladDlaUzytkownika";
            this.Text = "PodgladDlaUzytkownika";
            this.Load += new System.EventHandler(this.PodgladDlaUzytkownika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Podglad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Podglad;
        private System.Windows.Forms.Label Nazwa;
        private System.Windows.Forms.Button Wyloguj;
        private System.Windows.Forms.Button button3;
    }
}