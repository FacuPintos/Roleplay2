using System.Collections.Generic;
namespace RoleplayGame{

    public interface ICharacters
    {

        string Name { get; set; }

        int Damage {get; set; }

        int Defense {get; set; }

        List<IItems> items {get; set; }

        int AttackValue();       

        int DefenseValue();

        int Health();

        void ReceiveAttack(int power);

        void Cure();

    }       
}