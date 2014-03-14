using System.Drawing;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Touch.Views;
using MonoTouch.ObjCRuntime;
using MonoTouch.UIKit;
using MonoTouch.Foundation;

namespace PhoneWordMVVM.iOS.Views
{
    [Register("HomeView")]
    public class HomeView : MvxViewController
    {
        public override void ViewDidLoad()
        {
            View = new UIView(){ BackgroundColor = UIColor.White};
            base.ViewDidLoad();

			// ios7 layout
            if (RespondsToSelector(new Selector("edgesForExtendedLayout")))
               EdgesForExtendedLayout = UIRectEdge.None;

            var enterPhonewordLabel = new UILabel(new RectangleF(20, 80, 280, 21));
            enterPhonewordLabel.Text = "Enter a Phoneword:";
            View.Add(enterPhonewordLabel);

            var phoneNumberText = new UITextField(new RectangleF(20, 119, 280, 30));
            phoneNumberText.BorderStyle = UITextBorderStyle.RoundedRect;
            phoneNumberText.Text = "1-855-CALLME";
            View.Add(phoneNumberText);

            var translateButton = UIButton.FromType(UIButtonType.RoundedRect);
            translateButton.Frame = new RectangleF(20, 192, 280, 30);
            translateButton.SetTitle("Translate", UIControlState.Normal);
            View.Add(translateButton);

            var callButton = UIButton.FromType(UIButtonType.RoundedRect);
            callButton.Frame = new RectangleF(20, 269, 280, 30);
            callButton.SetTitle("Call", UIControlState.Normal);
            callButton.Enabled = false;
            View.Add(callButton);

            var callHistoryButton = UIButton.FromType(UIButtonType.RoundedRect);
            callHistoryButton.Frame = new RectangleF(20, 346, 280, 30);
            callHistoryButton.SetTitle("Call History", UIControlState.Normal);
            View.Add(callHistoryButton);

            var set = this.CreateBindingSet<HomeView, Core.ViewModels.HomeViewModel>();
            set.Bind(phoneNumberText).To(vm => vm.PhoneNumber);
            set.Bind(translateButton).To(vm => vm.TranslateNumberCommand);
            set.Bind(callButton).To(vm => vm.MakePhoneCallCommand);
            set.Bind(callHistoryButton).To(vm => vm.CallHistoryCommand);
            set.Bind(callButton).For("Title").To(vm => vm.CallButtonText);
            set.Apply();

        }
    }
}