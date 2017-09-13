namespace Singleton
{
    public class Computer
    {
        public OS Os { get; set; }

        public void Launch(string osName)
        {
            Os = OS.GetInstance(osName);
        }
    }
}
