using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Good_Food
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        //CONNECT conn = new CONNECT();

        private void Form1_Load(object sender, EventArgs e)
        { 

            string fn = Application.StartupPath + @"\Resurse_C#\Reclama.jpg";
            this.pictureBox1.Image = Image.FromFile(fn);
        }

        private void button_Inregistrare_Click(object sender, EventArgs e)
        {
            Creare_cont_client cl=new Creare_cont_client();
            cl.ShowDialog();
        }

        private void button_Autentificare_Click(object sender, EventArgs e)
        {
            Autentificare_client aut = new Autentificare_client();
            aut.ShowDialog();
        }


    }
}
