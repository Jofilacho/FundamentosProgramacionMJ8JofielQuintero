using System;

namespace TallerVectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //PUNTO 1
          /*  int[] vector = new int[15];

            //Llenar el vector
            Console.WriteLine("Ingrese 15 números enteros:");
            for (int i=0; i < 15; i++)
            {
                Console.Write($"Posición [{i}]: ");
                vector[i] = int.Parse(Console.ReadLine());
            }
            //Inicializar máximo y mínimo
            int maximo = vector[0];
            int minimo = vector[0];

            //Buscar máximo y mínimo
            for (int i = 1; i < 15; i++)
            {
                if (vector[i] > maximo)
                {
                    maximo = vector[i];
                }
                if (vector[i] < minimo)
                {
                    minimo = vector[i];
                }
            }

            //Mostrar resultados
            Console.WriteLine("\nResultados:");
            Console.WriteLine($"El máximo es: {maximo}");
            Console.WriteLine($"El mínimo es: {minimo}");*/

            //PUNTO 2
            //a. Crear 2 vectores del mismo tamaño ( ejemplo: tamaño 5) 
            int tamaño = 5;
            int[] vector1 = new int[tamaño];
            int[] vector2 = new int[tamaño];

            //Llenar el primer vector
            Console.WriteLine("-------LLENAR PRIMER VECTOR-------");
            for (int i = 0; i < tamaño; i++)
            {
                Console.Write($"Vector 1 - Posición [{i}]: ");
                vector1[i] = int.Parse(Console.ReadLine());
            }

            //b.Llenar el segundo vector
            Console.WriteLine("-------LLENAR SEGUNDO VECTOR-------");
            for (int i = 0; i < tamaño; i++)
            {
                Console.Write($"Vector 2 - Posición [{i}]: ");
                vector2[i] = int.Parse(Console.ReadLine());
            }
            //c. Comparar posición´por posición y d. Contar iguales
            int iguales = 0;
            for (int i = 0; i < tamaño; i++)
            {
                if (vector1[i] == vector2[i])
                {
                    iguales++;
                }
            }
            
            //e. Mostrar resultados
            Console.WriteLine($"\nResultados:");
            Console.WriteLine($"El número de elementos iguales en las mismas posiciones es: {iguales}");

        }
    }
}
