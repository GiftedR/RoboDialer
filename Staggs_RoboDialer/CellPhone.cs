using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staggs_RoboDialer
{
    internal class CellPhone : Phone
    {
        public CellPhone(string CompanyName, string PhoneNumber, int NumberType) : base(CompanyName, "+1 " + PhoneNumber, NumberType)
        {

        }
    }
}
