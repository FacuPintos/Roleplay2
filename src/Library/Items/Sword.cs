namespace RoleplayGame
{
    public class Sword : IItems
    {
        private string name; 
        public Sword (string name)
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
                return 20;
            } 
        }
    }
}