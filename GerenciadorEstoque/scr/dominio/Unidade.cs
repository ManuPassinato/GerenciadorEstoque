using System;
using System.Collections.Generic;
using GerenciadorEstoque.src.utils;


namespace GerenciadorEstoque.src.dominio {
    class Unidade : Produto {
	
        public long codigoProduto { get; set; }
		private sealed Produto grupoProduto { get; }
        public Decimal quantidade { get; set; }
		public Decimal valorVenda { get; set; }
		public Decimal valorCompra { get; set; }
		public Compra compra { get; set; }
		public Venda venda { get; set; }

    }
}
