using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace PhoneWordMVVM.iOS
{
    public static class PhoneUtility
    {
        public static void Dial(string phoneNumber)
        {
            var url = new NSUrl("tel:" + phoneNumber);

            if (!UIApplication.SharedApplication.OpenUrl(url))
            {
                var av = new UIAlertView("Not supported"
                                         , "Scheme 'tel:' is not supported on this device"
                                         , null
                                         , "OK"
                                         , null);
                av.Show();
            }
        }
    }
}