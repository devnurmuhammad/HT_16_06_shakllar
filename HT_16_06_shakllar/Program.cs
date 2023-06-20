namespace HT_16_06_shakllar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tortburchak tortburchak = new Tortburchak();
            tortburchak.Compute(10, 5);
            Uchburchak uchburchak = new Uchburchak();
            uchburchak.Compute(10, 5);
            Aylana aylana = new Aylana();
            aylana.Compute(6);
        }
        public class Tortburchak : Shakl
        {
            public override void Compute(double a, double b)
            {
                Console.WriteLine($"To'g'ri to'rtburchakning yuzasi: {a * b}");
            }
        }
        public class Uchburchak : Shakl 
        {
            public override void Compute( double a, double b)
            {
                Console.WriteLine($"Uchburchakning yuzasi: {(a / 2) * b}");
            }
        }
        public class Aylana : Shakl
        {
            public override void Compute(double a, double b = 3.14)
            {
                Console.WriteLine($"Aylananing yuzasi: {b * (a * a)}");
            }
        }
    }
}