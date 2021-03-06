using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CSE455V2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserSettingsPage : ContentPage
    {
        public UserSettingsPage()
        {
            InitializeComponent();
        }

        void PaymentInfo_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new PaymentPage());
        }

        void VehicleInfo_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new VehiclePage());
        }

        void LoginInfo_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new LoginInfoPage());
        }
    }
}