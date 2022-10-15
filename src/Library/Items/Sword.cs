namespace RoleplayGame
{
    public class Sword : IItems
    {
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