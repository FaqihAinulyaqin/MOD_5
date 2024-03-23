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
        public class SimpleDataBase<T>
        {
            private List<T> storeData { get; set; }
            private List<DateTime> InputDates { get; set; }

            public SimpleDataBase()
            {
                storeData = new List<T>();
                InputDates = new List<DateTime>();
            }

            public void AddNewData(T List)
            {
                storeData.Add(List);
                InputDates.Add(DateTime.Now);
            }

            public void PrintAllData()
            {
                for (int i = 0; i < storeData.Count; i++)
                {
                    Console.WriteLine("Data " + i + " berisi: " + storeData[i] + " yang disimpan pada waktu " + InputDates[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            Penjumlahan<int> JumlahTigaAngka = new Penjumlahan<int>();
            Console.WriteLine(JumlahTigaAngka.JumlahTigaAngka(13, 02, 22));
            SimpleDataBase<int> Data = new SimpleDataBase<int>();
            Data.AddNewData(13);
            Data.AddNewData(02);
            Data.AddNewData(22);
            Data.PrintAllData();
        }
    }
}
