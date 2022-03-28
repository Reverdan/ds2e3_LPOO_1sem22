using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma.modelo
{

    internal class Calculos
    {
        private Double n1;
        private Double n2;
        private Double resultado;

        public double Resultado { get => resultado;}

        public Calculos(double n1, double n2)
        {
            this.n1 = n1;
            this.n2 = n2;
            Calcular();
        }

        private void Calcular()
        {
            this.resultado = this.n1 + this.n2;
        }
    }
}
