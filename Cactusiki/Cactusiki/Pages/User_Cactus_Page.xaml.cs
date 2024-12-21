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
using Cactusiki.Pages;
using Cactusiki.Classes;

namespace Cactusiki.Pages
{
    /// <summary>
    /// Логика взаимодействия для User_Cactus_Page.xaml
    /// </summary>
    public partial class User_Cactus_Page : Page
    {
        private int exhibitionId;
        public User_Cactus_Page(int exhibitionId)
        {
            InitializeComponent();
            this.exhibitionId = exhibitionId;
            LoadCactusData();
        }
        private void LoadCactusData()
        {
            LvBooks.ItemsSource = ConnectionClass.db.Contracts.Where(c => c.Exhibition_id == exhibitionId).ToList();
        }
        private void TxtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            LvBooks.ItemsSource = ConnectionClass.db.Cactus.Where(z => z.Name.ToLower().Contains(TxtSearch.Text)).ToList();
        }

        private void BtnSort_az_Click(object sender, RoutedEventArgs e)
        {
            LvBooks.ItemsSource = ConnectionClass.db.Cactus.OrderBy(z => z.Name).ToList();
        }

        private void Btn_Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new UserPage());
        }
    }
}
