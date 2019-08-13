using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AED
{
    public class MallardDuck : Pato, IFlyable
    {
        public override void display()
        {

            Pato pato = new Pato();
            pato.frase = "Eu sou um pato mau";
            Console.WriteLine("Pato mau diz:" + pato.frase);
        }

        public void fly()
        {
            Console.WriteLine("O pato está voando");
        }
    }
}
