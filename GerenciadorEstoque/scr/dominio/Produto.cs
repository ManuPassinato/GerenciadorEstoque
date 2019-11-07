using System;
using System.Collections.Generic;
using GerenciadorEstoque.scr.dominio.enums;
using GerenciadorEstoque.src.utils;


namespace GerenciadorEstoque.src.dominio {
    class Produto : ObjetoBanco {

        protected string nome;
        public String Nome {
            get => nome;
            set => nome = StringUtils.ValideNaoNuloNaoVazioENormalize(value, "Nome do Produto");
        }

        public long codigo { get; set; }
        public List<Produto> materiasPrimas { get; set; }
        public Decimal quantidade { get; set; }
        public Decimal custoUnidade { get; set; }

        string tipoUnidade;
        public string TipoUnidade {
            get => tipoUnidade;
            set => tipoUnidade = ETipoUnidade.ParseAndValidate(value);
        }

    }
}
