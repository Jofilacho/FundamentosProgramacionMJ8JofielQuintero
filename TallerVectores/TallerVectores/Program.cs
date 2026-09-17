using System;


namespace TallerVectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //. Escribir un algoritmo que permita llenar un vector[15] con números enteros, y luego encuentre y muestre el valor máximo y mínimo de los números ingresados.
            int[] vector = new int[15];
            Random rnd = new Random();

            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = rnd.Next(-50, 51);
            }
            int maximo = vector[0];
            int minimo = vector[0];
        }   
    } 
}
