using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CompetitonMerit_MVC.Models
{
    public class Subject
    {
        public int Id { get; set; }
        [Required]
        public string Subject_Name { get; set; }
        [Required]
        public string Subject_description { get; set; }
        public string Subject_language { get; set; }

    }
}
