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

            // Starts the stopwatch and prints 10 random numbers using RNGCryptoServiceProvider
            stopwatch.Start();
            for (int i = 0; i < 1000; i++)
            {
                rng.GetBytes(data);
                int value = BitConverter.ToInt32(data, 0);
                Console.Write(value + " ");
            }
            // Stops the stopwatch
            stopwatch.Stop();

            // Prints the amount of milliseconds it took the process to finish
            Console.WriteLine("\nTime: " + stopwatch.ElapsedMilliseconds + " ms\n");

            // Set the stopwatch back to 0 and starts it again
            stopwatch.Restart();

            // Prints 10 random numbers using Random
            for (int i = 0; i < 1000; i++)
            {
                rdm.Next(0, 1000000);
                Console.Write(rdm.Next(0, 1000000) + " "); 
            }
            stopwatch.Stop();

            Console.WriteLine("\nTime: " + stopwatch.ElapsedMilliseconds + " ms");

            Console.ReadKey();
        }
    }
}
