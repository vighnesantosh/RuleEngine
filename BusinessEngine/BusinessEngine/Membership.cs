using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace BusinessEngine
{
    public class Membership : IPayment
    {
        public bool MakePayment(decimal amount)
        {
            return true;
        }

        public bool ProcessMemberShip(int? MemberId = null, decimal memberShipFee = 0)
        {
            EmailProcesser emailProcesser = null;
            if (MemberId != null)
            {
                if (MakePayment(memberShipFee))
                {
                    //TODO: Upgrade Membership
                }

            }
            else
            {
                if (MakePayment(memberShipFee))
                {
                    //TODO: Activate Membership

                }
            }

            emailProcesser = new EmailProcesser(this);
            return true;
        }

    }
}
