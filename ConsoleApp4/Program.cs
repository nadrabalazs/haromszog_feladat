
namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ValasztasMenubol();
            TeruletSzamitas();
            List<string> menupontok = new List<string>();
            ListazMenu(menupontok);
            ValasztasMenubol(menupontok);
            menupontok.Add("Kerület számítása");
            menupontok.Add("Terület számítása");
            menupontok.Add("Kilépés");
            Pitagorasz();

            Console.WriteLine("Vége!");
        }

        

        private static void UdvozloKep()
        {
            Console.Clear();
            Console.SetCursorPosition(30, 0);
        private static void ListazMenu(List<string> menupontok)
        {
            Console.SetCursorPosition(35, 1);
            Console.WriteLine("Kerület, Nyomd meg az 1-est!");
            Console.SetCursorPosition(35, 2);
            Console.WriteLine("Terület, Nyomd meg az 2-est!");
            Console.SetCursorPosition(35, 3);
            Console.WriteLine("Magasságtétel, Nyomd meg az 3-ast!");
        }


        private static void ValasztasMenubol(List<string> menupontok)
        
        
        private static void Pitagorasz()

            Console.WriteLine("Add meg az a négyzetét és b Négyzetét: ");
            double aNegyzet = Convert.ToDouble(Console.ReadLine());
            double bNegyzet = Convert.ToDouble(Console.ReadLine());
            double cNegyzet = Convert.ToDouble(Math.Sqrt(Math.Pow(aNegyzet,2))+Math.Pow(bNegyzet,2));
            Console.WriteLine($"C oldal = {cNegyzet}");
            throw new NotImplementedException();
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    KeruletSzamitas();
                    break;
                case 2:
                    TeruletSzamitas();
                    break;
                

            }
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
            Console.WriteLine($"Terület: {(a * ma) / 2}");
            Console.WriteLine((a*ma)/2);
            Console.WriteLine((a*ma)/2);
            double ma = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine((a*ma)/2);
        }
    }
}