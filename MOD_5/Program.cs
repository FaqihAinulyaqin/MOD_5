using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace MOD_5
{
    internal class Program
    {
        public class Penjumlahan<T>
        {
            public T JumlahTigaAngka<T>(T a, T b, T c) where T : IAdditionOperators<T, T, T>
            {
                return a + b + c;
            }
        }
        static void Main(string[] args)
        {
            Penjumlahan<int> JumlahTigaAngka = new Penjumlahan<int>();
            Console.WriteLine(JumlahTigaAngka.JumlahTigaAngka(13, 02, 22));
        }
    }
}
