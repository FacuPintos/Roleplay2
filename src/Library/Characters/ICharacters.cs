using System.Collections.Generic;
namespace RoleplayGame{

    public interface ICharacters
    {

        string Name { get; set; }

        int Attack {get; set; }

        int Defense {get; set; }

        int Health {get; set; }

        List<IItems> items {get; set; }

        void EquipItems();

        int AttackValue();       

        int DefenseValue();

        int Health();

        void ReceiveAttack();

        void Cure();

    }       
}