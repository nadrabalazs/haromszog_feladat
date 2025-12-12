
namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {

            UdvozloKep();
            Pitagorasz();

            Console.WriteLine("Vége!");
        }

        

        private static void UdvozloKep()
        {
            Console.Clear();
            Console.SetCursorPosition(30, 0);
            Console.WriteLine("Üdvözlöm a háromszög szuper alkalmazásban!");
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