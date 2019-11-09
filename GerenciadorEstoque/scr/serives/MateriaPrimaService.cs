using GerenciadorEstoque.scr.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorEstoque.scr.serives {
    class MateriaPrimaService : AbstractService {
        private string nomeTabela = "materiaprima";

        public List<Object> GetAll() {
            List<Object> lista = base.GetAll<MateriaPrima>(nomeTabela).Cast<object>().ToList();
            return lista;
        }

        public List<Object> GetAll(List<long> ids) {
            if (ids == null || ids.Count == 0) {
                return null;
            }
            List<Object> lista = base.GetAll<MateriaPrima>(ids, nomeTabela).Cast<object>().ToList();
            return lista;
        }

        public MateriaPrima GetById(long id) {
            if (id == 0) {
                return null;
            }
            MateriaPrima materiaPrima = base.GetById<MateriaPrima>(id, nomeTabela);
            return materiaPrima;
        }

        public List<Object> GetAllByProdutoId(long produtoId) {
            if (produtoId == 0) {
                return null;
            }
            List<long> idsMatererias = new List<long>();
            return GetAll(idsMatererias);
        }

        public List<Object> GetAllByMateriaPrimaId(long materiaPrimaId) {
            if (materiaPrimaId == 0) {
                return null;
            }
            List<long> idsProdutos = new List<long>();
            return GetAll(idsProdutos);
        }

        public void Save(MateriaPrima materiaPrima) {
            base.Save(materiaPrima, nomeTabela);
        }

        public void SaveAll(List<Object> materiasPrima) {
            base.SaveAll(materiasPrima, nomeTabela);
        }

        public void Delet(MateriaPrima materiaPrima) {
            base.Delet(materiaPrima, nomeTabela);
        }

        public void DeletAll(List<Object> materiasPrima) {
            base.DeletAll(materiasPrima, nomeTabela);
        }
    }
}
}
