using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace English2._0
{
    public class Change_Plyers
    {
		UnitOfWork unit;

		public Change_Plyers()
		{
			unit = new UnitOfWork();
		}

        public static void checkEmptyTextName(TextBox TextName, TextBox TextPassword, Button Change)
        {
            if (TextName.Text == "" || TextPassword.Text == "" || TextName.Text == "Field for input name" || TextName.Text == "Поле для ввода имени" || TextPassword.Text == "Field for input password" || TextPassword.Text == "Поле для ввода пароля")
            {
                Change.IsEnabled = false;
            }
            else
                Change.IsEnabled = true;
        }

        public static bool CheckPassword(string userName,Label CheckLablel)
        {
            bool flag = true;
            CodeFirst context = new CodeFirst();
            IEnumerable<string> checkEnum = from u in context.Users
                                            where u.UserName == userName
                                            select u.password;
            if (checkEnum.Count() == 0)
            {
                flag = false;
                CheckLablel.Content = "Пароль введён неверно";
                CheckLablel.Visibility = System.Windows.Visibility.Visible;
                CheckLablel.Foreground = System.Windows.Media.Brushes.Red;
            }
            return flag;
        }

        public void CheckPlyer(Label CheckLablel, Label LabelError, TextBox TextName, TextBox TextPassword)
        {
            CheckLablel.Visibility = System.Windows.Visibility.Hidden;
            LabelError.Visibility = System.Windows.Visibility.Hidden;
            CodeFirst context = new CodeFirst();
			IEnumerable<Users> checkEnum = unit.Sql.CheckPlyer();
			bool flag = false;
			bool flasgForPassword = false;
            foreach (Users str in checkEnum)
            {
				if (str.UserName == TextName.Text)
				{
					flag = true;
					if( true == HashPassword.VerifyHashedPassword(str.password, TextPassword.Text))
					{
						flasgForPassword = true;
					}
				}
            }
            if (flag == false)
            {
                LabelError.Foreground = System.Windows.Media.Brushes.Red;
                LabelError.Content = "Имя не найдено";
                LabelError.Visibility = System.Windows.Visibility.Visible;
            }
			if(flasgForPassword == false)
			{
				LabelError.Foreground = System.Windows.Media.Brushes.Red;
				LabelError.Content = "Пароль неверный!";
				LabelError.Visibility = System.Windows.Visibility.Visible; 
			}
            if (flag && flasgForPassword)
            {
                flag = CheckPassword(TextName.Text,CheckLablel);
				if (flag)
				{
					WorkWithLearnWords.j = 0;
					Users.aktivePlyer = TextName.Text;
				}
                LabelError.Content = "Добро пожаловать!!!";
                LabelError.Foreground = System.Windows.Media.Brushes.Blue;
                LabelError.Visibility = System.Windows.Visibility.Visible;
                TextName.Text = "";
                TextPassword.Text = "";
            }
        }

        public static void OpenMainWindow(Change_Plyer change)
        {
            MainWindow main = new MainWindow();
            main.Show();
            change.Close();
        }
    }
}
