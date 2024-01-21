using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Firm
{
    internal class Comission : Hourly
    {
        public double totalSales;
        private readonly double comissionRate;

        public Comission(string eName, string eAddress, string ePhone, string socSecNumber, double rate,double comissionRate) : base(eName, eAddress, ePhone, socSecNumber, rate)
        {
            this.comissionRate = comissionRate;
            totalSales = 0;
        }

        public void AddSales(double sales)
        {
            totalSales += sales;       
        }

        public override double Pay()
        {
            var payment = base.Pay() + (totalSales*comissionRate);
            totalSales = 0;
            return payment;
        }

        public override string ToString()
        {
            var result = base.ToString();
            result += "\nTotal sales: "+totalSales;
            return result;
        }
    }
}
