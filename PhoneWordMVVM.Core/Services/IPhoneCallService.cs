using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneWordMVVM.Core.Services
{
    public interface IPhoneCallService
    {
        void MakePhoneCall(string name, string number);
    }
}
