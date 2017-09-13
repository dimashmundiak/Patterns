namespace Factory_Method
{
    public class PanelDeveloper : Developer
    {
        public PanelDeveloper(string n) : base(n)
        {
        }

        public override House Create()
        {
            return new PanelHouse();
        }
    }
}
