using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma.modelo
{
    internal class Validacao
    {
        public Double num1;
        public Double num2;
        public String mensagem;
        public String numero1;
        public String numero2;

        public void Validar()
        {
            mensagem = "";
            try
            {
                num1 = Convert.ToDouble(numero1);
                num2 = Convert.ToDouble(numero2);
            }
            catch (Exception)
            {
                mensagem = "Erro de conversão";
            }
        }
    }
}
