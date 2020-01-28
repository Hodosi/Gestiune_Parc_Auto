using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Good_Food
{
    public partial class Creare_cont_client : Form
    {
        public Creare_cont_client()
        {
            InitializeComponent();
        }
            CLIENT client=new CLIENT();

        private void Creare_cont_client_Load(object sender, EventArgs e)
        {
            string fn = Application.StartupPath + @"\Resurse_C#\Reclama.jpg";
            this.pictureBox1.Image = Image.FromFile(fn);
        }

        private void button_CreareCont_Click(object sender, EventArgs e)
        {
            string nume = this.textBox_Nume.Text;
            string pass = this.textBox_Parola.Text;
            string prenume = this.textBox_Prenume.Text;
            string address = this.textBox_Adresa.Text;
            string email=this.textBox_email.Text;
            string confirm_pass = this.textBox_Parola_Confirm.Text;

            if (pass != confirm_pass)
            {
                MessageBox.Show("diff pass!");
            }
            else if (client.emailExists(email))
            {
                MessageBox.Show("email exist!");
                this.textBox_Nume.ResetText();
                this.textBox_Parola.ResetText();
                this.textBox_Prenume.ResetText();
                this.textBox_Adresa.ResetText();
                this.textBox_email.ResetText();
                this.textBox_Parola_Confirm.ResetText();

            }
            else
            {
                client.insertClient(nume, prenume, pass, address, email);
                MessageBox.Show("client added!");
            }

        }
    }
}
