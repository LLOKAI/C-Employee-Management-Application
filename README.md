# Employee Management System

## Overview

This C# console application is designed to manage employees, payrolls, and vacation days for a company. The application allows users to add, update, and delete employee records, manage payroll entries, and track vacation days. The system uses arrays to store data with a fixed size of 100 for each type of record.

## Preloaded Data

The application comes with some preloaded data for employees, payrolls, and vacations.

### Employees

- ID: 1, Name: Bobby John, Address: 69 SpiceBush Avenue, Email: bobbyj@gmail.com, Phone: 416-627-7760, Role: Owner
- ID: 2, Name: Amy Jo, Address: 420 Angel Grove Pkwy, Email: amyjo@gmail.com, Phone: 416-999-1111, Role: CEO
- ID: 3, Name: Joey Razul, Address: 631 Gotham Drive, Email: joeyr@gmail.com, Phone: 647-967-1112, Role: Developer
- ID: 4, Name: Trisha Pieck, Address: 78 Vista Blvd, Email: trishap@gmail.com, Phone: 905-812-1755, Role: Developer
- ID: 5, Name: Javier Ruiz, Address: 7660 James Potter Road, Email: javierr@gmail.com, Phone: 647-602-0771, Role: Secretary

### Payrolls

- ID: 1, EmployeeID: 1, Hours Worked: 20, Hourly Rate: 250.50, Date: (DateTime.Now.AddDays(-7))
- ID: 2, EmployeeID: 2, Hours Worked: 35, Hourly Rate: 200.00, Date: (DateTime.Now.AddDays(-14))
- ID: 3, EmployeeID: 3, Hours Worked: 50, Hourly Rate: 150.00, Date: (DateTime.Now.AddDays(-21))
- ID: 4, EmployeeID: 4, Hours Worked: 50, Hourly Rate: 150.00, Date: (DateTime.Now.AddDays(-28))
- ID: 5, EmployeeID: 5, Hours Worked: 40, Hourly Rate: 80.20, Date: (DateTime.Now.AddDays(-35))

### Vacations

- Vacation ID: 1, Employee ID: 1, Number of Days: 10
- Vacation ID: 2, Employee ID: 2, Number of Days: 14
- Vacation ID: 3, Employee ID: 3, Number of Days: 3
- Vacation ID: 4, Employee ID: 4, Number of Days: 10
- Vacation ID: 5, Employee ID: 5, Number of Days: 7

## Features

### Main Menu

- Modify employees
- Add payroll
- View vacation days
- Exit program

### Employee Menu

- List all employees
- Add a new employee
- Update an employee
- Delete an employee
- Return to main menu

### Payroll Menu

- Insert new payroll entry
- View payroll history for an employee
- Return to main menu

### Vacation Menu

- View vacation days
- Return to main menu
