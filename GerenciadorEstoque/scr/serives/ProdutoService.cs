using GerenciadorEstoque.src.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorEstoque.scr.serives {
    class ProdutoService : AbstractService {
        private string nomeTabela = "produto";

        public List<Object> GetAll() {
            List<Object> lista = base.GetAll<Produto>(nomeTabela).Cast<object>().ToList();
            return lista;
        }

        public List<Object> GetAll(List<long> ids) {
            if (ids == null || ids.Count == 0) {
                return null;
            }
            List<Object> lista = base.GetAll<Produto>(ids, nomeTabela).Cast<object>().ToList();
            return lista;
        }

        public Produto GetById(long id) {
            if (id == 0) {
                return null;
            }
            Produto produto = base.GetById<Produto>(id, nomeTabela);
            return produto;
        }

        public List<Object> GetAllByFornecedorId(long fornecedorId) {
            if (fornecedorId == 0) {
                return null;
            }
            //TODO: Metodo para obter todos os ids de produtos com base no fornecedor
            List<long> idsProdutos = new List<long>();
            return GetAll(idsProdutos);
        }

        public void Save(Produto produto) {
            base.Save(produto, nomeTabela);
        }

        public void SaveAll(List<Object> produtos) {
            base.SaveAll(produtos, nomeTabela);
        }

        public void Delet(Produto produto) {
            base.Delet(produto, nomeTabela);
        }

        public void DeletAll(List<Object> produtos) {
            base.DeletAll(produtos, nomeTabela);
        }
    }
}
