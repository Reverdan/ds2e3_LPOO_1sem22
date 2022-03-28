using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma.modelo
{
    public class Controle
    {
        private String resultado;
        private String mensagem;
        private String numero1;
        private String numero2;

        public string Resultado { get => resultado;}
        public string Mensagem { get => mensagem;}

        public Controle(string numero1, string numero2)
        {
            this.numero1 = numero1;
            this.numero2 = numero2;
            Calcular();
        }

        private void Calcular()
        {
            mensagem = "";
            Validacao validacao = new Validacao(this.numero1, this.numero2);
            if (validacao.Mensagem.Equals(""))
            {
                Calculos calculos = new Calculos(validacao.N1, validacao.N2);
                resultado = calculos.Resultado.ToString();
            }
            else
            {
                mensagem = validacao.Mensagem;
            }
        }
    }
}
