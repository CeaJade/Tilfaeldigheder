using System;
using System.Diagnostics;
using System.Security.Cryptography;

namespace Tilfældigheder
{
    class Program
    {
        static void Main(string[] args)
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] data = new byte[4];

            Random rdm = new Random();

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            for (int i = 0; i < 10; i++)
            {
                rng.GetBytes(data);
                int value = BitConverter.ToInt32(data, 0);
                Console.Write(value + " ");
            }
            stopwatch.Stop();

            Console.WriteLine("\nTime: " + stopwatch.ElapsedMilliseconds + " ms\n");


            stopwatch.Restart();
            for (int i = 0; i < 10; i++)
            {
                Console.Write(rdm.Next(0, 1000000) + " "); 
            }
            stopwatch.Stop();

            Console.WriteLine("\nTime: " + stopwatch.ElapsedMilliseconds + " ms");

            Console.ReadKey();
        }
    }
}
