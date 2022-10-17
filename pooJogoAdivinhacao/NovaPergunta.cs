using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooJogoAdivinhacao
{
    public class NovaPergunta : PerguntaJogo
    {

        public NovaPergunta():base()
        {
            this.Dica = "";
        }

        public NovaPergunta(string pergunta, string resposta, string dica) : base(pergunta, resposta){

            this.Dica = dica; //Quando se coloca os parâmetros na base, não precisa colocar dentro do construtor
        }

        private string dica;
        public string Dica {

            get { return dica; }
           
            set
            {
                dica = value.ToUpper();
            }
                
        }
    }
}
