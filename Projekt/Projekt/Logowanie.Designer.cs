
namespace Projekt
{
    partial class Logowanie
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginbox = new System.Windows.Forms.TextBox();
            this.passbox = new System.Windows.Forms.TextBox();
            this.logbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hasło:";
            // 
            // loginbox
            // 
            this.loginbox.Location = new System.Drawing.Point(218, 102);
            this.loginbox.Name = "loginbox";
            this.loginbox.Size = new System.Drawing.Size(100, 23);
            this.loginbox.TabIndex = 2;
            this.loginbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // passbox
            // 
            this.passbox.Location = new System.Drawing.Point(218, 140);
            this.passbox.Name = "passbox";
            this.passbox.Size = new System.Drawing.Size(100, 23);
            this.passbox.TabIndex = 3;
            this.passbox.UseSystemPasswordChar = true;
            this.passbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // logbutton
            // 
            this.logbutton.Location = new System.Drawing.Point(218, 183);
            this.logbutton.Name = "logbutton";
            this.logbutton.Size = new System.Drawing.Size(75, 23);
            this.logbutton.TabIndex = 4;
            this.logbutton.Text = "Zaloguj";
            this.logbutton.UseVisualStyleBackColor = true;
            this.logbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Logowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 328);
            this.Controls.Add(this.logbutton);
            this.Controls.Add(this.passbox);
            this.Controls.Add(this.loginbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Logowanie";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Logowanie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loginbox;
        private System.Windows.Forms.TextBox passbox;
        private System.Windows.Forms.Button logbutton;
    }
}

