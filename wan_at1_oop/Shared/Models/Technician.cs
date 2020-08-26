using System;
using System.ComponentModel.DataAnnotations;

namespace wan_at1_oop.Shared.Models
{
    public class Technician : Employee
    {
        [Required]
        public string Registration { get; set; }
        [Required]
        public string ExpiryDate { get; set; }
    }
}
