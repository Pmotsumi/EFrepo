using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PrinceWebApp.Models
{
    public class Client
    {
        public Guid ClientId { get; set; }
        public new Guid PersonId { get; set; } 
        public Guid IllnessId { get; set; }

        public virtual Person person { get; set; }
        public virtual Illness illness { get; set; }

    }
}