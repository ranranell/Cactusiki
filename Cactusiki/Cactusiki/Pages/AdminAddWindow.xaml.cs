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
using System.Windows.Shapes;
using Cactusiki.Classes;
using Cactusiki.db;
using Cactusiki.Pages;

namespace Cactusiki.Pages
{
    /// <summary>
    /// Логика взаимодействия для AdminAddWindow.xaml
    /// </summary>
    public partial class AdminAddWindow : Window
    {
        private Cactus cactus;
        public AdminAddWindow()
        {
            InitializeComponent();
            cactus = new Cactus();
            CmbxMaxDiscount.ItemsSource = ConnectionClass.db.Views.ToList();
        }

        private void TxtName_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsLetter(e.Text[0]))
            {
                e.Handled = true;
            }
        }

        private void TxtCount_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !char.IsDigit(e.Text, e.Text.Length - 1);
            var textBox = sender as TextBox;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TxtName.Text) || string.IsNullOrEmpty(TxtCountry.Text) || string.IsNullOrEmpty(TxtAge.Text) || CmbxMaxDiscount.SelectedItem == null || Convert.ToInt32(TxtCount.Text) == null)
                {
                    MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                else
                {
                    cactus.Name = TxtName.Text;
                    cactus.Views = (Views)CmbxMaxDiscount.SelectedItem;
                    cactus.Origin = TxtCountry.Text;
                    ConnectionClass.db.Cactus.Add(cactus);
                    ConnectionClass.db.SaveChanges();
                    MessageBox.Show($"Кактус {TxtName.Text} добавлен", "Добавление записи", MessageBoxButton.OK, MessageBoxImage.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnAddImage_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
