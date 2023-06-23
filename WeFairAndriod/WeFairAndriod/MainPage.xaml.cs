using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeFairAndriod.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeFairAndriod
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        LoginPage loginPage;
        
        public MainPage()
        {
            InitializeComponent();
        }
        private void GoToLogin_Click(object sender, EventArgs e)
        {
            if (loginPage == null)
                loginPage = new LoginPage();

            Application.Current.MainPage = loginPage;
        }

        private void GoToSignUp_Click(object sender, EventArgs e)
        {
            SignUpPage signUpPage = new SignUpPage();
            Application.Current.MainPage = signUpPage;
        }
    }
}