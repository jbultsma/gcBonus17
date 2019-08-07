using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace gcBonus17
{
    class UsedCar : Car
    {               
        private double Miles { get; set; }
      
        public UsedCar(string make, string model, int year, double price, double miles)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
            this.Price = price;
            this.Miles = miles;
        } 

        public override string ToString()
        {
            return (this.Make + "\t\t" + this.Model + "\t\t" + this.Year + "\t\t" + this.Price.ToString("C2", CultureInfo.CurrentCulture) + "\t\t" + "(Used) Miles: " + this.Miles);
        }

    }
}