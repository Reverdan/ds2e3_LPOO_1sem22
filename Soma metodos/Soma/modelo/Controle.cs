using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma.modelo
{
    public class Controle
    {
        public String resultado = "";
        
        public String Calcular(String numero1, String numero2)
        {
            String mensagem = "";
            Validacao validacao = new Validacao();
            mensagem = validacao.Validar(numero1, numero2);
            if (mensagem.Equals(""))
            {
                Calculos calculos = new Calculos();
                resultado = calculos.Calcular(validacao.num1, validacao.num2).ToString();
            }
            return mensagem;
        }
    }
}
