using System;
using System.Collections.Generic;
using GerenciadorEstoque.src.utils;


namespace GerenciadorEstoque.src.dominio {
    class Produto : ObjetoBanco {

        protected string nome;
        public String Nome {
            get => nome;
            set => nome = StringUtils.ValideNaoNuloNaoVazioENormalize(value, "Nome do Produto");
        }
        public long Codigo { get; set; }
        public Decimal Quantidade { get; set; }
        public Boolean isProdutoFinal { get; set; }
        public List<Produto> MateriasPrimas { get; set; }

    }
}
