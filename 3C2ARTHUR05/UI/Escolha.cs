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
    public partial class Escolha : Form
    {
        public Escolha()
        {
            InitializeComponent();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            var obj = new UsuarioUI();
            obj.Show();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            var obj = new ProdutsUI();
            obj.Show();
        }
    }
}
