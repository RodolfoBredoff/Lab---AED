using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AED
{
    public static class Questoes
    {
        public static void exercicio2()
        {
            RedHeadDuck patovermelho = new RedHeadDuck();
            patovermelho.display();
            patovermelho.Quack();
            patovermelho.fly();
            MallardDuck patoreal = new MallardDuck();
            patoreal.display();
            patoreal.fly();

            RubberDuck patoBorracha = new RubberDuck();
            patoBorracha.display();
            patoBorracha.Quack();

            Respostas[] respostas = new Respostas[2];
            respostas[0] = new Respostas();
            respostas[1] = new Respostas();

            Console.WriteLine("\nTecle enter para ler a resposta 2\n");
            Console.ReadLine();
            respostas[0].resposta1();
            Console.WriteLine("\nTecle enter para ler a resposta 3\n");
            Console.ReadLine();
            respostas[1].resposta2();
            Console.WriteLine("\nTecle enter para finalizar...\n");
            Console.ReadLine();
        }

        public static void exercicio2Parte2()
        {

        }
    }
}
