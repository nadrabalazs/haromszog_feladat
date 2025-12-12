
namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TeruletSzamitas();
            KeruletSzamitas();
            UdvozloKep();
            Pitagorasz();

            List<string> menupontok = new List<string>();
            menupontok.Add("Kerület számítása");
            menupontok.Add("Terület számítása");
            menupontok.Add("Kilépés");
            ListazMenu(menupontok);
            Console.WriteLine("Vége!");
        }

        

        private static void UdvozloKep()
        {
            Console.Clear();
            Console.SetCursorPosition(30, 0);
            Console.WriteLine("Üdvözlöm a háromszög szuper alkalmazásban!");
        }
        private static void ListazMenu(List<string> menupontok)
        {

        }

        private static void KeruletSzamitas()
        {
            Console.Clear();
            Console.WriteLine("Add meg a három oldal hosszát:");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Kerület: {a + b + c}");
        }
        private static void TeruletSzamitas()
        {
            Console.Clear();
            Console.WriteLine("Add meg egy alap hosszát és a háromszög magasságát:");
            double a = Convert.ToDouble(Console.ReadLine());
            double ma = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine((a*ma)/2);
        }
        private static void Pitagorasz()
        {
            Console.WriteLine("Add meg az a négyzetét és b Négyzetét: ");
            double aNegyzet = Convert.ToDouble(Console.ReadLine());
            double bNegyzet = Convert.ToDouble(Console.ReadLine());
            double cNegyzet = Convert.ToDouble(Math.Sqrt(Math.Pow(aNegyzet,2))+Math.Pow(bNegyzet,2));
            Console.WriteLine($"C oldal = {cNegyzet}");
            throw new NotImplementedException();
        }
    }
}