using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessEngine
{
  public  class Video : IPayment
    {
        public bool MakePayment(decimal amount)
        {
            return true;
        }

        public Video(IPayment payment, decimal amount)
        {
            if (MakePayment(amount))
            {
                //TODO: Make Learning to sky add free 
            }
        }
    }
}
