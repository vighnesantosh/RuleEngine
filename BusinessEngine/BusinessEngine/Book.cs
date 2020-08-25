using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessEngine
{
  public  class Book : ICommissionPayment
    {
        public bool MakeCommisionPayment(decimal amount)
        {
           return MakePayment(amount);
        }

        public bool MakePayment(decimal amount)
        {
            Printslip slip = new Printslip(this, 2);
            return true;
        }
    }
}
