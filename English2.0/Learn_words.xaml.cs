using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;

namespace English2._0
{
    /// <summary>
    /// Логика взаимодействия для Learn_words.xaml
    /// </summary>
    public partial class Learn_words : Window
    {
		WorkWithLearnWords work = new WorkWithLearnWords();

        static int j = 0;

        string[] massWord = new string[123];

        string[] massTranslate = new string[123];

        public Learn_words()
        {
            InitializeComponent();
            work.getWordsFromAktivePlyer(ref this.massWord,ref this.massTranslate);
            WorkWithLearnWords.outputToLabel(LabelTranslate,ref this.massTranslate);
            this.inputWord.Background = new LinearGradientBrush(Colors.Transparent, Colors.Transparent, 90);
            this.inputWord.TextChanged += new TextChangedEventHandler(inputWord_TextChanged);
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            work.checkTrueWord(inputWord, CheckLabel, ref massWord, ref massTranslate, LabelTranslate);
        }

        private void inputWord_TextChanged(object sender, TextChangedEventArgs e)
        {
            CheckLabel.Visibility = Visibility.Hidden;
        }

        private void inputWord_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            inputWord.Text = "";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WorkWithLearnWords.OpenMainWindow(this);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            WorkWithLearnWords.OpenActiveDictionary(this);
        }
    }
}
