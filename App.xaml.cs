using System.Windows;
using TODO_app.Views;

namespace TODO_app
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            LoginWindow login = new LoginWindow();
            login.Show();

            RegisterWindow registerWindow = new RegisterWindow();
            registerWindow.Show();
        }
    }

}
