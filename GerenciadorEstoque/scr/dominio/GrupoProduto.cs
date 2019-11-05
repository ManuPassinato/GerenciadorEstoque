using System;
using System.Collections.Generic;
using GerenciadorEstoque.src.utils;


namespace GerenciadorEstoque.src.dominio {
    class GrupoProduto : ObjetoBanco {

		Enum tipoUnidade {
			Litros = "l",
			Quilogramas = "kg",
			Simples = "Und."
		}

        protected string nome;
        public String Nome {
            get => nome;
            set => nome = StringUtils.ValideNaoNuloNaoVazioENormalize(value, "Nome do Produto");
        }
        public long codigoGrupo { get; set; }
        public Boolean isProdutoFinal { get; set; }
        public List<GrupoProduto> materiasPrimas { get; set; }
		public tipoUnidade unidade { get; set; }
    }
}
