using System;

namespace CicloForRepaso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int suma = 0;
            for (int i = 1; i <= 10; i++)
            {
                suma = suma + i;
                //Console.WriteLine(i);
            }
            //Console.ReadKey();
            Console.WriteLine("La suma es:"+suma);*/
            //Calcular el promedio de n calificaciones
            int num;
            double suma = 0;
            Console.WriteLine("Cuantas calificaciones se van a promediar?");
            num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine("Escribe la calificación "+i);
                double calif=double.Parse(Console.ReadLine());
                suma=suma+calif;
            }
            double promedio = suma / num;
            Console.WriteLine("El promedio es:" + promedio);
        }
    }
}
