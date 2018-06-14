using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace English2._0
{
    public class WorkWithLearnWords
    {
		UnitOfWork unit;
		UnitOfWork unit2;

		public WorkWithLearnWords()
		{
			unit = new UnitOfWork();
			unit2 = new UnitOfWork();
		}

        public static int j = 0;
        public void getWordsFromAktivePlyer(ref string[] massWord, ref string[] massTranslate)
        {

			IEnumerable<int> query = unit.Sql.getWordsFromAktivePlyer3();

			IEnumerable<Words> queryToWords = unit2.Sql.getWordsFromAktivePlyer4();

			foreach (var obj in queryToWords)
            {
                massWord[j] = obj.Word.ToUpper();
                massTranslate[j] = obj.Translate;
                j++;
            }
			j = 0;
		}

        public static void outputToLabel(Label LabelTranslate, ref string[] massTranslate)
        {
            LabelTranslate.Content = massTranslate[j];
        }

        public void checkTrueWord(TextBox inputWord, Label CheckLabel, ref string[] massWord, ref string[] massTranslate,Label LabelTranslate)
        {
            if (inputWord.Text.ToUpper() == massWord[j])
            {
                ConnectToDatabaseAndDelete(ref massTranslate);
                DeleteFromMas(ref massTranslate,ref massWord,LabelTranslate);
                inputWord.Text = "";
                CheckLabel.Content = " True! Greate! ";
                CheckLabel.Foreground = System.Windows.Media.Brushes.White;
                CheckLabel.Visibility = System.Windows.Visibility.Visible;
            }
            else
            {
                CheckLabel.Content = " False! Try again! ";
                CheckLabel.Foreground = System.Windows.Media.Brushes.Red;
                CheckLabel.Visibility = System.Windows.Visibility.Visible;
            }
        }

        public static void DeleteFromMas(ref string[] massTranslate, ref string[] massWord, Label LabelTranslate)
        {

            for (j = 0; j < massTranslate.Length - 1; j++)
            {
                if (massTranslate[j] == (string)LabelTranslate.Content)
                {
                    massTranslate[j] = "";
                    massWord[j] = "";
                    break;
                }
            }
            for (j = 0; j < massTranslate.Length - 1; j++)
            {
                if (massTranslate[j] != "")
                {
                    outputToLabel(LabelTranslate,ref massTranslate);
                    break;
                }
            }
        }

        public void ConnectToDatabaseAndDelete(ref string[] massTranslate)
        {
            string[] mas = massTranslate;

			IEnumerable<int> SerchWordWithTranslate = unit.Sql.ConnectToDatabaseAndDelete3(mas[j]);

			IEnumerable<UsersWords> query = unit.Sql.ConnectToDatabaseAndDelete4(mas[j]);
			foreach (var q in query)
			{
                q.flag = true;
            }
			unit.Sql.SaveToDB();
        }

        public static void OpenMainWindow(Learn_words learn)
        {
            MainWindow main = new MainWindow();
            main.Show();
            learn.Close();
			j = 0;
        }

        public static void OpenActiveDictionary(Learn_words learn)
        {
            ActiveDictionary main = new ActiveDictionary();
            main.Show();
            learn.Close();
			j = 0;
        }
    }
}
