using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TiendaApp.Models //Nombre del Proyecto.Nombre de carpeta
{
    public class Factura
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Factura()
        {
            this.Detalle = new HashSet<Detalle>();
        }
        [Key]
        public int id_factura { get; set; }
        public string num_factura { get; set; }
        [ForeignKey("Status")]
        public int id_cliente { get; set; }
        public string fecha { get; set; }
        public int num_pago { get; set; }
    
    
    //Llaves foranesas y dependecias
        public virtual Cliente Cliente { get; set; }
        public virtual Modo_Pago ModoPago { get; set; }
        public virtual ICollection<Detalle> Detalle { get; set; }
    }
}