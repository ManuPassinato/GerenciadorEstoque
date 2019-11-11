using GerenciadorEstoque.src.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorEstoque.scr.serives {
    class AbstractService {

        public void Save(ObjetoBanco objeto, string nomeTabela) { }
        public void SaveAll(List<Object> objetos, string nomeTabela) { }

        public void Delet(ObjetoBanco objeto, string nomeTabela) { }
        public void DeletAll(List<Object> objetos, string nomeTabela) { }

        public T GetById<T>(long id, string nomeTabela) where T : ObjetoBanco {
            return null;
        }

        public List<T> GetAll<T>(string nomeTabela) where T : ObjetoBanco {
            List<T> lista = new List<T>();
            return lista;
        }

        public List<T> GetAll<T>(List<long> ids ,string nomeTabela) where T : ObjetoBanco {
            List<T> lista = new List<T>();
            return lista;
        }
    }
}
