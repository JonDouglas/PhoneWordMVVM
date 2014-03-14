using System.Collections.Generic;
using System.Windows.Input;
using Cirrious.MvvmCross.Plugins.PhoneCall;
using Cirrious.MvvmCross.ViewModels;
using PhoneWordMVVM.Core.Services;

namespace PhoneWordMVVM.Core.ViewModels
{
    public class HomeViewModel 
		: MvxViewModel
    {
        public HomeViewModel(IMvxPhoneCallTask phoneCall, ICallService callService)
        {
            _phoneCall = phoneCall;
            _callService = callService;
        }

        private readonly IMvxPhoneCallTask _phoneCall;
        private readonly ICallService _callService;

        private string _CallButtonText = "Call";
        public string CallButtonText
        {
            get { return _CallButtonText; }
            set { _CallButtonText = value; RaisePropertyChanged(() => CallButtonText); }
        }

		private string _PhoneNumber = "1-855-CALLME";
        public string PhoneNumber
		{ 
			get { return _PhoneNumber; }
			set { _PhoneNumber = value; RaisePropertyChanged(() => PhoneNumber); }
		}

        private string _PersonName = "Jon";
        public string PersonName
        {
            get { return _PersonName; }
            set { _PersonName = value; RaisePropertyChanged(() => PersonName); }
        }

        private bool _CanCallNumber = true;
        public bool CanCallNumber
        {
            get { return _CanCallNumber; }
            set { _CanCallNumber = value; RaisePropertyChanged(() => CanCallNumber); }
        }

        private bool _CanSeeHistory = true;
        public bool CanSeeHistory
        {
            get { return _CanSeeHistory; }
            set { _CanSeeHistory = value; RaisePropertyChanged(() => CanSeeHistory); }
        }

        public ICommand TranslateNumberCommand
        {
            get
            {
                return new MvxCommand(() =>
                {
                    CallButtonText = "Call: " + PhonewordTranslator.ToNumber(PhoneNumber);
                });
            }
        }

        public ICommand MakePhoneCallCommand
        {
            get
            {
                return new MvxCommand(() =>
                {
                    _phoneCall.MakePhoneCall(PersonName, PhoneNumber);
                    _callService.Add(new Call { PhoneNumber = PhoneNumber});
                });
            }
        }

        private MvxCommand _CallHistoryCommand;

        public ICommand CallHistoryCommand
        {
            get
            {
                _CallHistoryCommand = _CallHistoryCommand ?? new MvxCommand(DoCallHistory);
                return _CallHistoryCommand;
            }
        }

        private void DoCallHistory()
        {
            ShowViewModel<CallHistoryViewModel>();
        }
    }
}
