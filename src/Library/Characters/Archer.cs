using System.Collections.Generic;
namespace RoleplayGame
{
    public class Archer : ICharacters 
    {
        public string name { get; set; }
        public int health { get; set; } 
        public int attack { get; set; }
        public int defense { get; set; }
        List<IItems> inventory;

        public Archer(string name, int attack, int defense, int health)
        {
            this.name = name;
            this.attack = attack;
            this.defense = defense;
            this.health = health;
            this.inventory = new List<IItems>();
        } 

        
        /* public Bow Bow { get; set; }

        public Helmet Helmet { get; set; }

        Esto lo borramos debido a que equipa los objetos de forma rudimentaria

        */

        public void EquipItems(string item)
        {

            for (int i = 0; i < inventory.Count; i++ )
            {

                if(inventory[i].Name == item)
                {
                    if(inventory[i].type == "Attack")
                    {
                        this.attack += inventory[i].Value;
                    }
                     else if(inventory[i].type == "Defense")
                    {
                        this.defense += inventory[i].Value;
                    }
                }
            }
        }

        public void PickUpItem(IItems item)
        {
            this.inventory.Add(item);
        }

        public void ReceiveAttack(int power)
        {
            if (this.defense < power)
            {
                this.health -= power - this.defense;
            }
        }

        public void Cure()
        {
            this.health = 100;
        }
    }
}