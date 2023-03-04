using DAL;
using Models;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class PermissaoBLL
    {

		public void Inserir(Permissao _permissao)
		{
			if (_permissao.Descricao.Length < 5 || _permissao.Descricao.Length > 300)
			{
				throw new Exception("A descrição da permissão deve ter entre 5 e 300 caracteres, não é aceito descrição nula ou vazia.");
			}

			try
			{
				PermissaoDAL dal = new PermissaoDAL();
				dal.Inserir(_permissao);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public void Alterar(Permissao _permissao)
		{
			if (_permissao.Descricao.Length < 5 || _permissao.Descricao.Length > 300)
			{
				throw new Exception("A descrição da permissão deve ter entre 5 e 300 caracteres, não é aceito descrição nula ou vazia.");
			}

			try
			{
				PermissaoDAL dal = new PermissaoDAL();
				dal.Alterar(_permissao);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
        public void Excluir(int id)
        {
            if (id <= 0)
                throw new Exception("O ID da permissão deve ser um número inteiro maior que zero.");
            PermissaoDAL _permissaoDAL = new PermissaoDAL();
            _permissaoDAL.Excluir(id);
        }		
        public Permissao BuscarPorID(int id)
        {
            if (id <= 0)
                throw new Exception("O ID da permissão deve ser um número inteiro maior que zero.");
			PermissaoDAL _permissaoDAL = new PermissaoDAL();
            return _permissaoDAL.BuscarPorId(id);
        }
        public List<Permissao> ExibirTodasPermissoes()
        {
            PermissaoDAL _permissaoDAL = new PermissaoDAL();
            return _permissaoDAL.ExibirTodasPermissoes();
        }
    }
}
