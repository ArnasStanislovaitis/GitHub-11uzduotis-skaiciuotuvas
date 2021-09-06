using System;

namespace GitHub_skaiciuotuvas
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nIveskite pasirinkima \n1.Lyginiu skaiciu spausdimas \n2.Nelyginiu skaiciu spausdimas\n3. Sudetis \n4.Atimtis \n5.Dalyba \n6.Daugyba");
                int Pasirinkimas = int.Parse(Console.ReadLine());
                if (Pasirinkimas == 1)
                {
                    LyginiuMetodas();
                }
                if (Pasirinkimas == 2)
                {
                    NelyginiuMetodas();
                }
                if (Pasirinkimas == 3) 
                {
                    Sudetis();
                }
                if (Pasirinkimas == 4)
                {
                    Atimtis();
                }
                if (Pasirinkimas == 5)
                {
                    Dalyba();
                }
                if (Pasirinkimas == 6)
                {
                    Daugyba();
                }
            }
            
        }
       
    }
}
