using FacaiboBETA.Controllers;
using Xamarin.Forms;

namespace FacaiboBETA
{
    class Toast
    {
        public Toast()
        {
        }

        public static void Show(string inToastMessage)
        {
            DependencyService.Get<IToastMessage>().DisplayMessage(inToastMessage);
        }
    }
}
