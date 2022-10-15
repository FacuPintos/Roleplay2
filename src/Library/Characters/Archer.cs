using System.Collections.Generic;
namespace RoleplayGame
{
    public class Archer : ICharacters 
    {
        private int health = 100; 
        public int attack;
        public int defense;
        List<IItems> inventory; 

        public Archer(string name, int attack, int defense)
        {
            this.Name = name;
            this.attack = attack;
            this.defense = defense;
            List<IItems> inventory = new List<IItems>();
        }

        public string Name { get; set; }
        public string attack { get; set; }
        public string defense { get; set; }
        public string Name { get; set; }

        
        /* public Bow Bow { get; set; }

        public Helmet Helmet { get; set; }

        Esto lo borramos debido a que equipa los objetos de forma rudimentaria

        */

        public void EquipItems()
        {

            for (int i = 0; i < inventory.Count; i++ )
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

        public int Health
        {
            get
            {
                return this.health;
            }
            private set
            {
                this.health = value < 0 ? 0 : value;
            }
        }

        public void ReceiveAttack(int power)
        {
            if (this.DefenseValue < power)
            {
                this.Health -= power - this.DefenseValue;
            }
        }

        public void Cure()
        {
            this.Health = 100;
        }
    }
}