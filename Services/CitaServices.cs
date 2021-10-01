using Cita.Models;
using System.Collections.Generic;
using System.Linq;
using Cita.Controllers;


namespace Cita.Services
{
    public static class CitaServices
    {
        static List<Citas> citas { get; set; }
        static int nextId = 3;

        public static List<Citas> GetAll() => citas;

        public static Citas Get(int id) => citas.FirstOrDefault(p => p.CitaId == id);

        public static void Add(Citas cita)
        {
            cita.CitaId = nextId++;
            citas.Add(cita);
        }

        public static void Delete(int id)
        {
            var cita = Get(id);
            if (cita is null)
                return;

            citas.Remove(cita);
        }

        public static void Update(Citas cita)
        {
            var index = citas.FindIndex(p => p.CitaId == cita.CitaId);
            if (index == -1)
                return;

            citas[index] = cita;
        }
    }
}