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
    /// Логика взаимодействия для Game.xaml
    /// </summary>
    public partial class Game : Window
    {
		WorkWithGame work = new WorkWithGame();

        static int j = 0;

        string[] massWord = new string[123];

        string[] massTranslate = new string[123];

        public Game()
        {
            InitializeComponent();
            work.getWordsFromAktivePlyer(massWord,massTranslate);
            WorkWithGame.outputToLabel(LabelTranslate,massTranslate);
            this.inputWord.Background = new LinearGradientBrush(Colors.Transparent, Colors.Transparent, 90);
            this.inputWord.TextChanged += new TextChangedEventHandler(inputWord_TextChanged);
        }


        private void Save_Click(object sender, RoutedEventArgs e)
        {
            work.checkTrueWord(inputWord, CheckLabel, massWord, massTranslate, LabelTranslate);
        }

        public void HidLable()
        {
            CheckLabel.Visibility = Visibility.Hidden;
        }

        private void inputWord_TextChanged(object sender, TextChangedEventArgs e)
        {
            HidLable();
        }

        private void inputWord_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            inputWord.Text = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WorkWithGame.OpenMainWindow(this);
        }
    }
}
