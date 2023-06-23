using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using System;
using System.Data.SqlClient;
using WeFairAndriod.Models;
using WeFairAndriod.Services;
using System.IO;

namespace WeFairAndriod.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        private static Database database;

        public static Database Database
        {
            get
            {
                if (database == null)
                {
                    database = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "user.db3"));
                }
                return database;
            }
        }

        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string UserName = txtUsername.Text;
            string Pass = txtPassword.Text;

            if (ValidateCredentials(UserName, Pass))
            {
                //UserChoise userChoise = new UserChoise(UserName);
                //Navigation.PushAsync(userChoise);
            }
            else
            {
                DisplayAlert("Error", "Invalid username or password.", "OK");
            }
        }

        private bool ValidateCredentials(string UserName, string Pass)
        {
            string connectionString = "Server=tcp:x13.database.windows.net,1433;Initial Catalog=WeShareC;Persist Security Info=False;User ID=amin;Password=Passw0rd;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM UserInfo WHERE LOWER(UserName) = LOWER(@UserName) AND Pass = @Pass COLLATE NOCASE", connection);
                command.Parameters.AddWithValue("@UserName", UserName);
                command.Parameters.AddWithValue("@Pass", Pass);

                var count = (int)command.ExecuteScalar();

                return count > 0;
            }
        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            Application.Current.MainPage = mainPage;
        }
    }
}
