using Android.Widget;
using FacaiboBETA.Droid;
using Xamarin.Forms;
using FacaiboBETA.Controllers;

[assembly: Dependency(typeof(Message_Droid))]
namespace FacaiboBETA.Droid
{
    class Message_Droid : IToastMessage
    {
        public void DisplayMessage(string message)
        {
            Toast.MakeText(Android.App.Application.Context, message, ToastLength.Long).Show();
        }
    }
}