using GerenciadorEstoque.src.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorEstoque.scr.dominio.enums {
    class ETipoUnidade {

        public enum TipoUnidade {
            Litros,
            Quilogramas,
            Simples
        }

        public static object[] Values() {
            return Enum.GetNames(typeof(TipoUnidade)).ToArray();
        }

        public static string ParseAndValidate(string tipoUnidade) {
            tipoUnidade = StringUtils.ValideNaoNuloNaoVazioENormalize(tipoUnidade, "Tipo Unidade");
            try {
                string valorValidado;
                valorValidado = Enum.Parse(typeof(TipoUnidade), tipoUnidade).ToString();
                return valorValidado;
            } catch (Exception ignored) {
                throw new Exception($"Valor {tipoUnidade} não é válido para Tipo Unidade!");
            }
        }
    }
}
