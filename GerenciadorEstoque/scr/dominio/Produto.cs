using System;
using System.Collections.Generic;
using GerenciadorEstoque.src.utils;


namespace GerenciadorEstoque.src.dominio {
    class Produto : ObjetoBanco {

		enum tipoUnidade {
			Litros,
			Quilogramas,
			Simples
        }

        protected string nome;
        public String Nome {
            get => nome;
            set => nome = StringUtils.ValideNaoNuloNaoVazioENormalize(value, "Nome do Produto");
        }
        public long codigoGrupo { get; set; }
        public Boolean isProdutoFinal { get; set; }
        public List<Produto> materiasPrimas { get; set; }
    }
}
