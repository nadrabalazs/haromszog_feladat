
namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("Vége!");
            Magassagtetel();
            koreirtkor();
        }

        private static void koreirtkor()
        {
            Console.WriteLine("Adja meg a háromszög oldalait és a területét:  ");
            double a =Convert.ToDouble (Console.ReadLine());
            double b =Convert.ToDouble (Console.ReadLine());
            double c =Convert.ToDouble (Console.ReadLine());
            double Ter =Convert.ToDouble (Console.ReadLine());
            Console.WriteLine($"A háromszög köré írt kör sugara: {(a+b+c)/4*Ter}");
        }

        private static void Magassagtetel()
        {
            Console.WriteLine("Adja meg a háromszög területét és az egyik oldalát:");
            double oldal = Convert.ToDouble(Console.ReadLine());
            double T = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Az oldalhoz tartozó magasság:{(T * 2) / oldal} ");

        }
    }


}