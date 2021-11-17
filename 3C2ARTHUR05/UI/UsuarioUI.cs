using System;
using System.Windows.Forms;

namespace _3C2ARTHUR05.View
{
    public partial class UsuarioUI : Form
    {
        public UsuarioUI()
        {
            InitializeComponent();
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        public _3C2ARTHUR05.BLL.Usuario usuarioBll = new _3C2ARTHUR05.BLL.Usuario();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            usuarioBll.Criar(new _3C2ARTHUR05.DTO.Usuario(0, txtNome.Text, txtLogin.Text,txtSenha.Text, txtCpf.Text));
            listar();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            usuarioBll.Editar(new _3C2ARTHUR05.DTO.Usuario(string.IsNullOrEmpty(txtId.Text) ? 0 : int.Parse(txtId.Text), txtNome.Text, txtLogin.Text, txtSenha.Text ,txtCpf.Text));
            listar();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            usuarioBll.Deletar(txtId.Text);
            listar();
        }

        private void UsuarioUI_Load(object sender, EventArgs e)
        {
            listar();
        }
        public void listar()
        {
            dataGridView1.DataSource = usuarioBll.Listar();
        }
    }
}
