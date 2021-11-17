using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3C2ARTHUR05.DTO
{
    public class Usuario
    {
        public Usuario(int id, string nome, string cpf, string login, string senha)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Login = login;
            Senha = senha;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
    }
}
