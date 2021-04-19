using System;
using System.Collections.Generic;

using System.Text;
using System.Threading.Tasks;
using Entity;
using System.IO;
using System.Linq;

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

            foreach (var item in Consultar())
            {
                if (item.Identificacion.Equals(identificacion))
                {
                    return item;
                }
            }
            return null;
        }


        public void Modificar(Persona personaNew, string identificacion) 
        { 
        
        }




        public List<Persona> FiltroHombres()
        {
            List<Persona> personas = Consultar();
            return (from p in personas
                   where p.Sexo.Equals("M")
                   select p).ToList();
        }

        public int ContarHombres()
        {
            List<Persona> personas = Consultar();
            return (from p in personas
                    where p.Sexo.Equals("M")
                    select p).Count();
        }

        public List<Persona> FiltroMujeres()
        {
         return Consultar().Where(p=>p.Sexo.Equals("F")).ToList();  
        }


        public List<Persona> FiltroSexo(string tipo)
        {
            return Consultar().Where(p => p.Sexo.Equals(tipo)).ToList();
        }

        public int ContarPorSexo(string tipo)
        {
            return Consultar().Count(p=>p.Sexo.Equals(tipo));
        }

    }
}
