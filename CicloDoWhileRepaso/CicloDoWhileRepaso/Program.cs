using System;


namespace CicloDoWhileRepaso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //do{operaciones}
            //while(expresión booleana);
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i <= 10);

            Console.ReadLine();
        }
    }
}
