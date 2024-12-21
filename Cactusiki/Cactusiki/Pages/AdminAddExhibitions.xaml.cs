using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для AdminAddExhibitions.xaml
    /// </summary>
    public partial class AdminAddExhibitions : Window
    {
        private Exhibitions exh;
        public AdminAddExhibitions()
        {
            InitializeComponent();
            exh = new Exhibitions();
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
            Regex regex = new Regex("[^0-9.]+");
            if (regex.IsMatch(e.Text))
            {
                e.Handled = true;
            }
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TxtName.Text) || Convert.ToDateTime(TxtName_DateStart.Text) == null || Convert.ToDateTime(TxtName_DateEnd.Text) == null || string.IsNullOrEmpty(TxtCount.Text))
                {
                    MessageBox.Show("Пожалуйста, заполните все поля.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
                else
                {
                    exh.Name = TxtName.Text;
                    exh.Date_Start = Convert.ToDateTime(TxtName_DateStart.Text);
                    exh.Date_End = Convert.ToDateTime(TxtName_DateEnd.Text);
                    exh.Address = TxtCount.Text;
                    ConnectionClass.db.Exhibitions.Add(exh);
                    ConnectionClass.db.SaveChanges();
                    MessageBox.Show($"Выставка {TxtName.Text} добавлена", "Добавление записи", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

    }
}
