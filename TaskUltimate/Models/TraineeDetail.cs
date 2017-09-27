using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TaskUltimate.Models
{
    public class TraineeDetail
    {   [Key]
        public int LearnerId { get; set; }
        public string CurrentAddress { get; set; }
        public string Stream { get; set; }
        public string PermanentAddress { get; set; }
        public string FatherName { get; set; }
        public virtual Trainee Learn { get; set; }
    }
}