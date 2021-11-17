using System;
using System.Windows.Forms;

namespace _3C2ARTHUR05.View
{
    public partial class ProdutsUI : Form
    {
        public ProdutsUI()
        {
            InitializeComponent();
        }

        public _3C2ARTHUR05.BLL.Produto produtoBll = new _3C2ARTHUR05.BLL.Produto();

        private void btnEdit_Click(object sender, EventArgs e)
        {
            produtoBll.Editar(new _3C2ARTHUR05.DTO.Produto(string.IsNullOrEmpty(txtCodigo.Text) ? 0 : int.Parse(txtCodigo.Text), txtNome.Text, txtCategoria.Text, Decimal.ToDouble(txtPreco.Value), txtFornecedor.Text));
            listar();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            produtoBll.Criar(new _3C2ARTHUR05.DTO.Produto(0, txtNome.Text, txtCategoria.Text, Decimal.ToDouble(txtPreco.Value), txtFornecedor.Text));
            listar();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            produtoBll.Deletar(txtCodigo.Text);
            listar();
        }

        public void listar()
        {
            dataGridView1.DataSource = produtoBll.Listar();
        }

        private void ProdutsUI_Load(object sender, EventArgs e)
        {
            listar();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtNome.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtCategoria.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtPreco.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtFornecedor.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }
    }
}
