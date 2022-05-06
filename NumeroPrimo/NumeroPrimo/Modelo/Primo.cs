using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroPrimo.Modelo
{
    internal class Primo : absPropriedades
    {
        public Primo(int num) : base(num)
        {
            Verificar();
        }

        private void Verificar()
        {
            this.Mensagem = "É primo";
            for (int i = 2; i < (this.Num / 2 + 1); i++)
            {
                if (this.Num % i == 0)
                {
                    this.Mensagem = "Não é primo";
                    break;
                }
            }
        }
    }
}
