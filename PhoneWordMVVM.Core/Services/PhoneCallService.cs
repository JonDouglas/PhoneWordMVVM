using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cirrious.CrossCore;
using Cirrious.MvvmCross.Plugins.PhoneCall;

namespace PhoneWordMVVM.Core.Services
{
    public class PhoneCallService : IPhoneCallService
    {
        private readonly IMvxPhoneCallTask _phoneCall;

        public PhoneCallService(IMvxPhoneCallTask phoneCall)
        {
            _phoneCall = phoneCall;
        }

        public void MakePhoneCall(string name, string number)
        {
            try
            {
                _phoneCall.MakePhoneCall(name, number);
            }
            catch (Exception ex)
            {
                Mvx.Warning("Error seen during location {0}", ex.InnerException);
            }
        }

    }
}
