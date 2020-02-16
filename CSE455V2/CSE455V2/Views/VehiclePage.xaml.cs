﻿using CSE455V2.Services;
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
    public partial class VehiclePage : ContentPage
    {
        public string CarInfo = "";      // replace with UserData.
        public VehiclePage()
        {
            InitializeComponent();
            LicensePlate.Text = CarInfo;        //replace with userData
            LoadLicensePlate();
        }
        async void LoadLicensePlate()
        {
            var user = await FirebaseHelper.GetUser(App.UserName);
            if(user != null)
                LicensePlate.Text = user.LicenseNumber;
        }

        async void EditLicensePlate(object sender, EventArgs args)
        {
            string result = await DisplayPromptAsync("Edit Vehical Information", "Please enter new License Plate Information?");
            // Change userData on database
            LicensePlate.Text = result;     // Display User data, not result
            await FirebaseHelper.UpdateLicensePlate(App.UserName, result);
        }
        async void DeleteLicensePlate(object sender, EventArgs args)
        {
            bool answer = await DisplayAlert("Delete Vehical Info", "Are you sure you want to delete this information?", "Yes", "No");

            if (answer == true)
            {
                await FirebaseHelper.UpdateLicensePlate(App.UserName, "");
            }
        }
    }
}