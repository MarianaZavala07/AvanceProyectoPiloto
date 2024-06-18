using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CRUDProductCatalog.Models
{
    public class ExpedienteModel
    {
        public ExpedienteModel()
        {
        }

       public Guid Id { get; set; }
        public string? Paciente { get; set; }
        public string? Descripcion { get; set; }
        public string Diagnostico { get; set; }
        public DateTime Fecha { get; set; }









    }


}