using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Employee
    {
        public int ID {  get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Role { get; set; }
    }

    public class Payroll
    {
        public int ID { get; set; }
        public int EmployeeID { get; set; }
        public int HoursWorked { get; set; }
        public double HourlyRate { get; set; }
        public DateTime Date { get; set; }
    }

    public class Vacation
    {
        public int ID { get; set; }
        public int EmployeeID { get; set; }
        public int NumberOfDays { get; set; }

        public Vacation(int id, int employeeID, int numberOfDays)
        {
            ID = id;
            EmployeeID = employeeID;
            NumberOfDays = numberOfDays;
        }
    }
}
