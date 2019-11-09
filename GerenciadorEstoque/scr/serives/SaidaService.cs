using GerenciadorEstoque.src.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorEstoque.scr.serives {
    class SaidaService : AbstractService {

        private string nomeTabela = "saida";

        public List<Object> GetAll() {
            List<Object> lista = base.GetAll<Saida>(nomeTabela).Cast<object>().ToList();
            return lista;
        }

        public List<Object> GetAll(List<long> ids) {
            if (ids == null || ids.Count == 0) {
                return null;
            }
            List<Object> lista = base.GetAll<Saida>(ids, nomeTabela).Cast<object>().ToList();
            return lista;
        }

        public Saida GetById(long id) {
            if (id == 0) {
                return null;
            }
            Saida saida = base.GetById<Saida>(id, nomeTabela);
            return saida;
        }

        public List<Object> GetAllByProdutoId(long produtoId) {
            if (produtoId == 0) {
                return null;
            }
            //TODO: Metodo para obter todos os ids de saidas com base no id produto
            List<long> idsSaidas = new List<long>();
            return GetAll(idsSaidas);
        }

        public void Save(Saida saida) {
            //TODO: Metodo para obter o produto, recalcular sua quantidade e salvar no banco
            base.Save(saida, nomeTabela);
        }

        public void SaveAll(List<Object> saidas) {
            //TODO: Metodo para obter o produto, recalcular sua quantidade e salvar no banco
            base.SaveAll(saidas, nomeTabela);
        }

        public void Delet(Saida saida) {
            //TODO: Metodo para obter o produto, recalcular sua quantidade e salvar no banco
            base.Delet(saida, nomeTabela);
        }

        public void DeletAll(List<Object> saidas) {
            //TODO: Metodo para obter o produto, recalcular sua quantidade e salvar no banco
            base.DeletAll(saidas, nomeTabela);
        }
    }
}
