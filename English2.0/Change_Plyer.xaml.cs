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
using System.Threading;

namespace English2._0
{
    /// <summary>
    /// Логика взаимодействия для Change_Plyer.xaml
    /// </summary>
    public partial class Change_Plyer : Window
    {
		Change_Plyers work = new Change_Plyers();

        public Change_Plyer()
        {
            InitializeComponent();
            this.TextName.Background = new LinearGradientBrush(Colors.Transparent, Colors.Transparent, 90);
            this.TextPassword.Background = new LinearGradientBrush(Colors.Transparent, Colors.Transparent, 90);
            this.TextName.TextChanged += new TextChangedEventHandler(TextBox_TextChanged);
            this.TextPassword.TextChanged += new TextChangedEventHandler(TextBox_TextChanged);
            Change.IsEnabled = false;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Change_Plyers.checkEmptyTextName(TextName,TextPassword,Change);
        }

        private void Change_Click(object sender, RoutedEventArgs e)
        {
            work.CheckPlyer(CheckLablel,LabelError,TextName,TextPassword);
        }

        private void TextPassword_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            TextPassword.Text = "";
        }

        private void TextName_MouseDoubleClick2(object sender, MouseButtonEventArgs e)
        {
            TextName.Text = "";
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Change_Plyers.OpenMainWindow(this);
        }
    }
}
