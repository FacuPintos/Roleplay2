namespace RoleplayGame
{
    public class Staff : IItems
    {

        private string name; 
        public Staff (string name)
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
        public int Value 
        {
            get
            {
                return 100;
            } 
        }
        public string type
        {
            get
            {
                return "Attack";
            }
        }
    }
}