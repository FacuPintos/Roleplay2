namespace RoleplayGame
{
    public class Staff : IItems
    {
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