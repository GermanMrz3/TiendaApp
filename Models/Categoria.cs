using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TiendaApp.Models
{
    public class Categoria
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Categoria()
        {
            this.Producto = new HashSet<Producto>();
        }
        [Key]
        public int id_categoria { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }

        public virtual ICollection<Producto> Producto { get; set; }
    }    
}