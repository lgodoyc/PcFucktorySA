//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PCFucktory.DALC
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bodega
    {
        public Bodega()
        {
            this.MovimientoDetalle = new HashSet<MovimientoDetalle>();
            this.MovimientoDetalle1 = new HashSet<MovimientoDetalle>();
        }
    
        public int Bodega_ID { get; set; }
        public string Nombre { get; set; }
        public int Ubicacion_ID { get; set; }
    
        public virtual ICollection<MovimientoDetalle> MovimientoDetalle { get; set; }
        public virtual ICollection<MovimientoDetalle> MovimientoDetalle1 { get; set; }
        public virtual Ubicacion Ubicacion { get; set; }
    }
}
