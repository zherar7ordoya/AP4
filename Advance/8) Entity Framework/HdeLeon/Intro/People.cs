//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Intro
{
    using System;
    using System.Collections.Generic;
    
    public partial class People
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public int idSexo { get; set; }
    
        public virtual Sexo Sexo { get; set; }
    }
}
