using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.ArregloBidimensional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arreglos bidimensionales - Matrices
            int[,] numeros = new int[2,3];
            //numeros[2, 1] = 45; //no se puede almacenar porque el indice de la fila no existe
            //numeros[1, 4] = 20; // no sse puede almacenar porque el indice de la columna no existe
            numeros[0, 0] = 12;
            numeros[0, 1] = 89;
            numeros[0, 2] = 46;
            numeros[1, 0] = 2;
            numeros[1, 1] = 54;
            numeros[1, 2] = 25;
            //recuperar dato de una posición
            Console.WriteLine($"Él número alamacenado en numeros[1,0] es: {numeros[1,0]}");
            //Recorrer matriz para llenar
            char[,] simbolos=new char[3,2];
            for(int i=0;i<3;i++)//recorrer las filas
            {
                for(int j=0;j<2;j++)//recorrer las columnas
                {
                    Console.WriteLine($"Escriba el caracter para los simbolos[{i},{j}]:");
                    simbolos[i, j] = char.Parse(Console.ReadLine());
                }
            }

            //Recorrer para recuperar los datos
            for(int i = 0; i < simbolos.GetLength(0); i++)
            {
                for(int j=0; j<simbolos.GetLength(1); j++)
                {
                    Console.Write($"{simbolos[i,j]} |");
                }
                Console.WriteLine();
            }

            //Otra forma de declarar e inicializar matridces
            string[,] nombres =
            {
                {"Ana","Alba","Carla","Juan"},
                {"Ferney","Guillermo","Maria","Carmenza" },
                {"Alejandro","Alex","Orlando","Pedro" }
            };
        }
    }
}
