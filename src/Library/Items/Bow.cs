namespace RoleplayGame
{
    public class Bow : IItems
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
                return 15;
            } 
        }
    }
}