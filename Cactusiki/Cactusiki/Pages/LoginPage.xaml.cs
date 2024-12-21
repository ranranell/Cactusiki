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
using Cactusiki.Classes;
using Cactusiki.Pages;
using Cactusiki.db;

namespace Cactusiki.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }



        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Close();
        }

        private void BtnAuth_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TxtLogin.Text) || string.IsNullOrEmpty(PsPassword.Password))
                {
                    MessageBox.Show("Пожалуйста, заполните логин и пароль!!!", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    var user = ConnectionClass.db.Login.FirstOrDefault(d => d.Login1 == TxtLogin.Text && d.Password == PsPassword.Password);
                    if (user != null)
                    {
                        var role = ConnectionClass.db.Roles.FirstOrDefault(s => s.id_Role == user.Role_id);
                        if (role != null)
                        {
                            MessageBox.Show($"Добро пожаловать, {role.Name}!", "Авторизация прошла успешно", MessageBoxButton.OK, MessageBoxImage.Information);
                            if (role.Name.ToLower() == "admin")
                            {
                                NavigationService.Navigate(new AdminPage());
                            }
                            else if (role.Name.ToLower() == "user1")
                            {
                                NavigationService.Navigate(new UserPage());
                            }
                            else
                            {
                                MessageBox.Show("Неизвестная роль пользователя.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ошибка при получении роли пользователя.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Логин или пароль неверный!!!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
