
namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {

            UdvozloKep();
            Magassagtetel();
            List<string> menupontok = new List<string>();
            menupontok.Add("Kerület számítása");
            menupontok.Add("Terület számítása");
            menupontok.Add("Kilépés");
            Console.WriteLine("Vége!");
        }

        private static void Magassagtetel()
        {
            Console.WriteLine("Adja meg a háromszög területét és az egyik oldalát:");
            double oldal = Convert.ToDouble(Console.ReadLine());
            double T = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine((T * 2) / oldal);

        }

        private static void UdvozloKep()
        {
            Console.Clear();
            Console.SetCursorPosition(30, 0);
            Console.WriteLine("Üdvözlöm a háromszög szuper alkalmazásban!");
        }
     

    }


}