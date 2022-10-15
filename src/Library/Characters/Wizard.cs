using System.Collections.Generic;
namespace RoleplayGame
{
    public class Wizard : ICharacters
    {
        public string name { get; set; }
        public int health { get; set; } 
        public int attack { get; set; }
        public int defense { get; set; }
        List<IItems> inventory;
        public SpellsBook spellsBook;
        public bool hasLearnedSpells;

        public Wizard(string name, int attack, int defense, int health)
        {
            this.name = name;
            this.attack = attack;
            this.defense = defense;
            this.health = health;
            this.hasLearnedSpells = false;
            List<IItems> inventory = new List<IItems>();
        } 

        public void useBook(){
            
            if(!this.hasLearnedSpells){
            this.attack += spellsBook.AttackValue;
            this.defense += spellsBook.DefenseValue;
            this.hasLearnedSpells = true;
            }
        }

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