using System;

namespace DPM235505_NLThanhDat_TH4_P01_ExtractMethod.After
{
    public class OrderProcessorRefactored
    {
        public void PrintOwing(string name, double amount)
        {
            PrintBanner();
            double outstanding = CalculateOutstanding(amount);
            PrintDetails(name, outstanding);
        }

        private void PrintBanner()
        {
            Console.WriteLine("*****************************");
            Console.WriteLine("**** Customer Owes ****");
            Console.WriteLine("*****************************");
        }

        private double CalculateOutstanding(double amount)
        {
            return amount * 1.1;
        }

        private void PrintDetails(string name, double outstanding)
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Amount: " + outstanding);
        }
    }
}