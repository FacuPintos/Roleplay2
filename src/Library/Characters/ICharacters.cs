using System.Collections.Generic;
namespace RoleplayGame{

    public interface ICharacters
    {

        string name { get; set; }

        int attack {get; set; }

        int defense {get; set; }

        int health {get; set; }


        List<IItems> inventory{} 
        void EquipItems();        

        void ReceiveAttack(int power);

        void Cure();

    }       
}