using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploStruct
{
    public struct FechaNacimiento
    {
        public int dia;
        public int mes;
        public int anio;
    }
    
    public struct Mascota
    {
        public string nombre;
        public short edad;
        public float peso;
        public char sexo;
        public bool tieneDuenio;

        public FechaNacimiento fecha;
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Mascota pepito;

            

            Mascota[] listaMascotas = new Mascota[10]; 

            pepito.nombre = "Pepito";
            pepito.edad = 5;
            pepito.peso = 0.200f;
            pepito.sexo = 'M';
            pepito.tieneDuenio = true;

            Console.WriteLine("Ingrese el nombre de la mascota:");
            pepito.nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el nombre de la mascota:");
            listaMascotas[3].nombre = Console.ReadLine();

            Console.WriteLine("Ingrese la edad de la mascota:");
            pepito.edad = short.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese El peso de la mascota:");
            pepito.peso = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese El peso de la mascota:");
            pepito.sexo = char.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese El MEs:");
            pepito.fecha.mes = int.Parse(Console.ReadLine());


            Console.WriteLine($"El nombre de la mascota es: {pepito.nombre}");





        }
    }
}
