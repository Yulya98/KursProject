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
using System.Drawing;
using System.IO;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;
using System.Globalization;

namespace English2._0
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
		WorkWithMainForm work = new WorkWithMainForm();

        public MainWindow()
        {
            InitializeComponent();
            this.Menu.Background = new LinearGradientBrush(Colors.Transparent, Colors.Transparent, 90);
            App.LanguageChanged += LanguageChanged;
            CultureInfo currLang = App.Language;
            menuLanguage.Items.Clear();
            foreach (var lang in App.Languages)
            {
                MenuItem menuLang = new MenuItem();
                menuLang.Header = lang.DisplayName;
                menuLang.Tag = lang;
                menuLang.IsChecked = lang.Equals(currLang);
                menuLang.Click += ChangeLanguageClick;
                menuLanguage.Items.Add(menuLang);
				menuLang.Foreground = Brushes.Black;
            }
            Menu1.Background = new LinearGradientBrush(Colors.Transparent, Colors.Transparent, 90);
            work.Inizialize(LearnWords,Test,Rules,Play);
			work.CanUseLearnWords(LearnWords);
			//VizableLabelActiveUser();
		}


		//public void VizableLabelActiveUser()
		//{
		//	if (Users.aktivePlyer != null)
		//	{
		//		AktivePlyer.Visibility = Visibility.Visible;
		//		AktivePlyer.Content += Users.aktivePlyer + " :)";
		//	}
		//	else
		//		AktivePlyer.Visibility = Visibility.Hidden;
		//}
        
        private void LanguageChanged(Object sender, EventArgs e)
        {
            CultureInfo currLang = App.Language;
            foreach (MenuItem i in menuLanguage.Items)
            {
                CultureInfo ci = i.Tag as CultureInfo;
                i.IsChecked = ci != null && ci.Equals(currLang);
            }

        }
        private void ChangeLanguageClick(Object sender, EventArgs e)
        {
            MenuItem mi = sender as MenuItem;
            if (mi != null)
            {
                CultureInfo lang = mi.Tag as CultureInfo;
                if (lang != null)
                {
                    App.Language = lang;
                }
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            WorkWithMainForm.OpenLearnWord(this);
        }

        private void CreateNewPlyer_Click(object sender, RoutedEventArgs e)
        {
            WorkWithMainForm.CreateNewPlyer(this);
        }

        private void Learn_words_Download_Click(object sender, RoutedEventArgs e)
        {
            WorkWithMainForm.LeasrnWords(this);
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            WorkWithMainForm.ChangePlyer(this);
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            WorkWithMainForm.SelectLevel(this);
        }

        private void OpenMainRules(object sender, RoutedEventArgs e)
        {
            WorkWithMainForm.MainRules(this);
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            WorkWithMainForm.CreateNewPlyer(this);
        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            work.ChoosePage(this);
        }
    }
}
