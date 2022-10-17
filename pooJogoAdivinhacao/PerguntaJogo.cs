using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooJogoAdivinhacao
{
    public class PerguntaJogo
    {
        public PerguntaJogo()
        {
            this.Pergunta = "";
            this.Resposta = "";

        }

        public PerguntaJogo(string pergunta, string resposta)
        {
            this.Pergunta = pergunta;
            this.Resposta = resposta;
        }

        private string pergunta;
        public string Pergunta {
            get { return this.pergunta; }

            set 
            {
                pergunta = value.ToUpper();
            } 
        }

        private string resposta;
        public string Resposta
        {
            get { return this.resposta; }

            set
            {
                resposta = value.ToUpper();
            }
        }
    }
}
