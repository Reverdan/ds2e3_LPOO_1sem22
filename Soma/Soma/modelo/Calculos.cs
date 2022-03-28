using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma.modelo
{

    internal class Calculos
    {
        public Double num1;
        public Double num2;
        public Double resultado;

        public void Calcular()
        {
            this.resultado = this.num1 + this.num2;
        }
    }
}
