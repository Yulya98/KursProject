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
    /// Логика взаимодействия для AgreeOtherPlayer.xaml
    /// </summary>
    public partial class AgreeOtherPlayer : Window
    {
		WorkWithAgreeOtherPlyer work = new WorkWithAgreeOtherPlyer();

        public AgreeOtherPlayer()
        {
            InitializeComponent();
            work.ContentAgree(Agree);
        }

        private void Check_Click(object sender, RoutedEventArgs e)
        {
            work.Update();
            WorkWithAgreeOtherPlyer.OpenGame(this);
        }

        private void No_Click(object sender, RoutedEventArgs e)
        {
            work.Delete();
            WorkWithAgreeOtherPlyer.OpenMainWindow(this);
        }
    }
}
