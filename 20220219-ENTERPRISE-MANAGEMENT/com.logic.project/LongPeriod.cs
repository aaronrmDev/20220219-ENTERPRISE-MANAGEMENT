using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220219_ENTERPRISE_MANAGEMENT.com.logic.project
{
    public class LongPeriod : Project
    {
        private double tax;
        public double Tax { get => tax; set => tax = value; }

        public LongPeriod(int id, string name, DateTime date, double tax) : base(id, name, date)
        {
            base.Id = id;
            base.Name = name;
            base.Date = date;
            this.Tax = tax;
        }


        public override void CalculateCost()
        {
            throw new NotImplementedException();
        }
    }
}
