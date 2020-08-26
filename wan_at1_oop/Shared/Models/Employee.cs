using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace wan_at1_oop.Shared.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public double RatePerHour { get; set; }
        [ForeignKey("PositionId")]
        public int PositionId { get; set; }
        [ForeignKey("BranchId")]
        public int BranchId { get; set; }


        public Branch Branch { get; set; }
        public Position Position { get; set; }

        static double CalculateWage(double rate, double hour)
        {
            return rate * hour;
        }
    }
}
