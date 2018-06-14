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
    /// Логика взаимодействия для ActiveDictionary.xaml
    /// </summary>
    public partial class ActiveDictionary : Window
    {
		WorkWithActiveDictionary work = new WorkWithActiveDictionary();

        public ActiveDictionary()
        {
            InitializeComponent();
            this.ActveListBox.Background = new LinearGradientBrush(Colors.Transparent, Colors.Transparent, 90);
            work.CheckDatabase(ActveListBox);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            work.OpenLearnWindow(this);
        }
    }
}
