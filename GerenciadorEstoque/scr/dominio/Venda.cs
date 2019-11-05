using System;
using System.Collections.Generic;
using GerenciadorEstoque.src.utils;


namespace GerenciadorEstoque.src.dominio {
    class Venda : ObjetoBanco {

        public long codigoVenda { get; set; }
        public List<Produto> produtosVendidos { get; set; }
		public Decimal valorTotal { get => produtosVendidos.valorVenda.Sum(); }
		public Dat data { get; set; }
    }
}
