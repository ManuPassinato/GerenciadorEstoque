using System;
using System.Collections.Generic;
using GerenciadorEstoque.src.utils;


namespace GerenciadorEstoque.src.dominio {
    class Compra : ObjetoBanco {

        public long Codigo { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public List<Produto> MateriasPrimasUsadas { get; set; }
		public List<Produto> produtosComprados { get; set; }
		public Decimal valorTotal { get =>  produtosComprados.valorCompra.Sum(); }
		public Dat data { get; set; }
    }
}