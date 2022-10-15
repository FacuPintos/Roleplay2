using System;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Archer guillermo = new Archer ("Guillermo",0,0,100);
            Bow arco = new Bow ("arco");
            guillermo.EquipItems("arco");
            Console.WriteLine(guillermo.attack);
        }
    }
}
