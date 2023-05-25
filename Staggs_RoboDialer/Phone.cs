using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Staggs_RoboDialer
{
    abstract class Phone
    {
        string CompanyName = string.Empty;
        string PhoneNumber = string.Empty;
        int NumberType = 0;

        public Phone(string CompName, string PhoneNum, int NumType) 
        { 
            CompanyName = CompName;
            PhoneNumber = PhoneNum;
            NumberType = NumType;
        }
        public string Dial()
        {
            return CompanyName + " is being dialing using phone number " + PhoneNumber;
        }
        public string number
        {
            get { return PhoneNumber; }
            set { }
        }
    }
}
