using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TiendaApp.Models //Nombre del Proyecto.Nombre de carpeta
{
    public class Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cliente()
        {
            this.Factura = new HashSet<Factura>();
        }

        [Key]
        public int id_cliente { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string direccion { get; set; }
        public string fecha_nacimiento { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public virtual ICollection<Factura> Factura { get; set; }
    }
}