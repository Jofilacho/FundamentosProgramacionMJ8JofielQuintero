using System;


namespace ArreglosUnidimensionalesRepaso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] edades;//Vector de enteros (declaración).
            int[] edades = new int[5];
            edades[1] = 35;
            edades[2] = 21;
            Console.WriteLine(edades[2]);

            double[] sueldos = new double[3] { 620.50, 456.91, 190.91 };
            Console.WriteLine(sueldos);

            for(int x = 0; x<sueldos.Length; x++)
            {
                Console.WriteLine(sueldos[x]);
            }

            string[] lenguajes = new string[4] { "php", "python", "c#", "js" };
            Console.WriteLine(lenguajes[3]);
            lenguajes[3]= "kotlin";
            Console.WriteLine(lenguajes[3]);

            var vector = new[] { 1, 5, 19 };
            Console.WriteLine(vector[1]);
        }
    }
}
