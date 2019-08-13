using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AED
{

    public class Respostas
    {
        

        public void resposta1()
        {
            Console.WriteLine("A partir do uso de interface a classe obrigatoriamente implementa o metodo contido na interface, " +
                "sem a necessidade" +
                "de alteração no comportamento dos demais classes. as interfaces que auxiliam na definição dessas classes," +
                " mas o comportamento " +
                "dos metodos são implementados pela classe." +
                "Com interfaces você pode garantir que objetos tenham algum, ou alguns métodos em comum, ou seja, " +
                "sigam um contrato, sem forçar que esses" +
                " objetos pertençam a uma mesma hierarquia de classes predefinida. " +
                "Com interfaces você define capacidades que podem ser implementadas por " +
                "diversas classes não correlacionadas.");
        }

        public void resposta2()
        {
            Console.WriteLine("Dependência de funcionalidades já implementadas em superclasses no caso da herança," +
                " implementações espalhadas em classes diferentes. - " +
                "Maior esforço na modelagem de um sistema OO do que estruturado");
        }
    }
}
