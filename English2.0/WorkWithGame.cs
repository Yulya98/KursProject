using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace English2._0
{
    class WorkWithGame
    {
		UnitOfWork unit;

		public WorkWithGame()
		{
			unit = new UnitOfWork();
		}

        static int j = 0;

        public void getWordsFromAktivePlyer(string[] massWord, string[] massTranslate)
        {
			IEnumerable<int> query = unit.Sql.getWordsFromAktivePlyer();
			IEnumerable<Words> queryToWords = unit.Sql.getWordsFromAktivePlyer2();

			foreach (var obj in queryToWords)
            {
                massWord[j] = obj.Word.ToUpper();
                massTranslate[j] = obj.Translate;
                j++;
            }
            j = 0;
        }

        public void CheckPlayDB()
        {
            int indexValue = 0;
			IEnumerable<int> index = unit.Sql.queryToUsersFirst();
			foreach (int i in index)
				indexValue = i;
			IEnumerable<Play> succsessPlyer1 = unit.Sql.CheckPlayDB();
			IEnumerable<Play> succsesPlyer2 = unit.Sql.CheckPlayDB2();
			if (succsessPlyer1.Count() > 0)
            {
                ConnectToPlay(indexValue);
            }
            if (succsesPlyer2.Count() > 0)
            {
                ConnectToPlaySecondId(indexValue);
            }
        }

        public void ConnectToPlay(int index)
        {
			unit.Sql.ConnectToPlay(index);
		}

        public void ConnectToPlaySecondId(int index)
        {
			unit.Sql.ConnectToPlaySecondId(index);
		}

        public  void checkTrueWord(TextBox inputWord, Label CheckLabel, string[] massWord, string[] massTranslate, Label LabelTranslate)
        {
            if (inputWord.Text.ToUpper() == massWord[j])
            {
                ConnectToDatabaseAndDelete(massTranslate);
                DeleteFromMas(massTranslate,massWord,LabelTranslate);
                inputWord.Text = "";
                CheckLabel.Content = " True! Greate! ";
                CheckLabel.Foreground = System.Windows.Media.Brushes.White;
                CheckLabel.Visibility = System.Windows.Visibility.Visible;
                CheckPlayDB();
            }
            else
            {
                CheckLabel.Content = " False! Try again! ";
                CheckLabel.Foreground = System.Windows.Media.Brushes.Red;
                CheckLabel.Visibility  = System.Windows.Visibility.Visible;
            }
        }

        public static void DeleteFromMas(string[] massTranslate, string[] massWord,Label LabelTranslate)
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
                    outputToLabel(LabelTranslate, massTranslate);
                    break;
                }
            }

        }

        public void ConnectToDatabaseAndDelete(string[] massTranslate)
        {
			IEnumerable<int> SerchWordWithTranslate = unit.Sql.ConnectToDatabaseAndDelete(massTranslate[j]);
			IEnumerable<UsersWords> query = unit.Sql.ConnectToDatabaseAndDelete2(massTranslate[j]);
			foreach (var q in query)
            {
                q.flagForPlay = true;
            }
			unit.Sql.SaveToDB();
        }

        public static  void OpenMainWindow(Game game)
        {
            MainWindow main = new MainWindow();
            main.Show();
			game.Close();
			j = 0;
        }

        public static void outputToLabel(Label LabelTranslate, string[] massTranslate)
        {
            LabelTranslate.Content = massTranslate[j];
        }
    }
}
