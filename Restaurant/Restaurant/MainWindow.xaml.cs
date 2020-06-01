using System.Windows;
using Restaurant.ViewModels;
using Restaurant.Views;

namespace Restaurant
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            var userVm = new UserViewModel();
            if (userVm.isUser(txtEmail.Text.ToString(), txtPassword.Password.ToString())) {
                txtResponse.Content = "Wrong email or password";
                setInputNull();
                return;
            }
            var nextWindow = new HomeWindow();
            nextWindow.Show();
            this.Close();

        }

        private void setInputNull() {
            txtEmail.Text = string.Empty;
            txtPassword.Password = string.Empty;
        }

        private void btnContinue_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
