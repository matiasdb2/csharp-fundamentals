﻿using System;

namespace Propiedades
{
    class Program
    {
        public static void Main(string[] args)
        {
            Sale mySale = new Sale(100, DateTime.Now);
            mySale.Total = -120;
            Console.WriteLine(mySale.Total);
            Console.WriteLine(mySale.Date);
        }
    }

    class Sale
    {
        private int total;
        private DateTime date;

        public string Date
        {
            get
            {
                return date.ToLongDateString();
            }
        }
        
        public int Total
        {
            get
            {
                return total;
            }
            // para que retorne cero en caso de número negativo
            set
            {
                if (value < 0)
                    value = 0;
                total = value;
            }
        }

        public Sale(int total, DateTime date)
        {
            this.total = total;
            this.date = date;
        }
    }
}