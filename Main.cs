//DYLAN GRANDJEAN
//February 10th, 2016
//Program in two parts, calculate a commission and a pay stub

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Constant declaration
            const double COMMISSION_RATE = 0.05,
                         FED_TAX = 0.2,
                         FICA_TAX = 0.08,
                         STATE_TAX = 0.02,
                         BENEFITS = 0.05;

            //Declaration and instantiation of variables
            double salesAmount = 80000,
                   hours = 30,
                   rateOfPay = 15,
                   commissionAmount,
                   grossPay,
                   netPay,
                   federalTaxAmount,
                   ficaAmount,
                   stateTaxAmount,
                   benefitsAmount;
            string namePart1 = "Joan",
                   namePart2 = "Dylan Grandjean";

            //Part1
            //Calculate the commission's amount
            commissionAmount = salesAmount * COMMISSION_RATE;

            //Display the result formatted to the console
            Console.WriteLine("*********************************************\n" +
                              "\tPart 1-Commission\n" +
                              "{0}'s commission for {1:c} is {2:c}",
                              namePart1, salesAmount, commissionAmount);

            //Part2
            //Calculate the gross pay from the hours worked and the rate of pay
            grossPay = hours * rateOfPay;
            federalTaxAmount = grossPay * FED_TAX;
            ficaAmount = grossPay * FICA_TAX;
            stateTaxAmount = grossPay * STATE_TAX;
            benefitsAmount = grossPay * BENEFITS;

            netPay = grossPay - (federalTaxAmount + ficaAmount + stateTaxAmount + benefitsAmount);

            //Display the net pay after tax deduction
            Console.WriteLine("\n\tPart 2-Acme Distributors\n" +
                              "*********************************************\n" +
                              "{0}\t\tPay Stub\n" +
                              "\tHours: {1}-Rate:{2:c}\n" +
                              "Gross Pay \t\t {3:c} \n" +
                              "Federal Tax \t\t {4:c} \n" +
                              "FICA \t\t\t {5:c} \n" +
                              "State Tax \t\t {6:c} \n" +
                              "Benefits \t\t {7:c} \n" +
                              "---------------------------------------------\n" +
                              "Net Pay \t\t {8:c}",
                              namePart2, hours, rateOfPay, grossPay, federalTaxAmount, 
                              ficaAmount, stateTaxAmount, benefitsAmount, netPay);
            Console.Read();
        }
    }
}
