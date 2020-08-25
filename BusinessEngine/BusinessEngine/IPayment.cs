using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessEngine
{
    public interface IPayment
    {
        bool MakePayment(decimal amount);
    }
}
