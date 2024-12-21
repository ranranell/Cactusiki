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
    /// Логика взаимодействия для UserPage.xaml
    /// </summary>
    public partial class UserPage : Page
    {
        public UserPage()
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var selectedExhibition = LvExhibitions.SelectedItem as Exhibitions;
            if (selectedExhibition != null)
            {
                User_Cactus_Page cactusPage = new User_Cactus_Page(selectedExhibition.id_Exhibition);
                NavigationService.Navigate(cactusPage);
            }
            else
            {
                MessageBox.Show("Выберите выставку для просмотра кактусов.", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
