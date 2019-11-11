using GerenciadorEstoque.src.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorEstoque.scr.serives {
    class EntradaService : AbstractService{

        private string nomeTabela = "entrada";

        public List<Object> GetAll() {
            List<Object> lista = base.GetAll<Entrada>(nomeTabela).Cast<object>().ToList();
            return lista;
        }

        public List<Object> GetAll(List<long> ids) {
            if (ids == null || ids.Count == 0) {
                return null;
            }
            List<Object> lista = base.GetAll<Entrada>(ids, nomeTabela).Cast<object>().ToList();
            return lista;
        }

        public Entrada GetById(long id) {
            if (id == 0) {
                return null;
            }
            Entrada entrada = base.GetById<Entrada>(id, nomeTabela);
            return entrada;
        }

        public List<Object> GetAllByProdutoId(long produtoId) {
            if (produtoId == 0) {
                return null;
            }
            //TODO: Metodo para obter todos os ids de entradas com base no id produto
            List<long> idsEntradas = new List<long>();
            return GetAll(idsEntradas);
        }

        public List<Object> GetAllByFornecedorId(long fornecedorId) {
            if (fornecedorId == 0) {
                return null;
            }
            //TODO: Metodo para obter todos os ids de entradas com base no id fornecedor
            List<long> idsEntradas = new List<long>();
            return GetAll(idsEntradas);
        }

        public void Save(Entrada entrada) {
            //TODO: Metodo para obter o produto, recalcular sua quantidade e salvar no banco
            base.Save(entrada, nomeTabela);
        }

        public void SaveAll(List<Object> entradas) {
            //TODO: Metodo para obter o produto, recalcular sua quantidade e salvar no banco
            base.SaveAll(entradas, nomeTabela);
        }

        public void Delet(Entrada entrada) {
            //TODO: Metodo para obter o produto, recalcular sua quantidade e salvar no banco
            base.Delet(entrada, nomeTabela);
        }

        public void DeletAll(List<Object> entradas) {
            //TODO: Metodo para obter o produto, recalcular sua quantidade e salvar no banco
            base.DeletAll(entradas, nomeTabela);
        }
    }
}
