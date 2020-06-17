using AirSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSystem.Repositories
{
    class UsuarioRepository
    {
        private List<Usuario> Usuarios;

        private int contador = 1;
        public UsuarioRepository()
        {
            // Se ainda não existe nenhum usuário, então crie esse admin por default.
            if (Usuarios == null)
            {
                Usuarios = new List<Usuario>();
                var usuario = new Usuario
                {
                    ID = contador,
                    User = "admin",
                    Nome = "admin",
                    Senha = "1234",
                    Endereco = "rua admin 10",
                    Numero = 987,
                    IsAdmin = true,
                    Nascimento = Convert.ToDateTime("12/02/1998"),
                    Sobrenome = "superman"
                };
                Usuarios.Add(usuario);
                contador++;
            }
        }

        public void AddUser(Usuario user)
        {
            contador += Usuarios.Count();
            user.ID = contador + 1;
            Usuarios.Add(user);
        }

        public List<Usuario> ListarUsers()
        {
            return Usuarios;
        }

        public void DeleteUser(int ID)
        {
            Usuario U = new Usuario();
            U = Usuarios.FirstOrDefault(u => u.ID == ID);
            Usuarios.Remove(U);
        }

        public void UpdateUser(Usuario user)
        {
            Usuario U = new Usuario();
            U = Usuarios.FirstOrDefault(u => u.ID == user.ID);

            U.IsAdmin = user.IsAdmin;
            U.Nome = user.Nome;
            U.Sobrenome = user.Sobrenome;
            U.Nascimento = user.Nascimento;
            U.Senha = user.Senha;
            U.User = user.User;
            U.Numero = user.Numero;
            
        }
    }
}
