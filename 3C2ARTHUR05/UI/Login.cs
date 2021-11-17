using _3C2ARTHUR05.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3C2ARTHUR05.View
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {

            var usuario = new _3C2ARTHUR05.BLL.Usuario();
            if (usuario.Login(txtLogin.Text, txtSenha.Text))
            {
                var obj = new Escolha();
                obj.Show();
            }
            else
            {
                MessageBox.Show("Usuario ou senha estão incorretos");
            }
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            var obj = new Cadastro();
            obj.Show();
        }
    }
}
