using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PrinceWebApp.Models
{
    public class Doctor
    {
        public Guid DoctorId { get; set; }
        [ForeignKey("Person")]
        public new Guid PersonId { get; set; }
        public string Specialist { get; set; }
        public int CountryCode { get; set; }

        //public virtual ICollection<Person> Persons { get; set; }

    }
}