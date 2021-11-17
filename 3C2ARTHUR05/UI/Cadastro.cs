using _3C2ARTHUR05.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3C2ARTHUR05.UI
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var usuario = new _3C2ARTHUR05.BLL.Usuario();
            usuario.Criar(new _3C2ARTHUR05.DTO.Usuario(0, txtNome.Text, txtCpf.Text, txtLogin.Text, txtSenha.Text));
            var obj = new Escolha();
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var obj = new Login();
            obj.Show();
        }
    }
}
