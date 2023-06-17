using DAL;
using Models;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class FornecedorBLL
    {
        public void Inserir(Fornecedor _fornecedor)
        {
            new FornecedorDAL().Inserir(_fornecedor);
        }
        public List<Fornecedor> BuscarTodos()
        {
            return new FornecedorDAL().BuscarTodos();
        }
        public List<Fornecedor> BuscarPorNome(string _nome)
        {
            return new FornecedorDAL().BuscarPorNome(_nome);
        }
        public Fornecedor BuscarPorId(int _id)
        {
            Fornecedor fornecedor = new FornecedorDAL().BuscarPorId(_id);

            if (fornecedor == null)
            {
                throw new Exception("ID de Fornecedor não encontrado no banco de dados.") { Data = { { "Id", 45 } } };
                // Ou você pode retornar null em vez de lançar uma exceção
                // return null;
            }

            return fornecedor;
        }

        public Fornecedor BuscarPorSite(string _site)
        {
            return new FornecedorDAL().BuscarPorSite(_site);
        }
        public void Alterar(Fornecedor _fornecedor)
        {
            new FornecedorDAL().Alterar(_fornecedor);
        }
        public void Excluir(int _id)
        {
            new FornecedorDAL().Excluir(_id);
        }
    }
}