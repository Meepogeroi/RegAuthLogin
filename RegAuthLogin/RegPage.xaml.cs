using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using RegAuthLogin.db.models;
using RegAuthLogin.db;

namespace RegAuthLogin
{
    /// <summary>
    /// Логика взаимодействия для RegPage.xaml
    /// </summary>
    public partial class RegPage : Page
    {
        public RegPage()
        {
            InitializeComponent();
        }
        private void CompleteReg_Click(object sender, RoutedEventArgs e)
        {
            if (Pass.Password == RetPass.Password && Pass.Password.Length > 0 & Login.Text.Length > 0)
            {
                using (DataBaseContext db = new DataBaseContext())
                {
                    string login = Login.Text;
                    string pass = Pass.Password;
                    User usr = new User { Username = login, Password = pass };

                    db.Users.Add(usr);
                    db.SaveChanges();

                    this.NavigationService.Navigate(new Uri("/UserPage.xaml", UriKind.Relative));
                }
            }
            else
            {
                MessageBox.Show("Error Registration");
            }
        }

        private void Auth_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/LoginPage.xaml", UriKind.Relative));
        }
    }
}
