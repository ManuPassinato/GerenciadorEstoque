using System;
using System.Collections.Generic;
using GerenciadorEstoque.src.utils;


namespace GerenciadorEstoque.src.dominio
{
    class Compra : ObjetoBanco
    {

        public long Codigo { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public List<Unidade> MateriasPrimasUsadas { get; set; }
        public List<Unidade> produtosComprados { get; set; }
        public Decimal valorTotal { get; }
        public DateTime data { get; set; }
    }
}
