namespace RoleplayGame
{
    public class Helmet : IItems
    {
        private string name; 
        public Helmet (string name)
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
                return 18;
            }
        }
    }
}