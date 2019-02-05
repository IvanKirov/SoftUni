using System;

namespace Mankind
{
    public class Worker :Human
    {
        private decimal salary;
        private int workingHours;

        public Worker(string firstName, string lastName, decimal salary, int workingHours) : base(firstName, lastName)
        {
            Salary = salary;
            WorkingHours = workingHours;
        }

        public decimal Salary
        {
            get => salary; 
            set
            {
                if (value <= 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }
                salary = value;
            }
        }

        public int WorkingHours
        {
            get => workingHours; 
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }
                workingHours = value;
            }
        }

        public override string ToString()
        {
            var salaryPerHour = this.Salary / (this.WorkingHours * 5);
            return base.ToString() +
                   $"Week Salary: {this.Salary:F2}{Environment.NewLine}" +
                   $"Hours per day: {this.WorkingHours:F2}{Environment.NewLine}" +
                   $"Salary per hour: {salaryPerHour:F2}";
        }
    }
}
