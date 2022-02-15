using System;

namespace DataAccess.Entities
{
    public class Employee
    {
        public int      IdPK     { get; set; }
        public string   IdNumber { get; set; }
        public string   Name     { get; set; }
        public string   Mail     { get; set; }
        public DateTime Birthday { get; set; }
    }
}
