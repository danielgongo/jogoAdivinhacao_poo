using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooJogoAdivinhacao 
{
    public class GerenciadorJogo 
    {

        private List<NovaPergunta> perguntas;

        public List<NovaPergunta> Perguntas
        {
            get { return this.perguntas; }
        }

        public void Jogar()
        {
            perguntas = CriarPerguntas();
    
            //Perguntas que serão exibidas
            Random aleatorio = new Random();
            int pos = aleatorio.Next(0, perguntas.Count);
            NovaPergunta pergunta = perguntas[pos];

            //Lógica da resposta
            int tentativas = 0;
            bool flag = false;
            string resposta = "";

            while ((tentativas < 3) && (flag == false))
            {
                Console.WriteLine("Pergunta: " + pergunta.Pergunta);

                Console.Write("Resposta: ");
                resposta = Console.ReadLine();
                resposta = resposta.ToUpper();
                if (resposta == pergunta.Resposta)
                {
                    flag = true;
                }
                else
                {
                    Console.WriteLine("Errou!!! \nDica: " + pergunta.Dica);
                }
                tentativas++;
            }

            if (flag == true)
            {
                Console.WriteLine("Parabéns, você ganhou!");
            }
            else
            {
                Console.WriteLine("Infelizmente você perdeu :( ");
            }

            Console.ReadKey();
        }

        private List<NovaPergunta> CriarPerguntas()
        {
            perguntas = new List<NovaPergunta>();
            perguntas.Add(new NovaPergunta("Qual meu time na Inglaterra?", "Tottenham", "É chamado de Spurs"));
            perguntas.Add(new NovaPergunta("Nome do Rei do Universo", "Jesus Cristo", "Ele morreu para nos salvar"));
            perguntas.Add(new NovaPergunta("Nome do profeta que eu levo o nome", "Daniel", "Ele foi para cova dos leões"));
            perguntas.Add(new NovaPergunta("Em qual estado eu nasci? ", "Rio de Janeiro", "Sou carioca"));
            perguntas.Add(new NovaPergunta("Qual linguagem de programação estudo?", "C#", "É da Microsoft"));
            perguntas.Add(new NovaPergunta("O livro mais importante do mundo", "Bíblia", "Conta sobre Cristo"));
            perguntas.Add(new NovaPergunta("QUantos idiomas eu falo? ", "Dois", "A segunda é a linguagem padrão do mundo"));
            perguntas.Add(new NovaPergunta("Raça de cachorro que gosto", "Mallinois", "É Belga"));


            return perguntas;
        }
    }
}
