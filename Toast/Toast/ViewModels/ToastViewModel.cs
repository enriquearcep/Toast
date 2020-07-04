using Acr.UserDialogs;
using Plugin.Toast;
using Plugin.Toast.Abstractions;
using System;
using System.Windows.Input;
using Toast.Services;
using Xamarin.Forms;

namespace Toast.ViewModels
{
    public class ToastViewModel
    {
        #region Commands
        public ICommand ShowToastCommand
        {
            get
            {
                return new Command(ShowToast);
            }
        }

        public ICommand ShowAcrUserDialogsToastCommand
        {
            get
            {
                return new Command(ShowAcrUserDialogsToast);
            }
        }

        public ICommand ShowPluginToastCommand
        {
            get
            {
                return new Command(ShowPluginToast);
            }
        }
        #endregion

        #region Methods
        private void ShowToast()
        {
            var toast = DependencyService.Get<IToastService>();

            toast?.ShowToast("¡Toast sin librerías!");
        }

        private void ShowAcrUserDialogsToast()
        {
            UserDialogs.Instance.Toast(new ToastConfig("¡Toast desde Acr.UserDialogs!")
            {
                BackgroundColor = Color.DarkGray,
                MessageTextColor = Color.White
            });
        }

        private void ShowPluginToast()
        {
            CrossToastPopUp.Current.ShowCustomToast("¡Toast desde Plugin.Toast!", "#87918a", "#FFFFFF", ToastLength.Long);
        }
        #endregion
    }
}
