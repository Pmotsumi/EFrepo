using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrinceWebApp.Models
{
    public enum Gender
    {
        M, F, O 
    }
    public enum Active
    {
        Y, N
    }

    public class Person
    {
        public Guid PersonId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Gender ? Gender { get; set; }
        public int IdNumber { get; set; }
        public string Email { get; set; }
        public int ContactNumber { get; set; }
        public Active ? Active { get; set; }

        //public ICollection<Doctor> Doctors { get; set; }

    }
}