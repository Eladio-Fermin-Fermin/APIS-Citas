using System;
using System.Collections.Generic;


namespace Cita.Models
{
    public class Citas
    {
        public int CitaId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Telefono { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public string Descripcion { get; set; }


    }
}

