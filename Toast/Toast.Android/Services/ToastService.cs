using Toast.Droid.Services;
using Toast.Services;
using Xamarin.Forms;

[assembly:Dependency(typeof(ToastService))]
namespace Toast.Droid.Services
{
    public class ToastService : IToastService
    {
        public void ShowToast(string Text)
        {
            Android.Widget.Toast.MakeText(Android.App.Application.Context, Text, Android.Widget.ToastLength.Long).Show();
        }
    }
}