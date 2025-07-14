/*
=============
🏆 Exercise
==============
*/

// 1. Create a base class "Employee" with the following protected properties:
// - Name (string)
// - Salary (double)
// - Position (string)
//
// 2. Implement a constructor in "Employee" that initializes its values.
//
// 3. Add a virtual method "CalculateBonus()" that returns a bonus of 5% of salary.
//
// 4. Add a method "ShowInfo()" that displays the employee's details:
// - Name
// - Job Title
// - Salary
// - Calculated Bonus
//
// 5. Create two classes derived from "Employee":
// - "TeamLeader": Their bonus is 10% of their salary.
// - "Developer": Their bonus is 7% of their salary.
//
// 6. Instantiate a list of employees with at least the following data:
// - Carlos (Team Leader, 5000)
// - Ana (Developer, 4000)
// - Laura (Team Leader, 6000)
// - Luis (Developer, 3500)
//
// 7. Iterate through the list of employees and display information for each one using the "ShowInfo()" method.


partial class Program
{
    static void EmployeeManager()
    {
        WriteLine("Employees Details");
        WriteLine("");

        List<Employee> employees = new()
        {
            new TeamLeader("Carlos", 5000),
            new Developer("Ana", 4000),
            new TeamLeader("Laura", 6000),
            new Developer("Luis", 3500),
        };

        foreach (var employee in employees)
        {
            employee.ShowInfo();
        }
    }
}


class Employee
{
    protected string? Name { get; set; }
    protected double Salary { get; set; }
    protected string? Position { get; set; }

    public Employee(string name, int salary, string position)
    {
        Name = name;
        Salary = salary;
        Position = position;
    }

    public virtual double CalculateBonus()
    {
        return Salary * 5 / 100;
    }

    public void ShowInfo()
    {
        WriteLine($"Name: {Name}, Salary: {Salary}, Position: {Position}, Bonus: {CalculateBonus():C}");
    }
}

class TeamLeader : Employee
{
    public TeamLeader(string name, int salary) : base(name, salary, "Team Leader")
    {
    }

    public override double CalculateBonus()
    {
        return Salary * 10 / 100;
    }
}

class Developer : Employee
{
    public Developer(string name, int salary) : base(name, salary, "Developer")
    {
    }

    public override double CalculateBonus()
    {
        return Salary * 7 / 100;
    }
}