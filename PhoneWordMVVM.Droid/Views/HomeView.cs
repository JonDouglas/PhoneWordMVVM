using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;

namespace PhoneWordMVVM.Droid.Views
{
    [Activity(Label = "View for FirstViewModel")]
    public class HomeView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.HomeView);
        }
    }
}