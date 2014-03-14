using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cirrious.MvvmCross.Binding.BindingContext;
using Cirrious.MvvmCross.Binding.Touch.Views;
using Cirrious.MvvmCross.Touch.Views;
using MonoTouch.Foundation;
using MonoTouch.ObjCRuntime;
using MonoTouch.UIKit;
using PhoneWordMVVM.Core.ViewModels;

namespace PhoneWordMVVM.iOS.Views
{
    [Register("CallHistoryView")]
    public class CallHistoryView : MvxTableViewController
    {
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // ios7 layout
            if (RespondsToSelector(new Selector("edgesForExtendedLayout")))
                EdgesForExtendedLayout = UIRectEdge.None;

            var source = new MvxStandardTableViewSource(TableView, "TitleText PhoneNumber");
            TableView.Source = source;

            var set = this.CreateBindingSet<CallHistoryView, CallHistoryViewModel>();
            set.Bind(source).To(vm => vm.PhoneNumbers);
            set.Apply();

            TableView.ReloadData();
        }
    }
}