using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PrinceWebApp.Models
{
    public class Visit
    {
        public int VisitId { get; set; }
        public Guid DoctorId { get; set; }
        public Guid ClientId { get; set; }

        public virtual Doctor doctor { get; set; }
        public virtual Client client { get; set; }
    }
}