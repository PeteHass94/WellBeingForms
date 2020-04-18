using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WellBeingForms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LogIn : TabbedPage
    {
        FirebaseHelper firebaseHelper = new FirebaseHelper();
        public LogIn()
        {
            InitializeComponent();
            OnAppearing();
        }
        protected async override void OnAppearing()
        {

            base.OnAppearing();
            var allUsers = await firebaseHelper.GetAllUsers();
            //lstPersons.ItemsSource = allPersons;
        }
    }
}