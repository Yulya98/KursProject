using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace English2._0
{
    public class WorkWithWinner
    {
		UnitOfWork unit;

		public WorkWithWinner()
		{
			unit = new UnitOfWork();
		}

        public bool CheckPlayDB(int index)
        {
            CodeFirst context = new CodeFirst();
			IEnumerable<int> result = unit.Sql.CheckPlayDB(index);

			if (result.Count() > 0)
                return true;
            else
                return false;
        }

        public int CheckPlayResult(int index)
        {
            int resultWinner = 0;
            CodeFirst context = new CodeFirst();
			IEnumerable<int> result = unit.Sql.CheckPlayResult(index);

			foreach (int i in result)
            {
                resultWinner = i;
            }
            return resultWinner;
        }

        public void Delete()
        {
            CodeFirst context = new CodeFirst();
			IEnumerable<int> indexes = unit.Sql.queryToUsersFirst();

			int index = 0;
            foreach (int i in indexes)
                index = i;
            Play play = context.Play
                .Where(o => o.SecondId == index || o.FirstId == index)
                .FirstOrDefault();
            context.Play.Remove(play);
            context.SaveChanges();
        }

        public void CheckDatabase(TextBlock Result)
        {
            CodeFirst context = new CodeFirst();
            int index = 0;
			IEnumerable<int> user = unit.Sql.queryToUsersFirst();

			foreach (int i in user)
            {
                index = i;
            }
            if (CheckPlayDB(index) && CheckPlayResult(index) > 0)
                Result.Text = "Time is over. You won! Congratulations !";
            else
            {
                if (CheckPlayResult(index) == 0)
                    Result.Text = "Time is over. You have a draw.";
                if (!CheckPlayDB(index) && CheckPlayResult(index) < 0)
                    Result.Text = "Time is over. You won! Congratulations !";
                if (!CheckPlayDB(index) && CheckPlayResult(index) > 0)
                    Result.Text = "Time is over. You lose. Try again !";
            }
            if (CheckPlayDB(index) && CheckPlayResult(index) < 0)
                Result.Text = "Time is over. You lose. Try again !";
            Delete();
        }

        public void DownloadContent(TextBlock Result)
        {
            CheckDatabase(Result);
        }

        public static void OpenMainWindows(Winner winner)
        {
            MainWindow main = new MainWindow();
            main.Show();
            winner.Close();
        }
    }
}
