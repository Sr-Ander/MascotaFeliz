using System.Collections.Generic;
using MascotaSaludable.App.Dominio;

namespace MascotaSaludable.App.Persistencia.AppRepositorios
{
    public class RepositorioPersonaMemoria : IRepositorioPersona
    {
        
        List<Persona> Personas;

        public RepositorioPersonaMemoria()
        {
            Personas = new List<Persona>()
                {
                    new Persona{Identificacion= 111111111, Nombre="Anderson", Apellidos="Gomez Garcia", Telefono="2789145", CorreoElectronico="xxandersongomezgarciaxx@gmail.com"},
                    new Persona{Identificacion= 123456789, Nombre="Alberto", Apellidos = "Perez Olivh", Telefono="2876887", CorreoElectronico="AklbertoOlvih@gmail.com"},

                    new Persona{Identificacion= 987654321, Nombre ="Mario Andres", Apellidos ="Torres Niño", Telefono ="287989", CorreoElectronico="AndreSMArio@gmail.com"}
                };
            
        }
        public IEnumerable<Persona> GetAll()
        {
            return Personas;
        }

    }
}