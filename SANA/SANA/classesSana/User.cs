using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SANA.classesSana
{
    internal class User
    {
        private string nome;
        private string password;
        private string matricula;

        public string Nome { get => nome; set => nome = value; }
        public string Password { get => password; set => password = value; }
        public string Matricula { get => matricula; set => matricula = value; }

        public User(string nome, string password, string matricula)
        {
            Nome = nome;
            Password = password;
            Matricula = matricula;
        }

        public User()
        {
        }
    }
}
