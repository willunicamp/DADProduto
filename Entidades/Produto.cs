using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades {
    public class Produto {
        public int Id { get; set; }
        public string Nome { get; set; }

        private int _quantidade;
        public int Quantidade {  
            get => _quantidade;
            set {
                if (value < 0) {
                    throw new ArgumentOutOfRangeException("Quantidade não pode ser negativa");
                }
                _quantidade = value;
            } 
        }
        public DateTime DataHora { get; set; }

        public Produto() {
            DataHora = DateTime.Now;
        }
    }
}
