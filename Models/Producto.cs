using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TiendaApp.Models
{
    public class Producto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Producto()
        {
            this.Detalle = new HashSet<Detalle>();
        }
        [Key]
        public int id_producto { get; set; }
        public string nombre { get; set; }
        public Nullable<decimal> precio { get; set; }
        public Nullable<int> stock { get; set; }
        public Nullable<int> id_categoria { get; set; }

        public virtual Categoria Categoria { get; set; }
        public virtual ICollection<Detalle> Detalle { get; set; }
    }    
}