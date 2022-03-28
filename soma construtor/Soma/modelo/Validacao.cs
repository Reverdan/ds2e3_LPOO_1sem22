using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma.modelo
{
    internal class Validacao
    {
        private Double n1;
        private Double n2;
        private String mensagem;
        private String numero1;
        private String numero2;

        public double N1 { get => n1;}
        public double N2 { get => n2;}
        public string Mensagem { get => mensagem;}

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
