using System;
using System.Collections.Generic;
using GerenciadorEstoque.src.utils;


namespace GerenciadorEstoque.src.dominio {
    class Unidade : Produto {
	
		private Produto produto { get; }
        public Decimal quantidade { get; set; }
		public Decimal valorUnitário { get; set; }
        public DateTime DataEntrada { get; set; }

    }
}
