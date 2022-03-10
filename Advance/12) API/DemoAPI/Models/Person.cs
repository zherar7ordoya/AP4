using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoAPI.Models
{
    /// <summary>
    /// Represents one specific person.
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Id from SQL.
        /// </summary>
        public int Id { get; set; } = 0;

        /// <summary>
        /// The user's first name.
        /// </summary>
        public string Firstname { get; set; } = string.Empty;

        /// <summary>
        /// The user's last name.
        /// </summary>
        public string Lastname { get; set; } = string.Empty;
    }
}