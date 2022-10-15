using System.Collections.Generic;
namespace RoleplayGame
{
    public class Archer : ICharacters 
    {
        private int health = 100; // bien

        public Archer(string name)
        {
            this.Name = name;
            List<IItems> inventory = new List<IItems>(); 
        }

        public string Name { get; set; }
        
        /* public Bow Bow { get; set; }

        public Helmet Helmet { get; set; }

        Esto lo borramos debido a que equipa los objetos de forma rudimentaria

        */

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