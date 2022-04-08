using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma.modelo
{
    internal class Calculos : Propriedades
    {
        public Calculos(double n1, double n2)
        {
            this.n1 = n1;
            this.n2 = n2;
            Calcular();
        }

        private void Calcular()
        {
            this.res = this.n1 + this.n2;
        }
    }
}
