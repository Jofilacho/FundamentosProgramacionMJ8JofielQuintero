using System;


namespace _18.ProgramacionModular
{
    internal class Program
    {
        static int añoActual = 2026;
        static void Main(string[] args) // static es un dato que es programacion orientada a objetos
        {
            Console.WriteLine("bienvenido al caso de fundamentos de programación");
            MostrarMensaje("Jofiel David");
            Console.WriteLine($"Jofiel David tiene {CalcularEdad()}");
            MostrarMensaje("Camilo");
            int añoNacimiento = 2000;
            Console.WriteLine($"Camilo tiene {CalcularEdad(añoNacimiento,añoActual)}años");
            CalcularEdad(añoNacimiento,añoActual);
            MostrarMensaje("Jofiel David","Quintero Ortiz");
            Console.ReadKey();
            BorrarPantalla();
        
        }
        //Funciones con parametrps
        static int CalcularEdad(int añoNacimiento, int añoActual)
        {
            return añoNacimiento - añoActual;
        }
        //Funciones sin parametros
        static int CalcularEdad()
        {
            int añoNacimiento = 1991;
            int añoActual = 2026;
            int edad = añoActual - añoNacimiento;
            return edad;
        }
        static void BorrarPantalla()
        {

            Console.Clear();
        }
        static void MostrarMensaje(string nombre)
        {
            Console.WriteLine($"Bienvenido,{nombre} al curso de Fundamentos de Programacion");
        }
        static void MostrarMensaje(String nombre,string apellidos)
        {
            Console.WriteLine($"Bienvenido,{nombre} {apellidos} al curso de fundamentos de programacion");
        }
    }
}
