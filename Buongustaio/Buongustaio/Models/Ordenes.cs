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
    
    public partial class Ordenes
    {
        public string Id { get; set; }
        public decimal Cliente { get; set; }
        public string Pedido { get; set; }
        public System.DateTime Fecha { get; set; }
    
        public virtual Clientes Clientes { get; set; }
    }
}
