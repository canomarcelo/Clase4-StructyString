using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploManejoString
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string mensaje = "Este este es elmundode la programacion con .NET";
            int cantidad = 0;


            for (int i = 0; i < mensaje.Length; i++) 
            {
                if (mensaje[i] == 'e' || mensaje[i] == 'E')
                {
                    cantidad++;                    
                }
            }

            foreach (char letra in mensaje)
            {

                if (letra == 'e' || letra == 'E')
                {
                    cantidad++;
                }

            }

            Console.WriteLine($"La cantidad de la vocal e es: {cantidad}");

            Console.WriteLine(mensaje);
            Console.WriteLine(mensaje.ToLower());
            Console.WriteLine(mensaje.ToUpper());
            Console.WriteLine(mensaje.Substring(16,5));

            if (mensaje.Contains("mundo")) 
            {
                Console.WriteLine("la palabra mundo si esta!!");
            }

            string[] palabras = mensaje.Split(' ');




        }
    }
}
