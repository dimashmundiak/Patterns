namespace Bridge
{
    public abstract class Programmer
    {
        protected ILanguage language;
        public ILanguage Language
        {
            set => language = value;
        }

        protected Programmer(ILanguage lang)
        {
            language = lang;
        }
        public virtual void DoWork()
        {
            language.Build();
            language.Execute();
        }
        public abstract void EarnMoney();
    }
}
