using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Windows.Controls;

namespace English2._0
{
    public class WorkWithMainForm
    {
		UnitOfWork unit;

		public WorkWithMainForm()
		{
			unit = new UnitOfWork();
		}

		public void CanUseLearnWords(MenuItem Learn)
		{
			IEnumerable<Words> count = unit.Sql.getWordsFromAktivePlyer4();
			if(count.Count() == 0)
			{
				Learn.IsEnabled = false;
			}
		}

		public void Inizialize( MenuItem LearnWords, MenuItem Test, MenuItem Rules, MenuItem Play)
        {
            CheckCanYouUseButton(LearnWords,Test,Rules,Play);
            CanUseBuutonPlay(Play);
        }

        public static void CheckCanYouUseButton(MenuItem LearnWords, MenuItem Test, MenuItem Rules, MenuItem Play)
        {
            if (Users.aktivePlyer == null)
            {
                LearnWords.IsEnabled = false;
                Test.IsEnabled = false;
                Rules.IsEnabled = false;
            }
        }

        public void CanUseBuutonPlay(MenuItem Play)
        {
            CodeFirst context = new CodeFirst();
            CodeFirst context2 = new CodeFirst();
			int id =0;
			IEnumerable<int> idActiveUser = unit.Sql.queryToUsersFirst();

			foreach (int i in idActiveUser)
			{
				id = i;
			}
			IEnumerable<UsersWords> words = unit.Sql.CanUseBuutonPlay(id);

			if (words.Count() == 0 || id == 0)
                Play.IsEnabled = false;
            else
                Play.IsEnabled = true;
        }



        public int CheckDate(int index)
        {
            int countDay = 0;
            CodeFirst context = new CodeFirst();
			IEnumerable<DateTime> date = unit.Sql.CheckDate(index);

			foreach (DateTime now in date)
            {
                DateTime firstDate = now;
                DateTime currentDate = DateTime.Today;
                TimeSpan span = currentDate - firstDate;
                string relative = span.Days.ToString();
                countDay = Convert.ToInt32(relative);
            }
            return countDay;
        }

        public int CheckOnAgree()
        {
            CodeFirst context = new CodeFirst();
            int index = -1;
			IEnumerable<int> idSecond = unit.Sql.queryToUsersFirst();

			foreach (int i in idSecond)
                index = i;
			IEnumerable<Play> play = unit.Sql.CheckOnAgree(index);

			IEnumerable<Play> playSituation2 = unit.Sql.CheckOnAgree2(index);

			IEnumerable<Play> playSituation3 = unit.Sql.CheckOnAgree3(index);

			IEnumerable<Play> playSituation4 = unit.Sql.CheckOnAgree4(index);

			if (play.Count() > 0)
                return 0;
            if (playSituation2.Count() > 0)
                return -1;
            if (playSituation3.Count() > 0)
                return 1;
            if (playSituation4.Count() > 0)
                return 1;
            if (CheckDate(index) > 0)
                return 2;
            return -2;
        }

        public static void OpenLearnWord(MainWindow main)
        {
            Learn_words learn = new Learn_words();
            learn.Show();
            main.Close();
        }

        public static void CreateNewPlyer(MainWindow main)
        {
            CreateNewPlyer createNewPlyer_Window = new CreateNewPlyer();
            createNewPlyer_Window.Show();
            main.Close();
        }

        public void ChoosePage(MainWindow main)
        {
            if (CheckOnAgree() == 0)
            {
                AgreeOtherPlayer agree = new AgreeOtherPlayer();
                agree.Show();
                main.Close();
            }
            if (CheckOnAgree() == -1)
            {
                SelectPlyer play = new SelectPlyer();
                play.Show();
                main.Close();
            }
            if (CheckOnAgree() == -2)
            {
                SelectPlyer play = new SelectPlyer();
                play.Show();
                main.Close();
            }
            if (CheckOnAgree() == 1)
            {
                Game game = new Game();
                game.Show();
                main.Close();
            }
            if (CheckOnAgree() == 2)
            {
                Winner winner = new Winner();
                winner.Show();
                main.Close();
            }
        }

        public static void ChangePlyer(MainWindow main)
        {
            Change_Plyer change = new Change_Plyer();
            change.Show();
            main.Close();
        }

        public static void MainRules(MainWindow mainW)
        {
            MainRules main = new MainRules();
            main.Show();
            mainW.Close();
        }

        public static void LeasrnWords(MainWindow main)
        {
            Learn_words learn = new Learn_words();
            learn.Show();
            main.Close();
        }

        public static void SelectLevel(MainWindow main)
        {
            SelectLevel level = new SelectLevel();
            level.Show();
            main.Close();
        }
    }
}
