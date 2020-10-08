using EmployeeMGRProject;
using System;
using System.Dynamic;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace EmployeeMGRProject
{
    class Staff
    {
        private string nameOfStaff;
        private const int hourlyRate = 30;
        private int hWorked;
        public int HoursWorked
        { get; set; }

        public void PrintMessage()
        {
            Console.WriteLine("Calculating Pay...");
        }
        public int CalculatePay()
        {
            PrintMessage();

            int staffPay;
            staffPay = hWorked * hourlyRate;

            if (hWorked > 0)
                return staffPay;
            else
                return 0;
        }
        public int CalculatePay(int Bonus, int Allowance)
        {
            PrintMessage();
            if (hWorked > 0)
                return hWorked * hourlyRate + Bonus + Allowance;
            else
                return 0;
        }
        public override string ToString()
        {
            return "Name of Staff = " + nameOfStaff + ",hourlyRate = " + hourlyRate + ", hWorked = " + hWorked;
        }
    }
   
    public Staff (string name)
    {
        nameOfStaff = name;
        Console.WriteLine("\n" + nameOfStaff);
        Console.WriteLine("------------------------");
    }
    public Staff(string firstName + string lastName)
    {
        nameOfStaff = firstName + "" +lastName
    }
}  
   class Program
    {
        static void Main(string[] args)
        {


        int pay;
        Staff staff1 = new Staff("Peter");
        staff1.HoursWorked = 160;
        pay = staff1.CalculatePay(1000, 400);
        Console.WriteLine("Pay = {0}", pay);



            string userName = "";
            int userAge = 0;
            int currentYear = 0;

            Console.Write("Please enter your name: ");
            userName = Console.ReadLine();
            Console.Write("Please enter your age: ");
            userAge = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the current year: ");
            if (userAge < 0 || userAge > 100)
            {
                Console.WriteLine("Invalid Age");
                Console.WriteLine("Age must be between 0 and 100");
            }
            else if (userAge < 18)
                Console.WriteLine("Sorry you are Underage");
            else if (userAge < 21)
                Console.WriteLine("You need Parental consent");
            else
            {
                Console.WriteLine("Congratulations!");
                Console.WriteLine("You may sign up for the event !");
            }

            currentYear = Convert.ToInt32(Console.ReadLine());

            {
                Console.WriteLine("Hello World! My name is {0} and I am  {1} years old. I was born in {2}.", userName, userAge, currentYear - userAge);

            }
        }
    }
