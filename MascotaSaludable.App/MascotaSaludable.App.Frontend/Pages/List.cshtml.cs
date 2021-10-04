using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MascotaSaludable.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MascotaSaludable.App.Dominio;
using MascotaSaludable.App.Persistencia;

namespace MascotaSaludable.App.Frontend.Pages
{
    public class ListModel : PageModel
    {
        private readonly IRepositorioPersona repositorioPersonas;
        public IEnumerable <Persona> Personas {get; set;}
        public ListModel(IRepositorioPersona repositorioPersonas, IRepositorioMascota repositorioMascotas)
        {
            this.repositorioPersonas=repositorioPersonas;
            this.repositorioMascotas=repositorioMascotas;
        }

        public void OnGet()
            {
                Personas=repositorioPersonas.GetAll();
                Mascotas=repositorioMascotas.GetAll();

            }
        private readonly IRepositorioMascota repositorioMascotas;
        public IEnumerable<Mascota> Mascotas {get; set;}



    
    }



}