using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EFDemo.Models
{
    public class Player
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public DateTime Dob { get; set; }
    }
}