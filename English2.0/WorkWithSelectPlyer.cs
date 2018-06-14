using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace English2._0
{
    public class WorkWithSelectPlyer
    {
		UnitOfWork unit = new UnitOfWork();

		public WorkWithSelectPlyer()
		{
			unit = new UnitOfWork();
		}

        public void DownladContent(Button Check, TextBlock TextListPlyer)
        {
            Check.IsEnabled = false;
            CodeFirst context = new CodeFirst();
			CodeFirst context1 = new CodeFirst();
			CodeFirst context2 = new CodeFirst();
			TextListPlyer.Text = "";
			IEnumerable<int> idActivePlyer = unit.Sql.queryToUsersFirst();

			IEnumerable<UsersWords> wordActiveCount = unit.Sql.DownladContent();

			IEnumerable < UsersWords > wordsOtherUsers = unit.Sql.DownladContent2();

			var count = from p in wordsOtherUsers
						group p by p.UserId into g
						select new
						{
							Name = g.Key,
							Count = g.Count()
						};
			foreach (var u in count)
			{
				if(wordActiveCount.Count() == u.Count)
				{
					IEnumerable<string> NameOtherPlyer = from f in context.Users
													 where f.UserId == u.Name
													 select f.UserName;
					foreach (string name in NameOtherPlyer)
					{
						TextListPlyer.Text += name + "\n";
					}
				}
			}
        }

        public void CheckPlyer(TextBox TextName, TextBlock TextListPlyer)
        {
            CodeFirst context = new CodeFirst();
			IEnumerable<int> firstPlyer = unit.Sql.queryToUsersFirst();

			IEnumerable<int> secondPlyer = unit.Sql.CheckPlyer(TextName.Text);

			int value = secondPlyer.Count();
            foreach (int first in firstPlyer)
            {
                foreach (int second in secondPlyer)
                {
                    Play plyers = new Play();
                    plyers.FirstId = first;
                    plyers.SecondId = second;
                    plyers.Start = false;
					unit.Sql.AddToPlay(plyers);

				}
            }
			unit.Sql.SaveToDB();

            if (value == 1)
            {
                TextListPlyer.Text = "Wait support second plyer!";
                TextName.Clear();
            }
            else
            {
                TextName.Text = "Try again! False data!";
            }
        }

        public static void checkEmptyTextName(TextBlock TextListPlyer, Button Check)
        {
            if (TextListPlyer.Text == "" || TextListPlyer.Text == "Input name of plyer")
            {
                Check.IsEnabled = false;
            }
            else
                Check.IsEnabled = true;
        }

        public static void OpenMainWindow(SelectPlyer plyer)
        {
            MainWindow main = new MainWindow();
            main.Show();
            plyer.Close();
        }
    }
}
