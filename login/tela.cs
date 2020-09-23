using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class tela : Form
    {
        public tela()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            login novo = new login();
            novo.Show();
            this.Visible = false;
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtemail.Text = "";
            txtnome.Text = "";
        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            string nome, email;
            nome = txtnome.Text;
            email = txtemail.Text;

            if(nome == "teste" && email == "teste@teste.com")
            {
                MessageBox.Show("enviado com sucesso");
            }
            else
            {
                MessageBox.Show("Nome ou email incorretos");
            }
        }
    }
}
