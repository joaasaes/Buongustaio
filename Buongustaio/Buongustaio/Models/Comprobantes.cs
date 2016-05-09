//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Buongustaio.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Comprobantes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Comprobantes()
        {
            this.Facturas = new HashSet<Facturas>();
            this.Retroalimentacion = new HashSet<Retroalimentacion>();
        }
        [Key]
        [Required]
        public string Folio { get; set; }
        public System.DateTime Fechayhora { get; set; }
        public string Orden { get; set; }
        public double Subtotal { get; set; }
        public double Total { get; set; }
        public string Descuento { get; set; }
        public int TerminacionTC { get; set; }
        public int Transaccion { get; set; }
        public decimal Cliente { get; set; }
    
        public virtual Clientes Clientes { get; set; }
        public virtual Ordenes Ordenes { get; set; }
        public virtual Promociones Promociones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Facturas> Facturas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Retroalimentacion> Retroalimentacion { get; set; }
    }
}
