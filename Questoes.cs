using System;
using System.Collections.Generic;
using System.Linq;

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

            List<Animal> animais = new List<Animal>();
            Morcego morcego = new Morcego();
            Galinha galinha = new Galinha();
            animais.Add(morcego);
            animais.Add(morcego);
            animais.Add(morcego);
            animais.Add(morcego);
            animais.Add(morcego);
            animais.Add(galinha);
            animais.Add(galinha);
            animais.Add(galinha);
            animais.Add(galinha);
            animais.Add(galinha);

            foreach (Animal animal in animais)
            {
                if(animal.GetType().ToString().Contains("Galinha"))
                {
                    Console.WriteLine("Galinha");
                    animal.Acordar();
                    animal.Comer();
                }
                else
                {
                    Console.WriteLine("Morcego");
                    animal.Acordar();
                    animal.Comer();

                    Morcego aux = (Morcego)animal;
                    aux.Voar();
                }
            }
            

            Console.ReadLine();
        }
    }
}
