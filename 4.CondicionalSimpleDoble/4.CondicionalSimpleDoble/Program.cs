using System;



namespace _4.CondicionalSimpleDoble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Estructura de contro Condicional
            //Simple
            //1.   Crea un algorimo que lea la edad de un usuario, si el usuario es mayor de 18, se debe mostrar el siguente mensaje: " Bienvenido a mi sitio web".
            /*byte edad = 0;
            Console.WriteLine("Ingrese su edad:");
            edad = Convert.ToByte( Console.ReadLine());
            if (edad >= 18)
            {
                //si la condicion es verdadera
                Console.WriteLine("Bienvenido a mi sitio web");
            }*/

            //2.   Crear un algoriltmo que permita ingresar el nombre y el sueldo de una persona, si el sueldo supero los 3000 pesos mostrar el mensaje en pantalla con el nombre de la persona, indicando que debe abonar impuestos.
            /*string nombre = " ";
            float sueldo = 0.0f;

            Console.WriteLine("Ingrese su nombre:");
            nombre = Console.ReadLine();
            
            Console.WriteLine("Ingrese su sueldo:");
            sueldo= Convert.ToSingle (Console.ReadLine());

            if (sueldo >= 3000)
            {
                Console.WriteLine ("Debes abonar impuestos" +" "+ nombre );
            }*/
            byte edad = 0;
            Console.WriteLine("Ingrese su edad:");
            edad = Convert.ToByte(Console.ReadLine());
            if (edad >= 18)
            {
                //si la condicion es verdadera
                Console.WriteLine("Bienvenido a mi sitio web");
            }
            else
            {
                Console.WriteLine("No es apto para el contenido del sitio web");
            }
          
        }
    }
}


