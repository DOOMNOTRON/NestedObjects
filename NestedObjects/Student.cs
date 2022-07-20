using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    /// <summary>
    /// Represent an individual college student
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Legal First Name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Legal Last Name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Date of Birth
        /// </summary>
        public DateOnly DateOfBirth { get; set; }

        /// <summary>
        /// Assigned School E-mail Address
        /// </summary>
        public string SchoolEmail { get; set; }

        /// <summary>
        /// The Student's Phone Number
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The Assigned Student's Advisor
        /// </summary>
        public Advisor AssignedAdvisor { get; set; }
    }
}
