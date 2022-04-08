using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma.modelo
{
    internal class Propriedades
    {
        public String resultado;
        public String mensagem;
        public String numero1;
        public String numero2;
        public Double n1;
        public Double n2;
        public Double res;

        public String Resultado { get => resultado; }
        public double N1 { get => n1; }
        public double N2 { get => n2; }
        public string Mensagem { get => mensagem; }
        public double Res { get => res;}
    }
}
