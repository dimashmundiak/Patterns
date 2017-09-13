namespace Factory_Method
{
    public abstract class Developer
    {
        public string Name { get; set; }

        protected Developer(string n)
        {
            Name = n;
        }

        public abstract House Create();
    }
}
