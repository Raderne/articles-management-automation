//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MakalelerManager
{
    using System;
    using System.Collections.Generic;
    
    public partial class Makaleler
    {
        public int MakaleID { get; set; }
        public string MakaleYazar { get; set; }
        public string MakaleBaslik { get; set; }
        public string MakaleIcerik { get; set; }
        public string MakaleKategori { get; set; }
        public byte[] MakaleResim { get; set; }
        public Nullable<int> PersonelID { get; set; }
    
        public virtual Personeller Personeller { get; set; }
    }
}
