using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220219_ENTERPRISE_MANAGEMENT.com.logic.project
{
    public class ShortPeriod : Project
    {
        public ShortPeriod(int id, string name, DateTime date) : base(id, name, date)
        {
            base.Id = id;
            base.Name = name;
            base.Date = date;
        }

        public override void CalculateCost()
        {
            throw new NotImplementedException();
        }
    }
}
