using Toast.Views;
using Xamarin.Forms;

namespace Toast
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ToastView();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
