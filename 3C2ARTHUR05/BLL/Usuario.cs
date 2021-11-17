using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3C2ARTHUR05.BLL
{
    public class Usuario
    {
        public Conexao con = new Conexao();

        public bool Login(string login, string senha)
        {
            var usuarios = con.ExecutarConsulta($"SELECT * FROM `usuarios` WHERE `Login` = '{login}' AND `Senha` = '{senha}'").Rows.Count;
            return usuarios > 0 ? true : false;
        }

        public void Criar(_3C2ARTHUR05.DTO.Usuario usuario)
        {
            con.ExecutarComando($"INSERT INTO `usuarios`(`id`, `login`, `nome`, `senha`, `cpf`) VALUES (null,'{usuario.Id}','{usuario.Nome}','{usuario.Senha}','{usuario.Cpf}')");
        }

        public DataTable Listar()
        {
            return con.ExecutarConsulta("SELECT * FROM `usuarios`");
        }

        public void Editar(_3C2ARTHUR05.DTO.Usuario usuario)
        {
            con.ExecutarComando($"UPDATE `usuarios` SET `id`='{usuario.Id}',`nome`='{usuario.Nome}',`senha`='{usuario.Senha}',`cpf`='{usuario.Cpf}' WHERE `codigo` = {usuario.Id}");
        }

        public void Deletar(string id)
        {
            con.ExecutarComando($"DELETE FROM `usuarios` WHERE `Codigo`='{id}'");
        }

    }
}
