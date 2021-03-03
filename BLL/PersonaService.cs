using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DAL;
namespace BLL
{
    public class PersonaService
    {
        PersonaRepository personaRepository;
        public PersonaService()
        {
            personaRepository = new PersonaRepository();
        }

        public string Guardar(Persona persona) 
        {
            try
            {
                personaRepository.Guardar(persona);
                return "Datos guardados Satisfaactoriamente";
            }
            catch (Exception exception)
            {

                return "Ocurrio el siguiente error: " + exception.Message;
            }
        }

        public ConsultaResponse Consultar()
        {
            try
            {
               return new ConsultaResponse(personaRepository.Consultar());  
            }
            catch (Exception exception)
            {
              return new ConsultaResponse("Ocurrio el siguiente error: " + exception.Message);
            }
        }





    }


    public class ConsultaResponse 
    {
        public List<Persona> Personas { get; set; }
        public string Mensaje { get; set; }

        public bool Error { get; set; }

        public ConsultaResponse(List<Persona> personas)
        {
            Personas = personas;
            Error = false;
        }

        public ConsultaResponse(string mensaje)
        {
            Mensaje = mensaje;
            Error = true;
        }

    }
}
