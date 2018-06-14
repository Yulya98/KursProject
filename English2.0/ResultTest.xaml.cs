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
using System.Net.Mail;
using System.Net;

namespace English2._0
{
    /// <summary>
    /// Логика взаимодействия для ResultTest.xaml
    /// </summary>
    public partial class ResultTest : Window
    {
		WorkWithResultTest work = new WorkWithResultTest();

        List<int> listWithMistakes = new List<int>();

        string level;

        public ResultTest(List<int> list, string newLevel)
        {
            InitializeComponent();
            listWithMistakes = list;
            level = newLevel;
            work.Content(level, listWithMistakes,Result,TextRule);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WorkWithResultTest.OpenMainWindow(this);
        }
    }
}
