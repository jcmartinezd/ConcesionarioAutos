//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConcesionarioAutos.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Factura
    {
        public int IdFactura { get; set; }
        public Nullable<int> IdCliente { get; set; }
        public Nullable<int> IdVehiculo { get; set; }
        public Nullable<int> Fecha { get; set; }
        public Nullable<int> Valor { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual Vehiculo Vehiculo { get; set; }
    }
}