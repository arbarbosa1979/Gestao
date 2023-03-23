using DAL;
using Models;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class PermissaoBLL
    {

		public void Inserir(int _id, string _permissao)
		{
            if (new PermissaoDAL().IdPermissaoExistente(_id))
            {
                throw new Exception("Já Existe uma permissão com esse ID.");
            }
            if (_permissao.Length < 5 || _permissao.Length > 300)
			{
				throw new Exception("A descrição da permissão deve ter entre 5 e 300 caracteres, não é aceito descrição nula ou vazia.");
			}

			try
			{
				PermissaoDAL dal = new PermissaoDAL();
				dal.Inserir(_id, _permissao);
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
        public void Excluir(Permissao _id)
        {
            if (new PermissaoDAL().PermissaoVinculadaGrupo(_id.ID))
                throw new Exception("Esta permissão possui vínculo com um grupo.");
 
            PermissaoDAL permissaoDAL = new PermissaoDAL();
            permissaoDAL.Excluir(_id);
        }
        public List<Permissao> BuscarPermissaoPorNome(string _nomePermissao)
        {
            PermissaoDAL permissaoDAL = new PermissaoDAL();
            return permissaoDAL.BuscarPermissaoPorNome(_nomePermissao);
        }
        public Permissao BuscarPorID(int _id)
        {
            if (_id <= 0)
                throw new Exception("O ID da permissão deve ser um número inteiro maior que zero.");
			PermissaoDAL _permissaoDAL = new PermissaoDAL();
            return _permissaoDAL.BuscarPermPorId(_id);
        }
        public List<Permissao> ExibirTodasPermissoes()
        {
            PermissaoDAL permissaoDAL = new PermissaoDAL();
            return permissaoDAL.ExibirTodasPermissoes();
        }
    }
}
