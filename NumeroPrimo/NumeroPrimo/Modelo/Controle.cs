using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroPrimo.Modelo
{
    internal class Controle : absPropriedades
    {
        public Controle(string numero) : base(numero)
        {
            Executar();
        }

        private void Executar()
        {
            this.Mensagem = "";
            Validacao validacao = new Validacao(this.Numero);
            if (validacao.Mensagem.Equals(""))
            {
                Primo primo = new Primo(validacao.Num);
                this.Mensagem = primo.Mensagem;
            }
            else
            {
                this.Mensagem = validacao.Mensagem;
            }
        }
    }
}
