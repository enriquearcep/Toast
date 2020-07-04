﻿using Foundation;
using Toast.iOS.Services;
using Toast.Services;
using UIKit;
using Xamarin.Forms;

[assembly:Dependency(typeof(ToastService))]
namespace Toast.iOS.Services
{
    public class ToastService : IToastService
    {
        public UIAlertController toast { get; set; }
        public NSTimer delay { get; set; }
        public void ShowToast(string Text)
        {
            delay = NSTimer.CreateRepeatingScheduledTimer(2, (e) =>
            {
                toast?.DismissViewController(true, null);
                delay?.Dispose();
            });

            toast = UIAlertController.Create(null, Text, UIAlertControllerStyle.Alert);

            UIApplication.SharedApplication.KeyWindow.RootViewController.PresentViewController(toast, true, null);
        }
    }
}