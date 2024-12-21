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
using Cactusiki.Pages;
using Cactusiki.db;
using Cactusiki.Classes;

namespace Cactusiki.Pages
{
    /// <summary>
    /// Логика взаимодействия для Admin_Cactus_Pages.xaml
    /// </summary>
    public partial class Admin_Cactus_Pages : Page
    {

        private int exhibitionId;
        public Admin_Cactus_Pages(int exhibitionId)
        {
            InitializeComponent();
            this.exhibitionId = exhibitionId;
            LoadCactusData();
        }

        private void LoadCactusData()
        {
            LvCactus.ItemsSource = ConnectionClass.db.Contracts.Where(c => c.Exhibition_id == exhibitionId).ToList();
        }

        private void TxtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            LvCactus.ItemsSource = ConnectionClass.db.Cactus.Where(z => z.Name.ToLower().Contains(TxtSearch.Text)).ToList();
        }

        private void BtnSort_az_Click(object sender, RoutedEventArgs e)
        {
            LvCactus.ItemsSource = ConnectionClass.db.Cactus.OrderBy(z => z.Name).ToList();
        }

        private void BtnBAck_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdminPage());
        }

        private void BtnSort_delet_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
            {
                return;
            }
            else
            {
                var selectedItem = LvCactus.SelectedItem as Exhibitions;
                if (selectedItem != null)
                {
                    try
                    {
                        ConnectionClass.db.Exhibitions.Remove(selectedItem);
                        ConnectionClass.db.SaveChanges();
                        LvCactus.ItemsSource = ConnectionClass.db.Cactus.ToList();
                        MessageBox.Show($"Выставка {selectedItem.Name} удалена", "Сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при удалении записи: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Для начала выберите запись!!!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }

        private void BtnSort_add_Click(object sender, RoutedEventArgs e)
        {
            AdminAddWindow adminAddWindow = new AdminAddWindow();
            adminAddWindow.ShowDialog();
            LoadCactusData();

        }
    }
}
