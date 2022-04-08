using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma.modelo
{
    internal class Validacao : Propriedades
    {
        public Validacao(string numero1, string numero2)
        {
            this.numero1 = numero1;
            this.numero2 = numero2;
            Validar();
        }

        private void Validar()
        {
            mensagem = "";
            try
            {
                n1 = Convert.ToDouble(numero1);
                n2 = Convert.ToDouble(numero2);
            }
            catch (Exception)
            {
                mensagem = "Erro de conversão";
            }
        }
    }
}
