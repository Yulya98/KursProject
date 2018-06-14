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
    /// Логика взаимодействия для Rule.xaml
    /// </summary>
    public partial class Rule : Window
    {
        public Rule()
        {
            InitializeComponent();
        }

        public string level;

        public int number;

        public Rule(string newLevel, int numberOfRule)
        {
            InitializeComponent();
            level = newLevel;
            number = numberOfRule;
            WorkWithRule.SelectRule(this.level,this.number,Header,TextRule);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WorkWithRule.OpenRuleElementary(this.level, this);
        }
    }
}
