using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace English2._0
{
    public class WorkWithAgreeOtherPlyer
    {
		UnitOfWork unit = new UnitOfWork();

		public WorkWithAgreeOtherPlyer()
		{
			unit = new UnitOfWork();
		}

        public int queryToUsersFirst()
        {
            int index = 0;
			IEnumerable<int> indexFirst = unit.Sql.queryToUsersFirst();
			foreach (int i in indexFirst)
                index = i;
            return index;
        }

        public int queryToUsersSecond(int indexS)
        {
            int ind = 0;
			IEnumerable<int> index = unit.Sql.queryToUsersSecond(indexS);

			foreach (int i in index)
                ind = i;
            return ind;
        }

        public void ContentAgree(TextBlock Agree)
        {
            int indexF = queryToUsersFirst();
            int index = queryToUsersSecond(indexF);
			IEnumerable<string> name = unit.Sql.ContentAgree(index);
			foreach (string str in name)
            {
                Agree.Text = "Вам бросил вызов пользователь " + str + ". Примите его ?";
            }
        }

        public void Update()
        {
			unit.Sql.Update();
		}

        public void Delete()
        {
			unit.Sql.Delete();
        }

        public static void OpenMainWindow(AgreeOtherPlayer window)
        {
            MainWindow main = new MainWindow();
            main.Show();
            window.Close();
        }

        public static void OpenGame(AgreeOtherPlayer window)
        {
            Game game = new Game();
            game.Show();
            window.Close();
        }
    }
}
