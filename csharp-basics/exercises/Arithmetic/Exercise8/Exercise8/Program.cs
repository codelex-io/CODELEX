using System;

namespace Exercise8
{
    class Program
    {
        static void CalculateWorkedHoursPay(string name, double hours, double pay)
        {
            string employeeName = name;
            double weekHours = hours;
            int baseHours = 40;
            int maxWeekHours = 60;
            double minPayPerHour = 8.00;
            double basePayPerHour = pay;
            double overtimeWorkedHourRate = 1.5;
            double overtimePay = basePayPerHour * overtimeWorkedHourRate;
            double overtimeHours = 0;
            double paidBaseHours = (double)baseHours * basePayPerHour;

            if(weekHours > (double)baseHours)
            {
                overtimeHours = weekHours - baseHours;
            }

            double paidOvertimeHours = overtimeHours * overtimePay;
            double totalPaid = paidBaseHours + paidOvertimeHours;
            int employeeNameRowSize = 25 - employeeName.Length;
            int basePayPerHourRowSize = 8 - basePayPerHour.ToString("0.00").Length;
            int weekHoursRowSize = 13 - weekHours.ToString().Length;
            int overtimeHoursRowSize = 15 - overtimeHours.ToString().Length;
            int paidBaseHoursRowSize = 15 - paidBaseHours.ToString("0.00").Length;
            int paidOvertimeHourRowSize = 13 - paidOvertimeHours.ToString("0.00").Length;
            int totalPaidRowSize = 8 - totalPaid.ToString("0.00").Length;

            if(weekHours > (double)maxWeekHours && basePayPerHour < minPayPerHour)
            {
                Console.WriteLine($"Max hours is {maxWeekHours} per week and min base pay is {minPayPerHour} per hour.");
            } else if (basePayPerHour < minPayPerHour)
            {
                Console.WriteLine($"Min base pay is {minPayPerHour} per hour.");
            } else if(weekHours > (double)maxWeekHours)
            {
                Console.WriteLine($"Max hours is {maxWeekHours} per week.");
            } else
            {
                Console.WriteLine("| Employee Name, Last Name | Base Pay | Hours Worked | Overtime Hours | Paid Base Hours | Paid overtime | In Total |");
                Console.WriteLine(
                    $"|{new String(' ', employeeNameRowSize)}{employeeName} |{new String(' ', basePayPerHourRowSize)}${basePayPerHour.ToString("0.00")} |{new String(' ', weekHoursRowSize)}{weekHours} |{new String(' ', overtimeHoursRowSize)}{overtimeHours} |{new String(' ', paidBaseHoursRowSize)}${paidBaseHours.ToString("0.00")} |{new String(' ', paidOvertimeHourRowSize)}${paidOvertimeHours.ToString("0.00")} |{new String(' ', totalPaidRowSize)}${totalPaid.ToString("0.00")} |"
                    );
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter employee name: ");
            string inputName = Console.ReadLine();

            Console.Write("Enter worked hours per week: ");
            double inputHours = double.Parse(Console.ReadLine());

            Console.Write("Enter base pay: ");
            double inputBasePay = double.Parse(Console.ReadLine());

            CalculateWorkedHoursPay(inputName, inputHours, inputBasePay);
            Console.ReadKey();
        }
    }
}
