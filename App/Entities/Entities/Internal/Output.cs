//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GridProteinFolding.Entities.Internal
{
    using System;
    using System.Collections.Generic;
    
    public partial class Output
    {
        public System.Guid guid { get; set; }
        public bool evolution { get; set; }
        public bool distribution { get; set; }
        public bool configuration { get; set; }
        public bool debug { get; set; }
        public bool histogram { get; set; }
        public bool trajectory { get; set; }
    
        public virtual Process Process { get; set; }
    }
}