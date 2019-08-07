using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace gcBonus17
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }

        public Car()
        {
            this.Make = "";
            this.Model = "";
            this.Year = 0;
            this.Price = 0;
        }

        public Car(string make, string model, int year, double price)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Price = price;
        }

        public override string ToString()
        {
            return (this.Make + "\t\t" + this.Model + "\t\t" + this.Year + "\t\t" + this.Price.ToString("C2", CultureInfo.CurrentCulture));
        }

    }
}