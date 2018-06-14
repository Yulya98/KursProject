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
    /// Логика взаимодействия для Tests.xaml
    /// </summary>
    public partial class Tests : Window
    {
        public Tests()
        {
            InitializeComponent();
        }

        static int countPage;

        public string level;

        public List<int> listWithMistakes;

        public Tests(string levelNew)
        {
            InitializeComponent();
            level = levelNew;
            WorkWithTests.LoadBeginnContent(this.level,ref countPage, Text1,Text2,Text3,Text4,Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question9, Question10, Question11, Question12);
            listWithMistakes = new List<int>();
        }

        private void Check_Click(object sender, RoutedEventArgs e)
        {
           WorkWithTests.CheckContentOnButton(this.level,this.listWithMistakes, ref countPage, Text1, Text2, Text3, Text4, Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question9, Question10, Question11, Question12,Check,this);
        }
    }
}
