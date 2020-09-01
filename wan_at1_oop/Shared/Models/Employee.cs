using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wan_at1_oop.Shared.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "Required.")]
        [RegularExpression(@"^[a-zA-Z]*$",
         ErrorMessage = "Must be english char and no space.")]
        [MaxLength(20,
            ErrorMessage = "Must within 20 characters")]
        [MinLength(3,
            ErrorMessage = "Must not less than 3 characters")]
        public string EmployeeName { get; set; }
        [Required]
        [Range(18, 80,
        ErrorMessage = "{1} - {2}")]
        [RegularExpression(@"^[\d][\d]\.[\d][\d]$",
         ErrorMessage = "Incorrect Format")]
        public double RatePerHour { get; set; }
        [ForeignKey("PositionId")]
        [Required]
        [Range(1, 2,
        ErrorMessage = "Not valid")]
        public int PositionId { get; set; }
        [ForeignKey("BranchId")]
        [Required]
        [Range(1, 3,
        ErrorMessage = "Not valid")]
        public int BranchId { get; set; }


        public Branch Branch { get; set; }
        public Position Position { get; set; }

        static double CalculateWage(double rate, double hour)
        {
            return rate * hour;
        }
    }
}
