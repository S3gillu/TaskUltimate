using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TaskUltimate.Models
{
    public class Trainee
    {   [Key]
        public int LearnerId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        public virtual TraineeDetail Students { get; set; }
    }
}