using System;
using System.Collections.Generic;
using GerenciadorEstoque.src.utils;


namespace GerenciadorEstoque.src.dominio {
    class Fornecedor : ObjetoBanco {

        protected string nome;
        public String Nome {
            get => nome;
            set => nome = StringUtils.ValideNaoNuloNaoVazioENormalize(value, "Nome do Fornecedor");
        }
        public long codigoFornecedor { get; set; }
        public String Contato { get; set; }
    }
}
