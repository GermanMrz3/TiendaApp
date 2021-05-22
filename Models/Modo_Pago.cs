using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TiendaApp.Models //Nombre del Proyecto.Nombre de carpeta
{
    public class Modo_Pago
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Modo_Pago()
        {
            this.Factura = new HashSet<Factura>();
        }
        
        [Key]
        public int num_pago { get; set; }
        public string nombre { get; set; }
        public string otros_detalles { get; set; }

        public virtual ICollection<Factura> Factura { get; set; }

    }
}