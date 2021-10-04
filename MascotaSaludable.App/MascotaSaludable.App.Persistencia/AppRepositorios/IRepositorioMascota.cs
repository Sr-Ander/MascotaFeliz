using System.Collections.Generic;
using MascotaSaludable.App.Dominio;

namespace MascotaSaludable.App.Persistencia.AppRepositorios
{
    public interface IRepositorioMascota
    {
        IEnumerable<Mascota> GetAll();
    }
}
