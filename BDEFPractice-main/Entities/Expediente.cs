using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDProductCatalog.Entities
{
    public class Expediente
    {

        public Guid Id { get; set; }
        public string? Paciente { get; set; }
        public string? Descripcion { get; set; }
        public string Diagnostico { get; set; }
        public DateTime Fecha { get; set; }

    }

    }