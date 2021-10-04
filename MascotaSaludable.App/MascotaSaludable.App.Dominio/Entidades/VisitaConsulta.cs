using System;
namespace MascotaSaludable.App.Dominio
{
    public class Consulta
    {
        public string FechaVisita {get; set;}
        public string HoraVisita {get; set;}
        public float Temperatura {get; set;}
        public float Peso {get; set;}
        public int FrecuenciaRespiratoria {get; set;}
        public int FrecuenciaCardiaca {get; set;}
        public string EstadoAnimo {get; set;}
        public int TarjetaVeterinario {get; set;}
        public bool Diagnostico {get; set;}
        public string Recomendaciones {get; set;}
        public string Medicamentos {get; set;}

        
    }
}