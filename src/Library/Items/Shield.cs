namespace RoleplayGame
{
    public class Shield : IItems
    {

        private string name; 
        public Shield (string name)
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
                return 14;
            }
        }
    }
}