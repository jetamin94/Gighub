using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EFDemo.Models
{
    public class Team
    {
        [Key]
        public string Id { get; set; }
        [MaxLength(30)]
        public string Name { get; set; }
    }
}