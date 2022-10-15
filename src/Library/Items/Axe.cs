namespace RoleplayGame
{
    public class Axe : IItems
    {
        private string name; 
        public Axe (string name)
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
                return 25;
            } 
        }
    }
}