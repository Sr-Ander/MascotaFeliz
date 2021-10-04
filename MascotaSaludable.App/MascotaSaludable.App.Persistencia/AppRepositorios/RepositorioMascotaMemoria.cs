using System.Collections.Generic;
using MascotaSaludable.App.Dominio;

namespace MascotaSaludable.App.Persistencia.AppRepositorios
{
    public class RepositorioMascotaMemoria : IRepositorioMascota
    {
        
        List<Mascota> Mascotas;

        public RepositorioMascotaMemoria()
        {
            Mascotas = new List<Mascota>()
                {
                    new Mascota{IdentificacionDueno= 111111111, IdMascota=1, NombreMascota="Tito", FechaNacimiento="2/02/2019"},
                    new Mascota{IdentificacionDueno= 123456789, IdMascota=2, NombreMascota="Tato", FechaNacimiento="2/02/2019"},
                    new Mascota{IdentificacionDueno= 987654321, IdMascota=3, NombreMascota="Toto", FechaNacimiento="2/02/2019"}
                };          
        }
        public IEnumerable<Mascota> GetAll()
        {
            return Mascotas;
        }

    }
}