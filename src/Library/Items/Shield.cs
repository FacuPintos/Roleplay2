namespace RoleplayGame
{
    public class Shield : IItems
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
                return 14;
            }
        }
    }
}