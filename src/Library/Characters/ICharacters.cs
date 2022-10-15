using System.Collections.Generic;
namespace RoleplayGame{

    public interface ICharacters
    {

        string Name { get; set; }

        int attack {get; set; }

        int defense {get; set; }

        int health {get; set; }

        int Health();

        List<IItems> inventory 
        void EquipItems();        

        void ReceiveAttack(int power);

        void Cure();

    }       
}