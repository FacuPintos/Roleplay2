namespace RoleplayGame
{
    public class Armor : IItems
    {
        private string name; 
        public Armor (string name)
        {
            this.name = name;
        }
        public string Name 
        {
            get
            {
                return name;
            }

        }
        public string type
        {
            get
            {
                return "Defense";
            }
        }
        public int Value
        {
            get
            {
                return 25;
            }
        }
    }
}