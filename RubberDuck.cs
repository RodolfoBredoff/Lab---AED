using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AED
{
    public class RubberDuck : Pato, IQuackAble
    {
        public void Quack()
        {
            Console.WriteLine("Esse RubberDuck fez Quack");
        }

        public override void display()
        {
            Console.WriteLine("Eu sou um RubberDuck");
        }
    }
}
