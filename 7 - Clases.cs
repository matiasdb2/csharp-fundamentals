using System;

namespace Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            Sale sale1 = new Sale(100, DateTime.Now);
            Console.WriteLine(sale1.GetInfo()); // Printing the result to the console
        }
    }

    class Sale
    {
        int total;
        DateTime date;

        public Sale(int total, DateTime date)
        {
            this.total = total;
            this.date = date;
        }

        public string GetInfo()
        {
            return total + " " + date.ToLongDateString();
        }
    }
}
