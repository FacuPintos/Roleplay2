namespace RoleplayGame
{
    public class Spell : IMagic
    {
        public string type = "Spell"
        public int AttackValue
        {
            get
            {
                return 70;
            }
        }

        public int DefenseValue
        {
            get
            {
                return 70;
            }
        }
    }
}