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
    /// Логика взаимодействия для SelectPlyer.xaml
    /// </summary>
    public partial class SelectPlyer : Window
    {
		WorkWithSelectPlyer work = new WorkWithSelectPlyer();

		public SelectPlyer()
        {
            InitializeComponent();
            work.DownladContent(Check,TextListPlyer);
            this.TextName.TextChanged += new TextChangedEventHandler(TextBox_TextChanged);
            this.TextName.Background = new LinearGradientBrush(Colors.Transparent, Colors.Transparent, 90);
        }

        private void TextName_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            TextName.Text = "";
        }


        private void Check_Click(object sender, RoutedEventArgs e)
        {
          work.CheckPlyer(TextName, TextListPlyer);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
           WorkWithSelectPlyer.checkEmptyTextName(TextListPlyer,Check);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WorkWithSelectPlyer.OpenMainWindow(this);
        }
    }
}
