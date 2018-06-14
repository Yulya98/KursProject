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
    /// Логика взаимодействия для MainRules.xaml
    /// </summary>
    public partial class MainRules : Window
    {
        public MainRules()
        {
            InitializeComponent();
        }

        private void RuleElementary(object sender, RoutedEventArgs e)
        {
            WorkWithMainRules.OpenElementary(this);
        }


        private void PreInterRule(object sender, RoutedEventArgs e)
        {
            WorkWithMainRules.OpenPreIntermediate(this);
        }

        private void IntermediateRule(object sender, RoutedEventArgs e)
        {
            WorkWithMainRules.OpenIntermediate(this);
        }

        private void UpperInterRule(object sender, RoutedEventArgs e)
        {
            WorkWithMainRules.OpenUpperIntermediate(this);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WorkWithMainRules.OpenMain(this);
        }
    }
}
