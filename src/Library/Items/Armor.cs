namespace RoleplayGame
{
    public class Armor : IItems
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
                return 25;
            }
        }
    }
}