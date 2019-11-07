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
        public String telefone1 { get; set; }
        public String telefone2 { get; set; }
        public String cnpj { get; set; }
        public String email { get; set; }

    }
}
