using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agenda_simples_t5
{
    internal class Contato
    {
        //Variáveis locais de classe Contato
        //Acessiveis apenas pela classe Contato
        private string primeiroNome;
        private string sobrenome;
        private string telefone;

        //Propriedades da classe contato
        //Acessiveis por qualquer parte desse programa.
        public string PrimeiroNome
        {
            get { return primeiroNome; }
            set { primeiroNome = value; }
        }
        public string Sobrenome
        { get { return sobrenome; }
            set { sobrenome = value; }
        }
        public string Telefone
        { get { return telefone; }
            set
            {
                if (value.Length == 11)
                {
                    telefone = value;
                }
                else
                {
                    telefone = "00-00000-0000";
                }

            }

        }   
        public Contato() 
            {
            PrimeiroNome = "João";
            Sobrenome = "Da Silva";
            Telefone = "11-91198-4040";
            }
        //Sobrecarga de método
        public Contato(string primeironome, string sobrenome, string telefone)
        {
            PrimeiroNome = primeironome;
            Sobrenome = sobrenome;
            Telefone = telefone;
        }

        //Sobreescrita do método ToString()
        public override string ToString()
        {
            //Melhor usar String.Empty invés de "".
            string saída = String.Empty;
            saída += String.Format("{0}, {1}", PrimeiroNome, Sobrenome);
            saída += String.Format("{0}-{1}-{2}",
            Telefone.Substring(0, 1), Telefone.Substring(2, 6), Telefone.Substring(7, 10));
        }

    }
 
}
