using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your annual income: ");
        decimal income = decimal.Parse(Console.ReadLine());

        decimal tax = CalculateIncomeTax(income);

        Console.WriteLine("Your calculated Income Tax payable is: " + tax);
    }

    static decimal CalculateIncomeTax(decimal income)
    {
        decimal taxPayable = 0;

        if (income > 150000)
        {
            taxPayable += (income - 150000) * 0.45m;
            income = 150000;
        }

        if (income > 50270)
        {
            taxPayable += (income - 50270) * 0.4m;
            income = 50270;
        }

        if (income > 12570)
        {
            taxPayable += (income - 12570) * 0.2m;
        }

        return taxPayable;
    }
}