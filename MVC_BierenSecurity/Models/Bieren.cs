//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_BierenSecurity.Models
{
    using Models;
    using System;
    using System.Collections.Generic;

    public partial class Bieren
    {
        public int BierNr { get; set; }
        public string Naam { get; set; }
        public int BrouwerNr { get; set; }
        public int SoortNr { get; set; }
        public Nullable<float> Alcohol { get; set; }
        public byte[] SSMA_TimeStamp { get; set; }
    
        public virtual Brouwer Brouwers { get; set; }
        public virtual Soort Soorten { get; set; }
    }
}
