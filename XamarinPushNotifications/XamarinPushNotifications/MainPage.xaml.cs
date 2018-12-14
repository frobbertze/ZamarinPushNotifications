using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinPushNotifications
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            LoadButton.Clicked += LoadButton_Clicked;
            SaveButton.Clicked += SaveButton_Clicked;
        }

        private void SaveButton_Clicked(object sender, EventArgs e)
        {
            Application.Current.Properties["valuesaved"] = Valuetosave.Text;
        }

        private void LoadButton_Clicked(object sender, EventArgs e)
        {
            Valuetosave.Text = Application.Current.Properties["valuesaved"].ToString();
        }
    }
}
