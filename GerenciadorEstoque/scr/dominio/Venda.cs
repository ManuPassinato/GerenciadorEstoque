using System;
using System.Collections.Generic;
using GerenciadorEstoque.src.utils;


namespace GerenciadorEstoque.src.dominio {
    class Venda : ObjetoBanco {

        public long codigoVenda { get; set; }
        public List<Unidade> produtosVendidos { get; set; }
		public Decimal valorTotal { get; }
		public DateTime data { get; set; }
    }
}
