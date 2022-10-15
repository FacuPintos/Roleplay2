using System.Collections.Generic;
namespace RoleplayGame{

    public interface ICharacters
    {

        string Name { get; set; }

        int attack {get; set; }

        int defense {get; set; }

        int health {get; set; }

        List<IItems> inventory {get; set; }

        void EquipItems();

        int Health();

        void ReceiveAttack();

        void Cure();

    }       
}