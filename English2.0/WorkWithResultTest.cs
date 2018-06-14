using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Net.Mail;
using System.Net;

namespace English2._0
{
    public class WorkWithResultTest
    {
		UnitOfWork unit;

		public WorkWithResultTest()
		{
			unit = new UnitOfWork();
		}

        public static void sendMessage(string email,string level)
        {
			MailAddress from = new MailAddress("yulya.kukareko@gmail.com", "English");
			MailAddress to = new MailAddress(email);
			MailMessage m = new MailMessage(from, to);
			m.Subject = "Gratulation!";
			m.Body = "<h2>Congratulations! You have moved to a new level " + level + ". Perhaps the level of your knowledge above, we suggest that you pass the following tests </h2>";
			m.IsBodyHtml = true;
			SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
			smtp.Credentials = new NetworkCredential("yulya.kukareko@gmail.com", "yulya_123");
			smtp.EnableSsl = true;
			smtp.Timeout = 9000;
			smtp.Send(m);
		}

        public static bool Comparator(string newLevel, string level)
        {
            int a = 0, b = 0;
            if (level == "Elementary")
                a = 1;
            if (level == "Pre-Intermediate")
                a = 2;
            if (level == "Intermediate")
                a = 3;
            if (level == "Upper-Intermediate")
                a = 4;
            if (newLevel == "Elementary")
                b = 1;
            if (newLevel == "Pre-Intermediate")
                b = 2;
            if (newLevel == "Intermediate")
                b = 3;
            if (newLevel == "Upper-Intermediate")
                b = 4;
            return (a - b) > 0 ? true : false;
        }

        public bool CheckNewLevel(string level)
        {
            CodeFirst code = new CodeFirst();

			IEnumerable<Users> user = from u in code.Users
									  where u.UserName == Users.aktivePlyer
									  select u;
			foreach (Users i in user)
            {
                bool flag = Comparator(i.level,level);
                if (i.level == "NULL" || flag == true)
                {
                    sendMessage(i.email,level);
					IEnumerable<Users> usersList = unit.Sql.CheckNewLevel(level);
					return true;
                }
            }
            return false;
        }


