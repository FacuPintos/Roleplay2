using System.Collections.Generic;
namespace RoleplayGame{

    public interface ICharacters
    {

        string name { get; set; }

        int attack {get; set; }

        int defense {get; set; }

        int health {get; set; }

        void EquipItems(string item);        

        void ReceiveAttack(int power);

        void Cure();

    }       
}