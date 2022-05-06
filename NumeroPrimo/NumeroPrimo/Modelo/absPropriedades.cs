using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroPrimo.Modelo
{
    internal abstract class absPropriedades
    {
        private string mensagem;
        public string Mensagem
        {
            get { return mensagem; }
            set { mensagem = value; }
        }

        private int num;
        public int Num
        {
            get { return num; }
            set { num = value; }
        }

        private string numero;
        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public absPropriedades(int num)
        {
            this.num = num;
        }

        public absPropriedades(string numero)
        {
            this.numero = numero;
        }
    }
}
