using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorEstoque.src.dominio {
    abstract class ObjetoBanco {
        public long Id { get; set; }

        public long GetId(ObjetoBanco value) {
            if (value == null) {
                return 0;
            } else {
                return value.Id;
            }
        }
    }
}
