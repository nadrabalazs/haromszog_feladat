
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
            menupontok.Add("Kilépés");
            Console.WriteLine("Vége!");
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
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    KeruletSzamitas();
                    break;
                case 2:
                    TeruletSzamitas();
                    break;
                case 3:
                    Pitagorasz();
                    break;

        }
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
        }
        private static void Pitagorasz() 
        { 
            Console.WriteLine("Add meg az a négyzetét és b Négyzetét: ");
            double aNegyzet = Convert.ToDouble(Console.ReadLine());
            double bNegyzet = Convert.ToDouble(Console.ReadLine());
            double cNegyzet = Convert.ToDouble(Math.Sqrt(Math.Pow(aNegyzet, 2)) + Math.Pow(bNegyzet, 2));
            Console.WriteLine($"C oldal = {cNegyzet}");
            throw new NotImplementedException();
    }
}
}
