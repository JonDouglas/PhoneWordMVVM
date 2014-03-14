using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cirrious.MvvmCross.ViewModels;
using PhoneWordMVVM.Core.Services;
using PhoneWordMVVM.Core.Services.Data;

namespace PhoneWordMVVM.Core.ViewModels
{
    public class CallHistoryViewModel : MvxViewModel
    {
        public CallHistoryViewModel(ICallService callService)
        {
            _callService = callService;
            _PhoneNumbers = _callService.All();
        }

        private readonly ICallService _callService;

        private List<Call> _PhoneNumbers;

        public List<Call> PhoneNumbers
        {
            get { return _PhoneNumbers; }
            set { _PhoneNumbers = value; RaisePropertyChanged(() => PhoneNumbers); }
        }

    }
}
