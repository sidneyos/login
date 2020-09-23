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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            string usuario, senha;
            usuario = txtusuario.Text;
            senha = txtsenha.Text;

            if (usuario == "admin" && senha == "123")
            {
                tela novo = new tela();
                novo.Show();
                this.Visible = false;

                /*Declaração de variáveis e atribuição Condição - Se o usuário e (&&) Senha forem iguais a Admin, 
                 * Será chamado o Form2. Ou seja ele terá acesso ao sistema, somente se o usuário e senha estiver correto*/
            }
            else
            {
                MessageBox.Show("login ou senha incorretos");
            }
        }
    }
}
