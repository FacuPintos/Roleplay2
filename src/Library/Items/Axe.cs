namespace RoleplayGame
{
    public class Axe : IItems
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
                return 25;
            } 
        }
    }
}