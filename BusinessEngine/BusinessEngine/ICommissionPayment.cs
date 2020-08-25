using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessEngine
{
    interface ICommissionPayment : IPayment
    {
        public bool MakeCommisionPayment(decimal amount);
    }
}
