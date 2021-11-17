using System.Data;

namespace _3C2ARTHUR05.BLL
{
    public class Produto
    {
        public Conexao con = new Conexao();

        public void Criar(_3C2ARTHUR05.DTO.Produto produto)
        {
            con.ExecutarComando($"INSERT INTO `produtos`(`codigo`, `nome`, `categoria`, `preco`, `fornecedor`) VALUES (null,'{produto.Nome}','{produto.Categoria}','{produto.Preco}','{produto.Fornecedor}')");
        }

        public DataTable Listar()
        {
            return con.ExecutarConsulta("SELECT * FROM `produtos`");
        }

        public void Editar(_3C2ARTHUR05.DTO.Produto produto)
        {
            con.ExecutarComando($"UPDATE `produtos` SET `nome`='{produto.Nome}',`categoria`='{produto.Categoria}',`preco`='{produto.Preco}',`fornecedor`='{produto.Fornecedor}' WHERE `Codigo`='{produto.Id}'");
        }

        public void Deletar(string id)
        {
            con.ExecutarComando($"DELETE FROM `produtos` WHERE `codigo`='{id}'");
        }
    }
}
