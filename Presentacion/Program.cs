using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
namespace Presentacion
{
    class Program
    {
        static void Main(string[] args)
        {

            
            string cedula, nombre, sexo;
            int edad;
            
            Console.WriteLine("Digite la Cedula:");
            cedula = Console.ReadLine();
            Console.WriteLine("Digite la Nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("Digite la Edad:");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite la Sexo (M/F):");
            sexo = Console.ReadLine();

            Persona persona = new Persona()
            {
                Cedula = cedula,
                Nombre = nombre,
                Edad = edad,
                Sexo=sexo
            };

            persona.CalcularPulsacion();


            Console.WriteLine($"Su Pulsacion es:{persona.Pulsacion}");
            Console.ReadKey();
        }
    }
}
