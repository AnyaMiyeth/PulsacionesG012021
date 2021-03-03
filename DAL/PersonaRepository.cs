using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.IO;

namespace DAL
{
    public class PersonaRepository
    {
        string ruta = "Persona.txt";
        public void Guardar(Persona persona) 
        {
            FileStream file = new FileStream(ruta,FileMode.Append);
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine(persona.ToString());
            writer.Close();
            file.Close();
        }
        public void Eliminar(string identificacion) 
        { 
        
        }

        public List<Persona> Consultar() 
        {
            List<Persona> personas = new List<Persona>();
            FileStream file = new FileStream(ruta, FileMode.OpenOrCreate);
            StreamReader reader = new StreamReader(file);
            string linea = string.Empty;
            while ((linea= reader.ReadLine())!=null)
            {
                Persona persona = MapearPersona(linea);
                personas.Add(persona);
            }
            reader.Close();
            file.Close();
            return personas;
        }

        private static Persona MapearPersona(string linea)
        {
            string[] datoPersona = linea.Split(';');
            Persona persona = new Persona();
            persona.Identificacion = datoPersona[0];
            persona.Nombre = datoPersona[1];
            persona.Edad = int.Parse(datoPersona[2]);
            persona.Sexo = datoPersona[3];
            persona.Pulsacion = Convert.ToDecimal(datoPersona[4]);
            return persona;
        }

        public Persona BuscarPorIdentificacion(string identificacion) 
        {

            Persona persona = new Persona();
            return persona;
        }


        public void Modificar(Persona personaNew, string identificacion) 
        { 
        
        }

    }
}
