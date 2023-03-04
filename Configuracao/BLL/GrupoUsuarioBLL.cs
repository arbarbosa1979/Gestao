using System;
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
            if (grupoUsuario.NomeGrupo.Length < 3 || grupoUsuario.NomeGrupo.Length > 150)
            {
                throw new Exception("O nome do grupo deve ter entre 3 e 150 caracteres.");
            }

            grupoUsuarioDAL.Inserir(grupoUsuario);
        }

        public void Alterar(GrupoUsuario grupoUsuario)
        {
            if (grupoUsuario.NomeGrupo.Length < 3 || grupoUsuario.NomeGrupo.Length > 150)
            {
                throw new Exception("O nome do grupo deve ter entre 3 e 150 caracteres.");
            }

            grupoUsuarioDAL.Alterar(grupoUsuario);
        }

        public GrupoUsuario BuscarPorId(int id)
        {
            return grupoUsuarioDAL.BuscarPorID(id);
        }

        public List<GrupoUsuario> ExibirTodos()
        {
            return grupoUsuarioDAL.ExibirTodosGrupos();
        }

        public void Excluir(int id)
        {
            grupoUsuarioDAL.Excluir(id);
        }
    }
}

