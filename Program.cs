using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {
        static Employee[] employees = new Employee[100];
        static Payroll[] payrolls = new Payroll[100];
        static Vacation[] vacations = new Vacation[100];
        static int employeeCount = 0;
        static int payrollCount = 0;
        static int vacationCount = 0;

        static void PreloadedData()
        {
            // preloading employees
            employees[0] = new Employee { ID = 1, Name = "Bobby John", Address = "69 SpiceBush Avenue", Email = "bobbyj@gmail.com", Phone = "416-627-7760", Role = "Owner" };
            employees[1] = new Employee { ID = 2, Name = "Amy Jo", Address = "420 Angel Grove Pkwy", Email = "amyjo@gmail.com", Phone = "416-999-1111", Role = "CEO" };
            employees[2] = new Employee { ID = 3, Name = "Joey Razul", Address = "631 Gotham Drive", Email = "joeyr@gmail.com", Phone = "647-967-1112", Role = "Developer" };
            employees[3] = new Employee { ID = 4, Name = "Trisha Pieck", Address = "78 Vista Blvd", Email = "trishap@gmail.com", Phone = "905-812-1755", Role = "Developer" };
            employees[4] = new Employee { ID = 5, Name = "Javier Ruiz", Address = "7660 James Potter Road", Email = "javierr@gmail.com", Phone = "647-602-0771", Role = "Secretary" };
            employeeCount = 5;

            // preloading payrolls
            payrolls[0] = new Payroll { ID = 1, EmployeeID = 1, HoursWorked = 20, HourlyRate = 250.50, Date = DateTime.Now.AddDays(-7) };
            payrolls[1] = new Payroll { ID = 2, EmployeeID = 2, HoursWorked = 35, HourlyRate = 200.00, Date = DateTime.Now.AddDays(-14) };
            payrolls[2] = new Payroll { ID = 3, EmployeeID = 3, HoursWorked = 50, HourlyRate = 150.00, Date = DateTime.Now.AddDays(-21) };
            payrolls[3] = new Payroll { ID = 4, EmployeeID = 4, HoursWorked = 50, HourlyRate = 150.00, Date = DateTime.Now.AddDays(-28) };
            payrolls[4] = new Payroll { ID = 5, EmployeeID = 5, HoursWorked = 40, HourlyRate = 80.20, Date = DateTime.Now.AddDays(-35) };
            payrollCount = 5;

            // preloading vacations
            vacations[0] = new Vacation ( 1, 1, 10 );
            vacations[1] = new Vacation (2, 2, 14);
            vacations[2] = new Vacation (3, 3, 3);
            vacations[3] = new Vacation (4, 4, 10);
            vacations[4] = new Vacation (5, 5, 7);
            vacationCount = 5;
        }
        static void Main(string[] args)
        {
            PreloadedData();
            while (true) 
            { 
                Console.WriteLine("Welcome, please choose a command: ");
                Console.WriteLine("1. Modify employees");
                Console.WriteLine("2. Add payroll");
                Console.WriteLine("3. View vacation days");
                Console.WriteLine("4. Exit program");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        EmployeeMenu();
                        break;
                    case "2":
                        PayrollMenu();
                        break;
                    case "3":
                        VacationMenu();
                        break;
                    case "4":
                        Console.Clear();
                        return;
                    default:
                        Console.WriteLine("Error, choice not recognized. Please try again.");
                        break;
                }
            }
        }

        static void EmployeeMenu()
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("Employee Menu:");
                Console.WriteLine("1. List all employees");
                Console.WriteLine("2. Add a new employee");
                Console.WriteLine("3. Update an employee");
                Console.WriteLine("4. Delete an employee");
                Console.WriteLine("5. Return to main menu");

                var choice = Console.ReadLine();

                switch (choice )
                {
                    case "1":
                        ListAllEmployees();
                        break;
                    case "2":
                        AddNewEmployee();
                        break;
                    case "3":
                        UpdateEmployee();
                        break;
                    case "4":
                        DeleteEmployee();
                        break;
                    case "5":
                        Console.Clear();
                        return;
                    default:
                        Console.WriteLine("Error, choice not recognized. Please try again.");
                        break;
                }
            }
        }

        static void PayrollMenu()
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("Payroll Menu:");
                Console.WriteLine("1. Insert new payroll entry");
                Console.WriteLine("2. View payroll history for an employee");
                Console.WriteLine("3. Return to main menu");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        InsertPayrollEntry();
                        break;
                    case "2":
                        ViewPayrollHistory();
                        break;
                    case "3":
                        Console.Clear();
                        return;
                    default:
                        Console.WriteLine("Error, choice not recognized. Please try again.");
                        break;
                }
            }
        }

        static void VacationMenu()
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("1. View vacation days");
                Console.WriteLine("2. Return to main menu");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ViewVacationDays();
                        break;
                    case "2":
                        Console.Clear();
                        return;
                    default:
                        Console.WriteLine("Error, choice not recognized. Please try again.");
                        break;
                }
            }
        }

        static void ListAllEmployees()
        {
            {
                Console.Clear();
                Console.WriteLine("All Employees:");
                for (int i = 0; i < employeeCount; i++)
                {
                    var employee = employees[i];
                    Console.WriteLine($"ID: {employee.ID}, Name: {employee.Name}, Role: {employee.Role}, Email: {employee.Email}, Phone: {employee.Phone}");
                }
                Console.WriteLine("Press any key to return...");
                Console.ReadKey();
            }
            Console.Clear();
        }
        static void AddNewEmployee()
        {
            {
                Console.Clear();
                var newEmployee = new Employee();

                Console.WriteLine("Add New Employee:");
                newEmployee.ID = employeeCount + 1;
                Console.Write("Name: ");
                newEmployee.Name = Console.ReadLine();
                Console.Write("Address: ");
                newEmployee.Address = Console.ReadLine();
                Console.Write("Email: ");
                newEmployee.Email = Console.ReadLine();
                Console.Write("Phone: ");
                newEmployee.Phone = Console.ReadLine();
                Console.Write("Role: ");
                newEmployee.Role = Console.ReadLine();

                employees[employeeCount] = newEmployee;
                employeeCount++;

                // new employees are given 14 days for vacation
                vacations[vacationCount] = new Vacation(vacationCount + 1, newEmployee.ID, 14);
                vacationCount++;

                Console.WriteLine("New employee added!");
                Console.WriteLine("Press any key to return...");
                Console.ReadKey();
            }
            Console.Clear();
        }
        static void UpdateEmployee()
        {
            { 
                Console.Clear();
                Console.Write("Enter the ID of the employee you want to update: ");
                if (int.TryParse(Console.ReadLine(), out int id) && id > 0 && id <= employeeCount && employees[id - 1] != null)
                {
                    var employee = employees[id - 1];
                    Console.WriteLine("Update Employee Info:");

                    Console.Write($"Name ({employee.Name}): ");
                    var name = Console.ReadLine();
                    if (!string.IsNullOrEmpty(name)) employee.Name = name;

                    Console.Write($"Address ({employee.Address}): ");
                    var address = Console.ReadLine();
                    if (!string.IsNullOrEmpty(address)) employee.Address = address;

                    Console.Write($"Email ({employee.Email}): ");
                    var email = Console.ReadLine();
                    if (!string.IsNullOrEmpty(email)) employee.Email = email;

                    Console.Write($"Phone ({employee.Phone}): ");
                    var phone = Console.ReadLine();
                    if (!string.IsNullOrEmpty(phone)) employee.Phone = phone;

                    Console.Write($"Role ({employee.Role}): ");
                    var role = Console.ReadLine();
                    if (!string.IsNullOrEmpty(role)) employee.Role = role;

                    Console.WriteLine("Employee updated successfully!");
                }
                else
                {
                    Console.WriteLine("Invalid ID or employee not found.");
                }
                Console.WriteLine("Press any key to return...");
                Console.ReadKey();
            }
            Console.Clear();
        }
        static void DeleteEmployee()
        {
            {
                Console.Clear();
                Console.Write("Enter the ID of the employee you wish to delete: ");
                if (int.TryParse(Console.ReadLine(), out int id) && id > 0 && id <= employeeCount && employees[id - 1] != null)
                {
                    employees[id - 1] = null;
                    for (int i = id - 1; i < employeeCount - 1; i++)
                    {
                        employees[i] = employees[i + 1];
                    }
                    employees[employeeCount - 1] = null;
                    employeeCount--;
                    Console.WriteLine("Employee deleted successfully!");
                }
                else
                {
                    Console.WriteLine("Invalid employee ID.");
                }
                Console.WriteLine("Press any key to return...");
                Console.ReadKey();
            }
            Console.Clear();
        }

        static void InsertPayrollEntry()
        {
            {
                Console.Clear();
                Console.WriteLine("Add New Payroll Entry:");

                var newPayroll = new Payroll();
                newPayroll.ID = payrollCount + 1;

                Console.Write("Employee ID: ");
                if (int.TryParse(Console.ReadLine(), out int employeeId) && employeeId > 0 && employeeId <= employeeCount && employees[employeeId - 1] != null)
                {
                    newPayroll.EmployeeID = employeeId;

                    Console.Write("Hours Worked: ");
                    if (int.TryParse(Console.ReadLine(), out int hoursWorked) && hoursWorked > 0)
                    {
                        newPayroll.HoursWorked = hoursWorked;

                        Console.Write("Hourly Rate: ");
                        if (double.TryParse(Console.ReadLine(), out double hourlyRate) && hourlyRate > 0)
                        {
                            newPayroll.HourlyRate = hourlyRate;

                            newPayroll.Date = DateTime.Now;
                            payrolls[payrollCount] = newPayroll;
                            payrollCount++;

                            // increment employees vacation days by 1 when a new payroll is added
                            vacations[employeeId - 1].NumberOfDays++;

                            Console.WriteLine("Payroll entry added successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Invalid hourly rate.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid hours worked.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid employee ID.");
                }
                Console.WriteLine("Press any key to return...");
                Console.ReadKey();
            }
            Console.Clear();
        }
        static void ViewPayrollHistory()
        {
            {
                Console.Clear();
                Console.Write("Enter the Employee ID to view payroll history: ");
                if (int.TryParse(Console.ReadLine(), out int employeeId) && employeeId > 0 && employeeId <= employeeCount && employees[employeeId - 1] != null)
                {
                    var employeePayrolls = payrolls.Where(p => p != null && p.EmployeeID == employeeId).ToArray();
                    if (employeePayrolls.Length > 0)
                    {
                        Console.WriteLine($"Payroll History for Employee ID {employeeId}:");
                        foreach (var payroll in employeePayrolls)
                        {
                            Console.WriteLine($"ID: {payroll.ID}, Hours Worked: {payroll.HoursWorked}, Hourly Rate: {payroll.HourlyRate}, Date: {payroll.Date}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No payroll history found for this employee.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid employee ID.");
                }
                Console.WriteLine("Press any key to return...");
                Console.ReadKey();
            }
            Console.Clear();
        }

        static void ViewVacationDays()
        {
            {
                Console.Clear();
                Console.WriteLine("Vacation Days:");
                for (int i = 0; i < vacationCount; i++)
                {
                    var vacation = vacations[i];
                    Console.WriteLine($"Vacation ID: {vacation.ID}, Employee ID: {vacation.EmployeeID}, Number of Days: {vacation.NumberOfDays}");
                }
                Console.WriteLine("Press any key to return...");
                Console.ReadKey();
            }
            Console.Clear();
        }
    }
}
