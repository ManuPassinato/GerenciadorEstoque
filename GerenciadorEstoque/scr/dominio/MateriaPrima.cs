using GerenciadorEstoque.src.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorEstoque.scr.dominio {
    class MateriaPrima : ObjetoBanco {

        public long idProduto { get; set; }
        public long idMateriaPrima { get; set; }
        public Decimal quantidadePorUnidade { get; set; }
        public int porcentagemDisperdicio { get; set; }

    }
}
