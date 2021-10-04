using System.Collections.Generic;
using MascotaSaludable.App.Dominio;

namespace MascotaSaludable.App.Persistencia.AppRepositorios
{
    public interface IRepositorioPersona
    {
        IEnumerable<Persona> GetAll();
    }
}