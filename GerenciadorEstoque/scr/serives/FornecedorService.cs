using GerenciadorEstoque.src.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorEstoque.scr.serives {
    class FornecedorService : AbstractService {
        private string nomeTabela = "fornecedor";

        public List<Object> GetAll(){
            List<Object> lista = base.GetAll<Fornecedor>(nomeTabela).Cast<object>().ToList();
            return lista;
        }

        public List<Object> GetAll(List<long> ids) {
            if (ids == null || ids.Count == 0) {
                return null;
            }
            List<Object> lista = base.GetAll<Fornecedor>(ids, nomeTabela).Cast<object>().ToList();
            return lista;
        }

        public Fornecedor GetById(long id) {
            if (id == 0) {
                return null;
            }
            Fornecedor fornecedor = base.GetById<Fornecedor>(id, nomeTabela);
            return fornecedor;
        }

        public List<Object> GetAllByProdutoId(long produtoId) {
            if (produtoId == 0) {
                return null;
            }
            //TODO: Metodo para obter todos os ids de fornecedor com base no Produto
            List<long> idsForncedores = new List<long>();
            return GetAll(idsForncedores);
        }

        public void Save(Fornecedor fornecedor) {
            base.Save(fornecedor, nomeTabela);
        }

        public void SaveAll(List<Object> fornecedores) {
            base.SaveAll(fornecedores, nomeTabela);
        }

        public void Delet(Fornecedor fornecedor) {
            base.Delet(fornecedor, nomeTabela);
        }

        public void DeletAll(List<Object> fornecedores) {
            base.DeletAll(fornecedores, nomeTabela);
        }
    }
}
