using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wan_at1_oop.Shared.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required]
        public string EmployeeName { get; set; }
        [Required]
        public double RatePerHour { get; set; }
        [ForeignKey("PositionId")]
        [Required]
        public int PositionId { get; set; }
        [ForeignKey("BranchId")]
        [Required]
        public int BranchId { get; set; }


        public Branch Branch { get; set; }
        public Position Position { get; set; }

        static double CalculateWage(double rate, double hour)
        {
            return rate * hour;
        }
    }
}
