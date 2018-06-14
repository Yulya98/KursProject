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
    /// Логика взаимодействия для RulesElementary.xaml
    /// </summary>
    public partial class RulesElementary : Window
    {
        public RulesElementary()
        {
            InitializeComponent();
        }

        public string level;

        public RulesElementary(string newLevel)
        {
            InitializeComponent();
            this.level = newLevel;
            WorkWithRulesElementary.loadRules(this.level, Header, Rule1, Rule2, Rule3, Rule4, Rule5, Rule6, Rule7, Rule8, Rule9, Rule10, Rule11, Rule12, Rule13, Rule14);
        }

        private void SelectRule1(object sender, RoutedEventArgs e)
        {
            WorkWithRulesElementary.Question1(this.level,this);
        }

        private void SelectRule2(object sender, RoutedEventArgs e)
        {
            WorkWithRulesElementary.Question2(this.level, this);
        }

        private void SelectRule3(object sender, RoutedEventArgs e)
        {

            WorkWithRulesElementary.Question3(this.level, this);
        }

        private void SelectRule4(object sender, RoutedEventArgs e)
        {
            WorkWithRulesElementary.Question4(this.level, this);
        }

        private void SelectRule5(object sender, RoutedEventArgs e)
        {
            WorkWithRulesElementary.Question5(this.level, this);
        }

        private void SelectRule6(object sender, RoutedEventArgs e)
        {
            WorkWithRulesElementary.Question6(this.level, this);
        }

        private void SelectRule7(object sender, RoutedEventArgs e)
        {
            WorkWithRulesElementary.Question7(this.level, this);
        }

        private void SelectRule8(object sender, RoutedEventArgs e)
        {
            WorkWithRulesElementary.Question8(this.level, this);
        }

        private void SelectRule9(object sender, RoutedEventArgs e)
        {
            WorkWithRulesElementary.Question9(this.level, this);
        }

        private void SelectRule10(object sender, RoutedEventArgs e)
        {
            WorkWithRulesElementary.Question10(this.level, this);
        }

        private void SelectRule11(object sender, RoutedEventArgs e)
        {
            WorkWithRulesElementary.Question11(this.level, this);
        }

        private void SelectRule12(object sender, RoutedEventArgs e)
        {
            WorkWithRulesElementary.Question12(this.level, this);
        }

        private void SelectRule13(object sender, RoutedEventArgs e)
        {

            WorkWithRulesElementary.Question13(this.level, this);
        }

        private void SelectRule14(object sender, RoutedEventArgs e)
        {
            WorkWithRulesElementary.Question14(this.level, this);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WorkWithRulesElementary.OpenMainWindow(this);
        }
    }
}
