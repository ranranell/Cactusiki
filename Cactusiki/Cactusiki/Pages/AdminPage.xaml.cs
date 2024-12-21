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
using Cactusiki.db;
using Cactusiki.Classes;
using Cactusiki.Pages;

namespace Cactusiki.Pages
{
    /// <summary>
    /// Логика взаимодействия для AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        public AdminPage()
        {
            InitializeComponent();
            LvExhibitions.ItemsSource = ConnectionClass.db.Exhibitions.ToList();
        }
        
        private void TxtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            LvExhibitions.ItemsSource = ConnectionClass.db.Exhibitions.Where(z => z.Name.ToLower().Contains(TxtSearch.Text)).ToList();
        }

        private void BtnSort_az_Click(object sender, RoutedEventArgs e)
        {
            LvExhibitions.ItemsSource = ConnectionClass.db.Exhibitions.OrderBy(z => z.Name).ToList();
        }

        private void BtnSort_delet_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.No)
            {
                return;
            }
            else
            {
                var selectedItem = LvExhibitions.SelectedItem as Exhibitions;
                if (selectedItem != null)
                {
                    try
                    {
                        ConnectionClass.db.Exhibitions.Remove(selectedItem);
                        ConnectionClass.db.SaveChanges();
                        LvExhibitions.ItemsSource = ConnectionClass.db.Exhibitions.ToList();
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
            AdminAddExhibitions adminAddExhibitions = new AdminAddExhibitions();
            adminAddExhibitions.ShowDialog();
            LvExhibitions.ItemsSource = ConnectionClass.db.Exhibitions.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var selectedExhibition = LvExhibitions.SelectedItem as Exhibitions;
            if (selectedExhibition != null)
            {
                Admin_Cactus_Pages cactusPage = new Admin_Cactus_Pages(selectedExhibition.id_Exhibition);
                NavigationService.Navigate(cactusPage);
            }
            else
            {
                MessageBox.Show("Выберите выставку для просмотра кактусов.", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
