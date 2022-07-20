using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    /// <summary>
    /// Represents and individual COllege Advisor
    /// </summary>
    public class Advisor
    {
        /// <summary>
        /// The legal First Name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The Legal Last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// School assigned E-mail
        /// </summary>
        public string SchoolEmail { get; set; }

        /// <summary>
        /// Location of the Advisor's Office
        /// Building and room number
        /// </summary>
        public string OfficeLocation { get; set; }
    }
}