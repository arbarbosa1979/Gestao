using System.Collections.Generic;
using DAL;
using Models;

namespace BLL
{
    public class GrupoUsuarioBLL
    {
        private GrupoUsuarioDAL grupoUsuarioDAL = new GrupoUsuarioDAL();

        public void Inserir(GrupoUsuario grupoUsuario)
        {
            if (grupoUsuario.Nome.Length < 3 || grupoUsuario.Nome.Length > 150)
            {
                throw new Exception("O nome do grupo deve ter entre 3 e 150 caracteres.");
            }

            grupoUsuarioDAL.Inserir(grupoUsuario);
        }

        public void Alterar(GrupoUsuario grupoUsuario)
        {
            if (grupoUsuario.Nome.Length < 3 || grupoUsuario.Nome.Length > 150)
            {
                throw new Exception("O nome do grupo deve ter entre 3 e 150 caracteres.");
            }

            grupoUsuarioDAL.Alterar(grupoUsuario);
        }

        public GrupoUsuario BuscarPorId(int id)
        {
            return grupoUsuarioDAL.BuscarPorId(id);
        }

        public List<GrupoUsuario> ExibirTodos()
        {
            return grupoUsuarioDAL.ExibirTodos();
        }

        public void Excluir(int id)
        {
            grupoUsuarioDAL.Excluir(id);
        }
    }
}

