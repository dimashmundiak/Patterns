namespace Factory_Method
{
    public class WoodDeveloper : Developer
    {
        public WoodDeveloper(string n) : base(n)
        {
        }

        public override House Create()
        {
            return new WoodHouse();
        }
    }
}
