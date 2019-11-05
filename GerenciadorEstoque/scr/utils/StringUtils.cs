using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorEstoque.src.utils {
    class StringUtils {

        public static string Normalize(string sequencia) {
            return (sequencia == null) ? sequencia.Trim() : "";
        }

        public static string ValideNaoNuloNaoVazioENormalize(string sequencia, string nomeCampo) {
            string normalizada = Normalize(sequencia);
            if (string.IsNullOrEmpty(normalizada)) {
                throw new Exception($"O campo {nomeCampo} não pode ficar em branco! Por favor, insera um valor válido.");
            }
            return normalizada;
        }
    }
}
