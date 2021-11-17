using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3C2ARTHUR05.DTO
{
    public class Produto
    {
        public Produto(int id, string nome, string categoria, double preco, string fornecedor)
        {
            Id = id;
            Nome = nome;
            Categoria = categoria;
            Preco = preco;
            Fornecedor = fornecedor;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public double Preco { get; set; }
        public string Fornecedor { get; set; }
    }
}