        public void Content(string level, List<int> listWithMistakes, Label Result, TextBlock TextRule)
        {
            bool flag = CheckNewLevel(level);
            if (flag == true)
            {
                if (level == "Elementary")
                {
                    if (listWithMistakes.Count < 10)
                    {
                        Result.Content = "Ваш результат = " + ((20 - listWithMistakes.Count) * 100) / 19 + "%";
                        if (listWithMistakes.Count < 19)
                        {
                            TextRule.Text = "Мы советуем просмотреть следующие правила:  \n";
                            if (listWithMistakes.Contains(1))
                            {
                                TextRule.Text += "Употребление am/is/are в английском языке \n";
                            }
                            if (listWithMistakes.Contains(2))
                            {
                                TextRule.Text += "Устойчивые выражения с from/to/at \n";
                            }
                            if (listWithMistakes.Contains(3))
                            {
                                TextRule.Text += "Модальный глагол can \n";
                            }
                            if (listWithMistakes.Contains(5))
                            {
                                TextRule.Text += "Как сказать время на английском \n";
                            }
                            if (listWithMistakes.Contains(6))
                            {
                                TextRule.Text += "Модальный глагол must \n";
                            }
                            if (listWithMistakes.Contains(7))
                            {
                                TextRule.Text += "Вопросительные слова \n";
                            }
                            if (listWithMistakes.Contains(8))
                            {
                                TextRule.Text += "Указательные местоимения \n";
                            }
                            if (listWithMistakes.Contains(9))
                            {
                                TextRule.Text += "Притяжательные местоимения \n";
                            }
                            if (listWithMistakes.Contains(11))
                            {
                                TextRule.Text += "Окончание -s \n";
                            }
                            if (listWithMistakes.Contains(13))
                            {
                                TextRule.Text += "Постановка вопроса \n";
                            }
                            if (listWithMistakes.Contains(15) || listWithMistakes.Contains(16) || listWithMistakes.Contains(19))
                            {
                                TextRule.Text += "Формирование Past Simple \n";
                            }
                            if (listWithMistakes.Contains(17) || listWithMistakes.Contains(18))
                            {
                                TextRule.Text += "Сравнительные степени \n";
                            }
                            if (listWithMistakes.Contains(19))
                            {
                                TextRule.Text += "Формирование Present Perfect \n";
                            }
                            if (listWithMistakes.Contains(20))
                            {
                                TextRule.Text += "Формирование Future Simple \n";
                            }
                        }
                    }
                    else
                        TextRule.Text = "\nК сожалению, вы не прошли тест.";
                }
                if (level == "Pre-Intermediate")
                {
                    if (listWithMistakes.Count < 4)
                    {
                        Result.Content = "Ваш результат = " + (listWithMistakes.Count * 100) / 20 + "%";
                        if (listWithMistakes.Count < 20)
                        {
                            TextRule.Text += "\nМы советуем просмотреть следующие правила: \n";
                            if (listWithMistakes.Contains(1))
                            {
                                TextRule.Text = "\nПравило 1 \n";
                            }
                            if (listWithMistakes.Contains(2))
                            {
                                TextRule.Text = "\nПравило 2 \n";
                            }
                            if (listWithMistakes.Contains(3))
                            {
                                TextRule.Text = "\nПравило 3 \n";
                            }
                            if (listWithMistakes.Contains(4))
                            {
                                TextRule.Text = "\nПравило 4 \n";
                            }
                            if (listWithMistakes.Contains(5))
                            {
                                TextRule.Text = "\nПравило 5 \n";
                            }
                            if (listWithMistakes.Contains(6))
                            {
                                TextRule.Text = "\nПравило 6 \n";
                            }
                            if (listWithMistakes.Contains(7))
                            {
                                TextRule.Text = "\nПравило 7 \n";
                            }
                            if (listWithMistakes.Contains(8))
                            {
                                TextRule.Text = "\nПравило 8 \n";
                            }
                            if (listWithMistakes.Contains(9))
                            {
                                TextRule.Text = "\nПравило 9 \n";
                            }
                            if (listWithMistakes.Contains(10))
                            {
                                TextRule.Text = "\nПравило 10 \n";
                            }
                            if (listWithMistakes.Contains(11))
                            {
                                TextRule.Text = "\nПравило 11 \n";
                            }
                            if (listWithMistakes.Contains(12))
                            {
                                TextRule.Text = "\nПравило 12 \n";
                            }
                            if (listWithMistakes.Contains(13))
                            {
                                TextRule.Text = "\nПравило 13 \n";
                            }
                            if (listWithMistakes.Contains(14))
                            {
                                TextRule.Text = "\nПравило 14 \n";
                            }
                        }
                    }
                    else
                        TextRule.Text = "К сожалению, вы не прошли тест.";
                }
                if (level == "Intermediate")
                {
                    if (listWithMistakes.Count < 4)
                    {
                        Result.Content = "Ваш результат = " + (listWithMistakes.Count * 100) / 20 + "%";
                        if (listWithMistakes.Count < 20)
                        {
                            TextRule.Text = "Мы советуем просмотреть следующие правила:";
                            if (listWithMistakes.Contains(1))
                            {
                                TextRule.Text = "\nПравило 1 \n";
                            }
                            if (listWithMistakes.Contains(2))
                            {
                                TextRule.Text = "\nПравило 2 \n";
                            }
                            if (listWithMistakes.Contains(3))
                            {
                                TextRule.Text = "\nПравило 3 \n";
                            }
                            if (listWithMistakes.Contains(4))
                            {
                                TextRule.Text = "\nПравило 4 \n";
                            }
                            if (listWithMistakes.Contains(5))
                            {
                                TextRule.Text = "\nПравило 5 \n";
                            }
                            if (listWithMistakes.Contains(6))
                            {
                                TextRule.Text = "\nПравило 6 \n";
                            }
                            if (listWithMistakes.Contains(7))
                            {
                                TextRule.Text = "\nПравило 7 \n";
                            }
                            if (listWithMistakes.Contains(8))
                            {
                                TextRule.Text = "\nПравило 8 \n";
                            }
                            if (listWithMistakes.Contains(9))
                            {
                                TextRule.Text = "\nПравило 9 \n";
                            }
                            if (listWithMistakes.Contains(10))
                            {
                                TextRule.Text = "\nПравило 10 \n";
                            }
                            if (listWithMistakes.Contains(11))
                            {
                                TextRule.Text = "\nПравило 11 \n";
                            }
                            if (listWithMistakes.Contains(12))
                            {
                                TextRule.Text = "\nПравило 12 \n";
                            }
                            if (listWithMistakes.Contains(13))
                            {
                                TextRule.Text = "\nПравило 13 \n";
                            }
                            if (listWithMistakes.Contains(14))
                            {
                                TextRule.Text = "\nПравило 14 \n";
                            }
                        }
                    }
                    else
                        TextRule.Text = "К сожалению, вы не прошли тест.";
                }
                if (level == "Upper-Intermediate")
                {
                    if (listWithMistakes.Count < 4)
                    {
                        Result.Content = "Ваш результат = " + (listWithMistakes.Count * 100) / 20 + "%";
                        if (listWithMistakes.Count < 20)
                        {
                            TextRule.Text = "Мы советуем просмотреть следующие правила:";
                            if (listWithMistakes.Contains(1))
                            {
                                TextRule.Text = "\nПравило 1 \n";
                            }
                            if (listWithMistakes.Contains(2))
                            {
                                TextRule.Text = "\nПравило 2 \n";
                            }
                            if (listWithMistakes.Contains(3))
                            {
                                TextRule.Text = "\nПравило 3 \n";
                            }
                            if (listWithMistakes.Contains(4))
                            {
                                TextRule.Text = "\nПравило 4 \n";
                            }
                            if (listWithMistakes.Contains(5))
                            {
                                TextRule.Text = "\nПравило 5 \n";
                            }
                            if (listWithMistakes.Contains(6))
                            {
                                TextRule.Text = "\nПравило 6 \n";
                            }
                            if (listWithMistakes.Contains(7))
                            {
                                TextRule.Text = "\nПравило 7 \n";
                            }
                            if (listWithMistakes.Contains(8))
                            {
                                TextRule.Text = "\nПравило 8 \n";
                            }
                            if (listWithMistakes.Contains(9))
                            {
                                TextRule.Text = "\nПравило 9 \n";
                            }
                            if (listWithMistakes.Contains(10))
                            {
                                TextRule.Text = "\nПравило 10 \n";
                            }
                            if (listWithMistakes.Contains(11))
                            {
                                TextRule.Text = "\nПравило 11 \n";
                            }
                            if (listWithMistakes.Contains(12))
                            {
                                TextRule.Text = "\nПравило 12 \n";
                            }
                            if (listWithMistakes.Contains(13))
                            {
                                TextRule.Text = "\nПравило 13 \n";
                            }
                            if (listWithMistakes.Contains(14))
                            {
                                TextRule.Text = "\nПравило 14 \n";
                            }
                        }
                    }
                    else
                        TextRule.Text = "К сожалению, вы не прошли тест.";
                }
            }
            else
            {
                TextRule.Text = "Вы уже проходили данный тест";
            }
        }

        public static void OpenMainWindow(ResultTest result)
        {
            MainWindow main = new MainWindow();
            main.Show();
            result.Close();
        }

    }
}
