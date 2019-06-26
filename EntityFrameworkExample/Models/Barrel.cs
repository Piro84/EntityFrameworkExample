using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EntityFrameworkExample.Models
{
    public class Barrel
    {
        [Key]
        public int Id { get; set; }
        public double Radius { get; set; }
    }
}