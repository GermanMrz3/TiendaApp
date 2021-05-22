using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TiendaApp.Models
{
    public class Detalle
    {
        
        [Key]
        public int num_detalle { get; set; }
        public int id_factura { get; set; }
        
        public int id_producto { get; set; }
        public int cantidad { get; set; }
        public Nullable<decimal> precio { get; set; }

        public virtual Producto Producto { get; set; }

        public virtual Factura Factura { get; set; }
    }
}