namespace RoleplayGame
{
    public class Bow : IItems
    {
        private string name; 
        public Bow (string name)
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
                return "Attack";
            }
        }
        public int Value 
        {
            get
            {
                return 15;
            } 
        }

    }
}