using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AED
{
    public class RedHeadDuck : Pato, IQuackAble , IFlyable
    {

        public override void display()
        {
            Pato pato = new Pato();
            pato.frase = "Sou um pato Vermelho";
            Console.WriteLine("Pato vermelho diz:" + pato.frase);
        }

        public void Quack()
        {
            Console.WriteLine("Esse RedHeadDuck fez Quack");
        }

        public void fly()
        {
            Console.WriteLine("O pato está voando");
        }
    }
}
