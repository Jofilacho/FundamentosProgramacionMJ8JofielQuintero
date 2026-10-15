using System;


namespace ArreglosBidimensionalesRepaso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] estaturas = new double[2,2];
            double[,] estaturas1 = { { 5, 2 }, 
                                     { 3, 8 } };
            Console.WriteLine(estaturas1[1,1]);
        }
    }
}
