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
    /// Логика взаимодействия для CreateNewPlyer.xaml
    /// </summary>
    public partial class CreateNewPlyer : Window
    {
		WorkWithCreatePlyer work = new WorkWithCreatePlyer();

        public CreateNewPlyer()
        {
            InitializeComponent();
            this.TextName.Background = new LinearGradientBrush(Colors.Transparent, Colors.Transparent, 90);
            this.TextPassword.Background = new LinearGradientBrush(Colors.Transparent, Colors.Transparent, 90);
            this.TextEmail.Background = new LinearGradientBrush(Colors.Transparent, Colors.Transparent, 90);
            this.TextName.TextChanged += new TextChangedEventHandler(TextBox_TextChanged);
            this.TextPassword.TextChanged += new TextChangedEventHandler(TextBox_TextChanged);
            this.TextEmail.TextChanged += new TextChangedEventHandler(TextBox_TextChanged);
			Save.IsEnabled = false;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            WorkWithCreatePlyer.checkEmptyTextName(TextName, TextPassword, TextEmail, Save,LabelError);
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            work.CheckDatabase(LabelError, TextPassword, TextName, TextEmail);
        }

        private void TextName_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            TextName.Clear();
        }

        private void TextPassword_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            TextPassword.Clear();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WorkWithCreatePlyer.OpenMainWindow(this);
        }

        private void TextEmail_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            TextEmail.Text = "";
        }
    }
}
