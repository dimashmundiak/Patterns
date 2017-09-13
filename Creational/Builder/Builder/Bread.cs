using System.Text;

namespace Builder
{
    public class Bread
    {
        public Flour WheatFlour { get; set; }
        public Flour RyeFlour { get; set; }
        public Salt Salt { get; set; }
        public Additives Additives { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (WheatFlour != null)
                sb.Append("Пшеничная мука " + WheatFlour.Sort + "\n");
            if (RyeFlour != null)
                sb.Append("Ржаная мука " + RyeFlour.Sort + " \n");
            if (Salt != null)
                sb.Append("Соль \n");
            if (Additives != null)
                sb.Append("Добавки: " + Additives.Name + " \n");
            return sb.ToString();
        }
    }
}
