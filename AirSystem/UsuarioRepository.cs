using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSystem
{
    class UsuarioRepository
    {
        private static List<Usuario> usuarios;

        private static int contador = 1;

        public UsuarioRepository()
        {
            if(usuarios == null)
            {
                usuarios = new List<Usuario>();

                usuarios.Add(new Usuario
                {
                    ID = 1,
                    nome = "Gabriel",
                    sobrenome = "de Souza",
                    endereco = "Rua dos anjos",
                    nascimento = Convert.ToDateTime(09/01/2002),
                    numero = 6,
                    usuario = "Void",
                    senha = "Uau18dnv",
                    confirmarSenha = "Uau18dnv"
                });

                contador++;

                usuarios.Add(new Usuario
                {
                    ID = 2,
                    nome = "Metatron",
                    sobrenome = "Avalos",
                    endereco = "Haled",
                    nascimento = Convert.ToDateTime(09/01/1970),
                    numero = 66,
                    usuario = "Supremo",
                    senha = "Eden00hj",
                    confirmarSenha = "Eden00hj"
                });
            }
        }

        public List<Usuario> buscarTodos()
        {
            return usuarios;
        }

        public void adicionar(Usuario usuario)
        {
            usuario.ID = contador;

            usuarios.Add(usuario);
            contador++;
        }

        public void editar(Usuario usuario)
        {
            Usuario u = usuarios.Find(x => x.ID == usuario.ID);
            usuarios[usuarios.IndexOf(u)] = usuario;
        }

        public void deletar(int ID)
        {
            // recupero o usuário atraves do código
            Usuario usuario = usuarios.Find(x => x.ID == ID);

            // removo o usuário da lista;
            usuarios.Remove(usuario);
        }
    }
}
