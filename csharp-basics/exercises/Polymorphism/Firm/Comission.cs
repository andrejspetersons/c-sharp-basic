using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Firm
{
    internal class Comission : Hourly
    {
        public double TotalSales { get; private set; }
        private readonly double _comissionRate;

        public Comission(string eName, string eAddress, string ePhone, string socSecNumber, double rate,double comissionRate) : base(eName, eAddress, ePhone, socSecNumber, rate)
        {
            _comissionRate = comissionRate;
            TotalSales = 0;
        }

        public void AddSales(double sales)
        {
            TotalSales += sales;       
        }

        public override double Pay()
        {
            var payment = base.Pay() + (TotalSales*_comissionRate);
            TotalSales = 0;
            return payment;
        }

        public override string ToString()
        {
            var result = base.ToString();
            result += "\nTotal sales: "+TotalSales;
            return result;
        }
    }
}
