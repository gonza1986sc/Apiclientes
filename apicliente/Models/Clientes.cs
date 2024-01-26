using System.ComponentModel.DataAnnotations;

namespace apicliente.Models
{
    public class Clientes

    {
        [Key]
        public String Rut { get; set; }

        public String Nombre { get; set; }


        public String Direccion { get; set; }
    }
}
