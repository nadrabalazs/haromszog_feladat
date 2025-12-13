
namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UdvozloKep();
            List<string> menupontok = new List<string>();
            menupontok.Add("Kerület számítása(F1)");
            menupontok.Add("Terület számítása(F2)");
            menupontok.Add("Pitagorasz tétel(F3)");
            menupontok.Add("Magasság tétel(F4)");
            menupontok.Add("Köré írható kör sugara(F5)");
            menupontok.Add("Kilépés(Esc)");
            ListazMenu(menupontok);
            ValasztasMenubol(menupontok);
            Console.WriteLine("Vége!");
        }
        private static void ListazMenu(List<string> menupontok)
        {
            {
                Console.WriteLine("Válassz egy menüpontot!");
                int menuSor = menupontok.Count;
                foreach (string menuPont in menupontok)
                {
                    Console.SetCursorPosition(30, menuSor);
                    Console.WriteLine(menuPont);

                    menuSor++;
                }

            }
            // TODO: Nádra ListazMenu
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
            // TODO: Nádra Kilepes
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
                // TODO: Nádra ValasztasMenubol
            }
        }
        private static void KoreIrtKor()
        {
            Console.Clear();
            Console.WriteLine("Kilépéshez nyomja meg az Escape gombot!\nAdja meg a háromszög oldalait és a területét:");
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            if (keyInfo.Key == ConsoleKey.Escape)
            {
                Kilepes();
                return;
            }
            double a =Convert.ToDouble (Console.ReadLine());
            double b =Convert.ToDouble (Console.ReadLine());
            double c =Convert.ToDouble (Console.ReadLine());
            double Ter =Convert.ToDouble (Console.ReadLine());
            Console.WriteLine($"A háromszög köré írható kör sugara: {(a+b+c)/4*Ter}");
            // TODO: Illés KoreIrtKor
        }
        private static void MagassagTetel()
        {
            Console.Clear();
            Console.WriteLine("Kilépéshez nyomja meg az Escape gombot!\nAdja meg a háromszög területét és az egyik oldalát:");
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            if (keyInfo.Key == ConsoleKey.Escape)
            {
                Kilepes();
                return;
            }
            Console.WriteLine("Terület:");
            double T = Convert.ToDouble(Console.ReadLine());
            double oldal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Az oldalhoz tartozó magasság:{(T * 2) / oldal} ");

            // TODO: Illés MagassagTetel
        }
        private static void KeruletSzamitas()
        {
            Console.Clear();
            Console.WriteLine("Kilépéshez nyomja meg az Escape gombot!\nAdd meg a három oldal hosszát:");
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            if (keyInfo.Key == ConsoleKey.Escape)
            {
                Kilepes();
                return;
            }
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Kerület: {a + b + c}");
            // TODO: Nádra KeruletSzamitas
        }
        private static void TeruletSzamitas()
        {
            Console.Clear();
            Console.WriteLine("Kilépéshez nyomja meg az Escape gombot!\nAdd meg egy alap hosszát és a háromszög magasságát: ");
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            if (keyInfo.Key == ConsoleKey.Escape)
            {
                Kilepes();
                return;
            }
            double a = Convert.ToDouble(Console.ReadLine());
            double ma = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Terület: {(a * ma) / 2}");
            // TODO: Nádra TeruletSzamitas
        }
        private static void Pitagorasz() 
        {
            Console.Clear();
            Console.WriteLine("Kilépéshez nyomja meg az Escape gombot!\nAdd meg az a és b oldal hosszát:");
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            if (keyInfo.Key == ConsoleKey.Escape)
            {
                Kilepes();
                return;
            }
            double aNegyzet = Convert.ToDouble(Console.ReadLine());
            double bNegyzet = Convert.ToDouble(Console.ReadLine());
            double cNegyzet = Convert.ToDouble(Math.Sqrt((Math.Pow(aNegyzet, 2)) + Math.Pow(bNegyzet, 2)));
            Console.WriteLine($"C oldal = {cNegyzet}");    }
        // TODO: Simon Pitagorasz
    }
}
