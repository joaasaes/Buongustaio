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

    public partial class Facturas
    {
        [Key]
        [Required]
        public string Folio { get; set; }
        public string Comprobante { get; set; }
        public string RFC { get; set; }
    
        public virtual Comprobantes Comprobantes { get; set; }
        public virtual DatosFiscales DatosFiscales { get; set; }
    }
}
