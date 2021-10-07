using Rg.Plugins.Popup.Animations;
using Rg.Plugins.Popup.Enums;
using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System.Threading.Tasks;

namespace FacaiboBETA.Controllers
{
    class PopupAnimation
    {
        public async void ShowHorizontal(PopupPage inPopup) 
        {

            var horizontalAnimation = new ScaleAnimation
            {
                PositionIn = MoveAnimationOptions.Right,
                PositionOut = MoveAnimationOptions.Left
            };

            inPopup.Animation = horizontalAnimation;
            inPopup.CloseWhenBackgroundIsClicked = true;
            await PopupNavigation.Instance.PushAsync(inPopup);
        }

        public async void ShowHorizontalR(PopupPage inPopup)
        {
            var horizontalAnimation = new ScaleAnimation
            {
                PositionIn = MoveAnimationOptions.Left,
                PositionOut = MoveAnimationOptions.Right
            };

            inPopup.Animation = horizontalAnimation;
            inPopup.CloseWhenBackgroundIsClicked = true;
            await PopupNavigation.Instance.PushAsync(inPopup);
        }

        public static void ClosePopup()
        {
            PopupNavigation.Instance.PopAsync();
            GlobalVar.OpenPopup(false);
        }
    }
}
