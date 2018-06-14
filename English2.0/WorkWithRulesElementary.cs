using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace English2._0
{
    public class WorkWithRulesElementary
    {
        public static void loadElementaryContent(Label Header, TextBlock Rule1, TextBlock Rule2, TextBlock Rule3, TextBlock Rule4, TextBlock Rule5, TextBlock Rule6, TextBlock Rule7, TextBlock Rule8, TextBlock Rule9, TextBlock Rule10, TextBlock Rule11, TextBlock Rule12, TextBlock Rule13, TextBlock Rule14)
        {
            Header.Content = "Elementary";
            Rule1.Text = "Употребление am /is/ are в английском языке";
            Rule2.Text = "Устойчивые выражения с from/to/at";
            Rule3.Text = "Модальный глагол can";
            Rule4.Text = "Как сказать время на английском";
            Rule5.Text = "Модальный глагол must";
            Rule6.Text = "Вопросительные слова";
            Rule7.Text = "Указательные местоимения";
            Rule8.Text = "Притяжательные местоимения";
            Rule9.Text = "Окончание -s";
            Rule10.Text = "Потановка вопроса";
            Rule11.Text = "Формирование Past Simple";
            Rule12.Text = "Сравнительные степени";
            Rule13.Text = "Формирование Present Perfect";
            Rule14.Text = "Формирование Future Simple";
        }

        public static void PreInterediateContent(Label Header, TextBlock Rule1, TextBlock Rule2, TextBlock Rule3, TextBlock Rule4, TextBlock Rule5, TextBlock Rule6, TextBlock Rule7, TextBlock Rule8, TextBlock Rule9, TextBlock Rule10, TextBlock Rule11, TextBlock Rule12, TextBlock Rule13, TextBlock Rule14)
        {
            Header.Content = "Pre-intermediate";
            Rule1.Text = "Правило 1";
            Rule2.Text = "Правило 2";
            Rule3.Text = "Правило 3";
            Rule4.Text = "Правило 4";
            Rule5.Text = "Правило 5";
            Rule6.Text = "Правило 6";
            Rule7.Text = "Правило 7";
            Rule8.Text = "Правило 8";
            Rule9.Text = "Правило 9";
            Rule10.Text = "Правило 10";
            Rule11.Text = "Правило 11";
            Rule12.Text = "Правило 12";
            Rule13.Text = "Правило 13";
            Rule14.Text = "Правило 14";
        }

        public static void InterediateContent(Label Header, TextBlock Rule1, TextBlock Rule2, TextBlock Rule3, TextBlock Rule4, TextBlock Rule5, TextBlock Rule6, TextBlock Rule7, TextBlock Rule8, TextBlock Rule9, TextBlock Rule10, TextBlock Rule11, TextBlock Rule12, TextBlock Rule13, TextBlock Rule14)
        {
            Header.Content = "Intermediate";
            Rule1.Text = "Правило 1";
            Rule2.Text = "Правило 2";
            Rule3.Text = "Правило 3";
            Rule4.Text = "Правило 4";
            Rule5.Text = "Правило 5";
            Rule6.Text = "Правило 6";
            Rule7.Text = "Правило 7";
            Rule8.Text = "Правило 8";
            Rule9.Text = "Правило 9";
            Rule10.Text = "Правило 10";
            Rule11.Text = "Правило 11";
            Rule12.Text = "Правило 12";
            Rule13.Text = "Правило 13";
            Rule14.Text = "Правило 14";
        }


        public static void UpperInterediateContent(Label Header, TextBlock Rule1, TextBlock Rule2, TextBlock Rule3, TextBlock Rule4, TextBlock Rule5, TextBlock Rule6, TextBlock Rule7, TextBlock Rule8, TextBlock Rule9, TextBlock Rule10, TextBlock Rule11, TextBlock Rule12, TextBlock Rule13, TextBlock Rule14)
        {
            Header.Content = "Upper-Intermediate";
            Rule1.Text = "Правило 1";
            Rule2.Text = "Правило 2";
            Rule3.Text = "Правило 3";
            Rule4.Text = "Правило 4";
            Rule5.Text = "Правило 5";
            Rule6.Text = "Правило 6";
            Rule7.Text = "Правило 7";
            Rule8.Text = "Правило 8";
            Rule9.Text = "Правило 9";
            Rule10.Text = "Правило 10";
            Rule11.Text = "Правило 11";
            Rule12.Text = "Правило 12";
            Rule13.Text = "Правило 13";
            Rule14.Text = "Правило 14";
        }

        public static void loadRules(string level, Label Header, TextBlock Rule1, TextBlock Rule2, TextBlock Rule3, TextBlock Rule4, TextBlock Rule5, TextBlock Rule6, TextBlock Rule7, TextBlock Rule8, TextBlock Rule9, TextBlock Rule10, TextBlock Rule11, TextBlock Rule12, TextBlock Rule13, TextBlock Rule14)
        {
            if (level == "Elementary")
            {
                loadElementaryContent(Header,Rule1, Rule2, Rule3, Rule4, Rule5, Rule6, Rule7, Rule8, Rule9, Rule10, Rule11, Rule12, Rule13, Rule14);
            }
            if (level == "Pre-Intermediate")
            {
                PreInterediateContent(Header, Rule1, Rule2, Rule3, Rule4, Rule5, Rule6, Rule7, Rule8, Rule9, Rule10, Rule11, Rule12, Rule13, Rule14);
            }
            if (level == "Intermediate")
            {
                InterediateContent(Header, Rule1, Rule2, Rule3, Rule4, Rule5, Rule6, Rule7, Rule8, Rule9, Rule10, Rule11, Rule12, Rule13, Rule14);
            }
            if (level == "Upper-Intermediate")
            {
                UpperInterediateContent(Header, Rule1, Rule2, Rule3, Rule4, Rule5, Rule6, Rule7, Rule8, Rule9, Rule10, Rule11, Rule12, Rule13, Rule14);
            }
        }

        public static void Question1(string level, RulesElementary rules)
        {
            if (level == "Elementary")
            {
                Rule rule = new Rule("Elementary", 1);
                rule.Show();
                rules.Close();
            }
            if (level == "Pre-Intermediate")
            {
                Rule rule = new Rule("Pre-Intermediate", 1);
                rule.Show();
                rules.Close();
            }
            if (level == "Intermediate")
            {
                Rule rule = new Rule("Intermediate", 1);
                rule.Show();
                rules.Close();
            }
            if (level == "Upper-Intermediate")
            {
                Rule rule = new Rule("Upper-Intermediate", 1);
                rule.Show();
                rules.Close();
            }
        }

        public static void Question2(string level, RulesElementary rules)
        {
            if (level == "Elementary")
            {
                Rule rule = new Rule("Elementary", 2);
                rule.Show();
                rules.Close();
            }
            if (level == "Pre-Intermediate")
            {
                Rule rule = new Rule("Pre-Intermediate", 2);
                rule.Show();
                rules.Close();
            }
            if (level == "Intermediate")
            {
                Rule rule = new Rule("Intermediate", 2);
                rule.Show();
                rules.Close();
            }
            if (level == "Upper-Intermediate")
            {
                Rule rule = new Rule("Upper-Intermediate", 2);
                rule.Show();
                rules.Close();
            }
        }

        public static void Question3(string level, RulesElementary rules)
        {
            if (level == "Elementary")
            {
                Rule rule = new Rule("Elementary", 3);
                rule.Show();
                rules.Close();
            }
            if (level == "Pre-Intermediate")
            {
                Rule rule = new Rule("Pre-Intermediate", 3);
                rule.Show();
                rules.Close();
            }
            if (level == "Intermediate")
            {
                Rule rule = new Rule("Intermediate", 3);
                rule.Show();
                rules.Close();
            }
            if (level == "Upper-Intermediate")
            {
                Rule rule = new Rule("Upper-Intermediate", 3);
                rule.Show();
                rules.Close();
            }
        }

        public static void Question4(string level, RulesElementary rules)
        {
            if (level == "Elementary")
            {
                Rule rule = new Rule("Elementary", 4);
                rule.Show();
                rules.Close();
            }
            if (level == "Pre-Intermediate")
            {
                Rule rule = new Rule("Pre-Intermediate", 4);
                rule.Show();
                rules.Close();
            }
            if (level == "Intermediate")
            {
                Rule rule = new Rule("Intermediate", 4);
                rule.Show();
                rules.Close();
            }
            if (level == "Upper-Intermediate")
            {
                Rule rule = new Rule("Upper-Intermediate", 4);
                rule.Show();
                rules.Close();
            }
        }

        public static void Question5(string level, RulesElementary rules)
        {
            if (level == "Elementary")
            {
                Rule rule = new Rule("Elementary", 5);
                rule.Show();
                rules.Close();
            }
            if (level == "Pre-Intermediate")
            {
                Rule rule = new Rule("Pre-Intermediate", 5);
                rule.Show();
                rules.Close();
            }
            if (level == "Intermediate")
            {
                Rule rule = new Rule("Intermediate", 5);
                rule.Show();
                rules.Close();
            }
            if (level == "Upper-Intermediate")
            {
                Rule rule = new Rule("Upper-Intermediate", 5);
                rule.Show();
                rules.Close();
            }
        }

        public static void Question6(string level, RulesElementary rules)
        {
            if (level == "Elementary")
            {
                Rule rule = new Rule("Elementary", 6);
                rule.Show();
                rules.Close();
            }
            if (level == "Pre-Intermediate")
            {
                Rule rule = new Rule("Pre-Intermediate", 6);
                rule.Show();
                rules.Close();
            }
            if (level == "Intermediate")
            {
                Rule rule = new Rule("Intermediate", 6);
                rule.Show();
                rules.Close();
            }
            if (level == "Upper-Intermediate")
            {
                Rule rule = new Rule("Upper-Intermediate", 6);
                rule.Show();
                rules.Close();
            }
        }

        public static void Question7(string level, RulesElementary rules)
        {
            if (level == "Elementary")
            {
                Rule rule = new Rule("Elementary", 7);
                rule.Show();
                rules.Close();
            }
            if (level == "Pre-Intermediate")
            {
                Rule rule = new Rule("Pre-Intermediate", 7);
                rule.Show();
                rules.Close();
            }
            if (level == "Intermediate")
            {
                Rule rule = new Rule("Intermediate", 7);
                rule.Show();
                rules.Close();
            }
            if (level == "Upper-Intermediate")
            {
                Rule rule = new Rule("Upper-Intermediate", 7);
                rule.Show();
                rules.Close();
            }
        }

        public static void Question8(string level, RulesElementary rules)
        {
            if (level == "Elementary")
            {
                Rule rule = new Rule("Elementary", 8);
                rule.Show();
                rules.Close();
            }
            if (level == "Pre-Intermediate")
            {
                Rule rule = new Rule("Pre-Intermediate", 8);
                rule.Show();
                rules.Close();
            }
            if (level == "Intermediate")
            {
                Rule rule = new Rule("Intermediate", 8);
                rule.Show();
                rules.Close();
            }
            if (level == "Upper-Intermediate")
            {
                Rule rule = new Rule("Upper-Intermediate", 8);
                rule.Show();
                rules.Close();
            }
        }

        public static void Question9(string level, RulesElementary rules)
        {
            if (level == "Elementary")
            {
                Rule rule = new Rule("Elementary", 9);
                rule.Show();
                rules.Close();
            }
            if (level == "Pre-Intermediate")
            {
                Rule rule = new Rule("Pre-Intermediate", 9);
                rule.Show();
                rules.Close();
            }
            if (level == "Intermediate")
            {
                Rule rule = new Rule("Intermediate", 9);
                rule.Show();
                rules.Close();
            }
            if (level == "Upper-Intermediate")
            {
                Rule rule = new Rule("Upper-Intermediate", 9);
                rule.Show();
                rules.Close();
            }
        }

        public static void Question10(string level, RulesElementary rules)
        {
            if (level == "Elementary")
            {
                Rule rule = new Rule("Elementary", 10);
                rule.Show();
                rules.Close();
            }
            if (level == "Pre-Intermediate")
            {
                Rule rule = new Rule("Pre-Intermediate", 10);
                rule.Show();
                rules.Close();
            }
            if (level == "Intermediate")
            {
                Rule rule = new Rule("Intermediate", 10);
                rule.Show();
                rules.Close();
            }
            if (level == "Upper-Intermediate")
            {
                Rule rule = new Rule("Upper-Intermediate", 10);
                rule.Show();
                rules.Close();
            }
        }

        public static void Question11(string level, RulesElementary rules)
        {
            if (level == "Elementary")
            {
                Rule rule = new Rule("Elementary", 11);
                rule.Show();
                rules.Close();
            }
            if (level == "Pre-Intermediate")
            {
                Rule rule = new Rule("Pre-Intermediate", 11);
                rule.Show();
                rules.Close();
            }
            if (level == "Intermediate")
            {
                Rule rule = new Rule("Intermediate", 11);
                rule.Show();
                rules.Close();
            }
            if (level == "Upper-Intermediate")
            {
                Rule rule = new Rule("Upper-Intermediate", 11);
                rule.Show();
                rules.Close();
            }
        }

        public static void Question12(string level, RulesElementary rules)
        {
            if (level == "Elementary")
            {
                Rule rule = new Rule("Elementary", 12);
                rule.Show();
                rules.Close();
            }
            if (level == "Pre-Intermediate")
            {
                Rule rule = new Rule("Pre-Intermediate", 12);
                rule.Show();
                rules.Close();
            }
            if (level == "Intermediate")
            {
                Rule rule = new Rule("Intermediate", 12);
                rule.Show();
                rules.Close();
            }
            if (level == "Upper-Intermediate")
            {
                Rule rule = new Rule("Upper-Intermediate", 12);
                rule.Show();
                rules.Close();
            }
        }

        public static void Question13(string level, RulesElementary rules)
        {
            if (level == "Elementary")
            {
                Rule rule = new Rule("Elementary", 13);
                rule.Show();
                rules.Close();
            }
            if (level == "Pre-Intermediate")
            {
                Rule rule = new Rule("Pre-Intermediate", 13);
                rule.Show();
                rules.Close();
            }
            if (level == "Intermediate")
            {
                Rule rule = new Rule("Intermediate", 13);
                rule.Show();
                rules.Close();
            }
            if (level == "Upper-Intermediate")
            {
                Rule rule = new Rule("Upper-Intermediate", 13);
                rule.Show();
                rules.Close();
            }
        }

        public static void Question14(string level, RulesElementary rules)
        {
            if (level == "Elementary")
            {
                Rule rule = new Rule("Elementary", 14);
                rule.Show();
                rules.Close();
            }
            if (level == "Pre-Intermediate")
            {
                Rule rule = new Rule("Pre-Intermediate", 14);
                rule.Show();
                rules.Close();
            }
            if (level == "Intermediate")
            {
                Rule rule = new Rule("Intermediate", 14);
                rule.Show();
                rules.Close();
            }
            if (level == "Upper-Intermediate")
            {
                Rule rule = new Rule("Upper-Intermediate", 14);
                rule.Show();
                rules.Close();
            }
        }

        public static void OpenMainWindow(RulesElementary rules)
        {
            MainRules main = new MainRules();
            main.Show();
            rules.Close();
        }
    }
}
