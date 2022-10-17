using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace pooJogoAdivinhacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lista de perguntas
            List<NovaPergunta> perguntas;
            perguntas = CriarPerguntas();

            //Perguntas que serão exibidas
            Random aleatorio = new Random();
            int pos =  aleatorio.Next(0, perguntas.Count);
            NovaPergunta pergunta = perguntas[pos];

            //Lógica da resposta
            int tentativas = 0;
            bool flag = false;
            string resposta = "";

            while((tentativas < 3) && (flag == false))
            {
                Console.WriteLine("Pergunta: " + pergunta.Pergunta);

                Console.Write("Resposta: ");
                resposta = Console.ReadLine();
                resposta = resposta.ToUpper();
                if(resposta == pergunta.Resposta)
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

        static List<NovaPergunta> CriarPerguntas()
        {
            List<NovaPergunta> lista = new List<NovaPergunta>();
            NovaPergunta p = new NovaPergunta("Qual a cor do céu?","Azul", "Começa coma letra A");
            lista.Add(p);
            p = new NovaPergunta("Qual o meu time?", "flamengo", "É o maior do Brasil");
            lista.Add(p);
            lista.Add(new NovaPergunta("Qual meu time na Inglaterra?", "Tottenham", "É chamado de Spurs"));
            lista.Add(new NovaPergunta("Nome do Rei do Universo", "Jesus Cristo", "Ele morreu para nos salvar"));
            lista.Add(new NovaPergunta("Nome do profeta que eu levo o nome", "Daniel", "Ele foi para cova dos leões"));
            lista.Add(new NovaPergunta("Em qual estado eu nasci? ", "Rio de Janeiro", "Sou carioca"));
            lista.Add(new NovaPergunta("Qual linguagem de programação estudo?", "C#", "É da Microsoft"));
            lista.Add(new NovaPergunta("O livro mais importante do mundo", "Bíblia", "Conta sobre Cristo"));
            lista.Add(new NovaPergunta("QUantos idiomas eu falo? ", "Dois", "A segunda é a linguagem padrão do mundo"));
            lista.Add(new NovaPergunta("Raça de cachorro que gosto", "Mallinois", "É Belga"));


            return lista;
        }
    }
}
