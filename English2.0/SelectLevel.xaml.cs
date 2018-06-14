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

namespace English2._0
{
    /// <summary>
    /// Логика взаимодействия для SelectLevel.xaml
    /// </summary>
    public partial class SelectLevel : Window
    {
        public SelectLevel()
        {
            InitializeComponent();
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            WorkWithSelectLevel.ChooseLevel("Elementary",this);
        }

        private void Show_PreIntermediate(object sender, RoutedEventArgs e)
        {
            WorkWithSelectLevel.ChooseLevel("Pre-Intermediate", this);
        }

        private void Show_Intermediate(object sender, RoutedEventArgs e)
        {
            WorkWithSelectLevel.ChooseLevel("Intermediate", this);
        }

        private void Show_UpperIntermediate(object sender, RoutedEventArgs e)
        {
            WorkWithSelectLevel.ChooseLevel("Upper-Intermediate", this);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WorkWithSelectLevel.ChooseLevel("", this);
        }
    }
}
