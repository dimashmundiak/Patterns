namespace Singleton
{
    public class OS
    {
        private static OS _instance;

        public string Name { get; }

        private OS(string name)
        {
            Name = name;
        }

        public static OS GetInstance(string name)
        {
            if (_instance == null) _instance = new OS(name);
            return _instance;
        }

    }
}
