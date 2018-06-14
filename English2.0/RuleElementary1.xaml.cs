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
    /// Логика взаимодействия для RuleElementary1.xaml
    /// </summary>
    public partial class RuleElementary1 : Window
    {
        public RuleElementary1()
        {
            InitializeComponent();
        }

        public string level;

        public RuleElementary1(string newLevel)
        {
            this.level = newLevel;
        }

        public void loadElementaryContent()
        {
            
        }

        public void loadRules()
        {
            if(level == "Elementary")
            {

            }
        }
    }
}
