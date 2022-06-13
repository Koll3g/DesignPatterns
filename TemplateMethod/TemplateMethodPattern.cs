namespace tempalteMethod
{
    public abstract class AbstrakteKlasse
    {
        public abstract int PrimitiveOperation1();
        public abstract int PrimitiveOperation2();

        public void TemplateMethod()
        {
            int i = 1;
            i -= PrimitiveOperation1();
            i += PrimitiveOperation2();
            Console.WriteLine(i);
        }

    }
    public class KonkreteKlasse : AbstrakteKlasse
    {
        public override int PrimitiveOperation1()
        {
            return (DateTime.Today.DayOfWeek == DayOfWeek.Tuesday ? 1 : 2);
        }

        public override int PrimitiveOperation2()
        {
            return (DateTime.Today.Day >= 15 ? 1 : 2);
        }
    }
}