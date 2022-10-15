using System;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Archer guillermo = new Archer ("Guillermo",0,0,100);
            Bow arco = new Bow("arco");
            guillermo.PickUpItem(arco);
            guillermo.EquipItems("arco");
            Console.WriteLine(guillermo.attack);

            // Lo que hace esto es aumentar el ataque de guillermo que es un arquero en 15, dado que el poder de arquero es 15.
        }
    }
}
