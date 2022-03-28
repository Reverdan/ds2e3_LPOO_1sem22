using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma.modelo
{
    public class Controle
    {
        public String resultado;
        public String mensagem;
        public String numero1;
        public String numero2;

        public void Calcular()
        {
            mensagem = "";
            Validacao validacao = new Validacao();
            validacao.numero1 = this.numero1;
            validacao.numero2 = this.numero2;
            validacao.Validar();
            if (validacao.mensagem.Equals(""))
            {
                Calculos calculos = new Calculos();
                calculos.num1 = validacao.num1;
                calculos.num2 = validacao.num2;
                calculos.Calcular();
                resultado = calculos.resultado.ToString();
            }
            else
            {
                mensagem = validacao.mensagem;
            }
        }
    }
}
