using System;
using System.Collections.Generic;
using GerenciadorEstoque.src.utils;


namespace GerenciadorEstoque.src.dominio {
    class Venda : ObjetoBanco {

        public Produto Produto { get; set; }
		public Decimal valorTotal { get; set; }
        public Decimal quantidade { get; set; }
		public DateTime data { get; set; }
    }
}
