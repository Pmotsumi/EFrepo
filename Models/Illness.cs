using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PrinceWebApp.Models
{
    public class Illness
    {
        public Guid IllnessId { get; set; }
        public string IllnessName { get; set; }

    }
}