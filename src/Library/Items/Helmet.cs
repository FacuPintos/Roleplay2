namespace RoleplayGame
{
    public class Helmet : IItems
    {
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