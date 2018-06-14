using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace English2._0
{
    public class WorkWithCreatePlyer
    {
		UnitOfWork unit;

		public WorkWithCreatePlyer()
		{
			unit = new UnitOfWork();
		} 

        public static void checkEmptyTextName(TextBox TextName, TextBox TextPassword, TextBox TextEmail, Button Save,Label LabelError)
        {
            if (TextName.Text == "" || TextPassword.Text == "" || TextEmail.Text == "" || TextEmail.Text == "Field for input e-mail" || TextEmail.Text == "Поле для ввода e-mail" || TextPassword.Text == "Поле для ввода пароля" || TextName.Text == "Поле для ввода имени" || TextPassword.Text == "Field for input password" || TextName.Text == "Field for input name")
            {
                Save.IsEnabled = false;
            }
            else
                Save.IsEnabled = true;
            LabelError.Visibility = System.Windows.Visibility.Hidden;
        }

        public void CheckDatabase(Label LabelError, TextBox TextPassword, TextBox TextName, TextBox TextEmail)
        {
            bool flag = false;
			IEnumerable<string> checkEnum = unit.Sql.Check();
			foreach (string str in checkEnum)
            {
                if (str == TextName.Text)
                    flag = true;
            }
            if (flag == true)
            {
                LabelError.Visibility = System.Windows.Visibility.Visible;
                LabelError.Content = "Данное имя занято";
            }
            else
            {
                SaveTrunsaction(TextPassword,TextName,TextEmail);
            }
        }

        public void SaveTrunsaction(TextBox TextPassword, TextBox TextName, TextBox TextEmail)
        {
			Users user = new Users();
            user.password = HashPassword.HashPasswords(TextPassword.Text);
            user.UserName = TextName.Text; 
            user.email = TextEmail.Text;
			unit.Sql.AddToDbUser(user);
			unit.Sql.SaveToDB();
			Users.aktivePlyer = TextName.Text;
			WorkWithLearnWords.j = 0;
			IEnumerable<int> queryToUsers = unit.Sql.SelectUserId(TextName.Text);
			IEnumerable<int> queryToWords = unit.Sql.SelectWordId();
			foreach (var us in queryToUsers)
            {
                foreach (var word in queryToWords)
                {
                    UsersWords users = new UsersWords();
                    users.UserId = us;
                    users.WordId = word;
                    users.flag = false;
					unit.Sql.AddToDB(users);
				}
            }
			unit.Sql.SaveToDB();
			TextName.Text = "";
            TextPassword.Text = "";
            TextEmail.Text = "";
        }

        public static void OpenMainWindow(CreateNewPlyer create)
        {
            MainWindow main = new MainWindow();
            main.Show();
            create.Close();
        }
    }
}
