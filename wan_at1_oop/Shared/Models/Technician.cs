using System;
using System.ComponentModel.DataAnnotations;

namespace wan_at1_oop.Shared.Models
{
    public class Technician : Employee
    {
        [Required]
        [RegularExpression(@"^[\dA][\dC][\d][\d][\d][\d]$",
            ErrorMessage = "Incorrect format")]
        public string Registration { get; set; }
        [Required(ErrorMessage = "Required.")]
        public string ExpiryDate { get; set; }
    }
}
