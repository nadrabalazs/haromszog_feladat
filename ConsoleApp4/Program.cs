
namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UdvozloKep();
            List<string> menupontok = new List<string>();
            ListazMenu(menupontok);
            ValasztasMenubol(menupontok);
            menupontok.Add("Kerület számítása");
            menupontok.Add("Terület számítása");
            menupontok.Add("Pitagorasz tétel");
            menupontok.Add("Magassag tétel");
            menupontok.Add("Köré írható kör");
            menupontok.Add("Kilépés");
            Console.WriteLine("Vége!");
        }
        private static void ListazMenu(List<string> menupontok)
        {
            Console.SetCursorPosition(50, 2);
            Console.WriteLine("Kerület(F1)");
            Console.SetCursorPosition(50, 3);
            Console.WriteLine("Terület(F2)");
            Console.SetCursorPosition(50, 4);
            Console.WriteLine("Pitagorasz(F3)");
            Console.SetCursorPosition(50, 5);
            Console.WriteLine("Magasság(F4)");
            Console.SetCursorPosition(50, 6);
            Console.WriteLine("Köré írható kör(F5)");
            Console.SetCursorPosition(50, 7);
            Console.WriteLine("Kilépés(Esc)");

        // TODO: Nádra
        }

        private static void UdvozloKep()
        {
            Console.Clear();
            Console.SetCursorPosition(30, 0);
            Console.WriteLine("Üdvözlöm a háromszög szuper alkalmazásban!\n");
        }
        private static void Kilepes()
        {
            Console.Clear();
            Console.SetCursorPosition(40,5);
            Console.WriteLine("Viszont látásra!");
        // TODO: Nádra
        }
        private static void ValasztasMenubol(List<string> menupontok)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            switch (keyInfo.Key)
            {
                case ConsoleKey.F1:
                    KeruletSzamitas();
                    break;
                case ConsoleKey.F2:
                    TeruletSzamitas();
                    break;
                case ConsoleKey.F3:
                    Pitagorasz();
                    break;
                case ConsoleKey.F4:
                    MagassagTetel();
                    break;
                case ConsoleKey.F5: 
                    KoreIrtKor(); 
                    break;
                case ConsoleKey.Escape:
                    Kilepes();
                    break;
        // TODO: Nádra
            }
        }
        private static void KoreIrtKor()
        {
            Console.Clear();
            Console.WriteLine("Adja meg a háromszög oldalait és a területét:  ");
            double a =Convert.ToDouble (Console.ReadLine());
            double b =Convert.ToDouble (Console.ReadLine());
            double c =Convert.ToDouble (Console.ReadLine());
            double Ter =Convert.ToDouble (Console.ReadLine());
            Console.WriteLine($"A háromszög köré írható kör sugara: {(a+b+c)/4*Ter}");
        // TODO: Illés
        }
        private static void MagassagTetel()
        {
            Console.Clear();
            Console.WriteLine("Adja meg a háromszög területét és az egyik oldalát:");
            Console.WriteLine("Terület:");
            double T = Convert.ToDouble(Console.ReadLine());
            double oldal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Az oldalhoz tartozó magasság:{(T * 2) / oldal} ");

        // TODO: Illés
        }
        private static void KeruletSzamitas()
        {
            Console.Clear();
            Console.WriteLine("Add meg a három oldal hosszát:");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Kerület: {a + b + c}");
        // TODO: Nádra
        }
        private static void TeruletSzamitas()
        {
            Console.Clear();
            Console.WriteLine("Add meg egy alap hosszát és a háromszög magasságát:");
            double a = Convert.ToDouble(Console.ReadLine());
            double ma = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Terület: {(a * ma) / 2}");
        // TODO: Nádra
        }
        private static void Pitagorasz() 
        {
            Console.Clear();
            Console.WriteLine("Add meg az a és b oldal hosszát: ");
            double aNegyzet = Convert.ToDouble(Console.ReadLine());
            double bNegyzet = Convert.ToDouble(Console.ReadLine());
            double cNegyzet = Convert.ToDouble(Math.Sqrt((Math.Pow(aNegyzet, 2)) + Math.Pow(bNegyzet, 2)));
            Console.WriteLine($"C oldal = {cNegyzet}");    }
        // TODO: Simon
}
}
