using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using BLL;
namespace Presentacion
{
    class Program
    {
        static void Main(string[] args)
        {

            
            string cedula, nombre, sexo;
            int edad;
            PersonaService personaService = new PersonaService();
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
                Identificacion = cedula,
                Nombre = nombre,
                Edad = edad,
                Sexo=sexo
            };

            persona.CalcularPulsacion();
            Console.WriteLine($"Su Pulsacion es:{persona.Pulsacion}");
            Console.WriteLine(personaService.Guardar(persona));

            Console.WriteLine("/// Consulta de Datos///");
            ConsultaResponse response = personaService.Consultar();
            if (!response.Error)
            {
                foreach (var item in response.Personas)
                {
                    Console.WriteLine($"Identificacion: {item.Identificacion} Nombre:{item.Nombre} Edad:{item.Edad} Sexo:{item.Sexo} Pulsación:{item.Pulsacion}");
                }
            }
            else
            {
                Console.WriteLine(response.Mensaje);
            }

            Console.ReadKey();
        }
    }
}
