using Encapsulation;
using System.ComponentModel;

public class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the following Details");
        Console.Write("Employye Name\t");
        string empName = Console.ReadLine();

        Console.WriteLine("EmployeeLocation\t");
        string empLocation = Console.ReadLine();

        Console.WriteLine("salary ");
        int empSalary=Convert.ToInt32(Console.ReadLine());
        EncapsulationClass encapsulation = new EncapsulationClass()
       {
            name = empName,
            location = empLocation,
            salary = empSalary
        };

        Console.WriteLine("Employee name :-  " +encapsulation.name+
            "\nEmployee salary:-"+ encapsulation.salary+
            "\nEmployye Location "+encapsulation.location);

    }
}