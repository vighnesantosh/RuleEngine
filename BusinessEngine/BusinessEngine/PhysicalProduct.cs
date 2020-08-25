using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessEngine
{
   public class PhysicalProduct : IPayment
    {
        public bool MakePayment(decimal amount)
        {
            Printslip slip = new Printslip(this, 1);
            return true;
        }
    }
}
