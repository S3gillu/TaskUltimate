using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaskUltimate.Models
{
    public class TraineeVM
    {
        public int Id { get; set; }
        public string CurrentAddress { get; set; }
        public string Stream { get; set; }
        public string PermanentAddress { get; set; }
        public string FatherName { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
    }
}