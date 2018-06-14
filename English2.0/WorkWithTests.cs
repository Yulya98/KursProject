using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace English2._0
{
    public class WorkWithTests
    {
        public static void LoadBeginnContent(string level, ref int countPage, TextBlock Text1, TextBlock Text2, TextBlock Text3, TextBlock Text4, RadioButton Question1, RadioButton Question2, RadioButton Question3, RadioButton Question4, RadioButton Question5, RadioButton Question6, RadioButton Question7, RadioButton Question8, RadioButton Question9, RadioButton Question10, RadioButton Question11, RadioButton Question12)
        {
            if (level == "Elementary")
                Elementary1(ref countPage,Text1,Text2,Text3,Text4,Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question8, Question10, Question11, Question12);
            if (level == "Pre-Intermediate")
                Pre_Intermediate1(ref countPage, Text1, Text2, Text3, Text4, Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question8, Question10, Question11, Question12);
            if (level == "Intermediate")
                Intermediate1(ref countPage, Text1, Text2, Text3, Text4, Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question8, Question10, Question11, Question12);
            if (level == "Upper-Intermediate")
                Upper_Intermediate1(ref countPage, Text1, Text2, Text3, Text4, Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question8, Question10, Question11, Question12);
        }

        public static void MiddleResult(string questuins, string level,List<int> listWithMistakes, RadioButton Question1, RadioButton Question2, RadioButton Question3, RadioButton Question4, RadioButton Question5,RadioButton Question6, RadioButton Question7, RadioButton Question8, RadioButton Question9, RadioButton Question10, RadioButton Question11, RadioButton Question12)
        {
            if (level == "Elementary")
            {
                if (questuins == "1-4")
                {
                    if (Question2.IsChecked == false)
                        listWithMistakes.Add(1);
                    if (Question4.IsChecked == false)
                        listWithMistakes.Add(2);
                    if (Question9.IsChecked == false)
                        listWithMistakes.Add(3);
                    if (Question12.IsChecked == false)
                        listWithMistakes.Add(4);
                }
                if (questuins == "5-8")
                {
                    if (Question2.IsChecked == false)
                        listWithMistakes.Add(5);
                    if (Question4.IsChecked == false)
                        listWithMistakes.Add(6);
                    if (Question9.IsChecked == false)
                        listWithMistakes.Add(7);
                    if (Question10.IsChecked == false)
                        listWithMistakes.Add(8);
                }
                if (questuins == "9-12")
                {
                    if (Question3.IsChecked == false)
                        listWithMistakes.Add(9);
                    if (Question4.IsChecked == false)
                        listWithMistakes.Add(10);
                    if (Question8.IsChecked == false)
                        listWithMistakes.Add(11);
                    if (Question12.IsChecked == false)
                        listWithMistakes.Add(12);
                }
                if (questuins == "13-16")
                {
                    if (Question2.IsChecked == false)
                        listWithMistakes.Add(13);
                    if (Question6.IsChecked == false)
                        listWithMistakes.Add(14);
                    if (Question7.IsChecked == false)
                        listWithMistakes.Add(15);
                    if (Question12.IsChecked == false)
                        listWithMistakes.Add(16);
                }
                if (questuins == "17-19")
                {
                    if (Question3.IsChecked == false)
                        listWithMistakes.Add(17);
                    if (Question5.IsChecked == false)
                        listWithMistakes.Add(18);
                    if (Question7.IsChecked == false)
                        listWithMistakes.Add(19);
                }
            }
            if (level == "Pre-Intermediate")
            {
                if (questuins == "1-4")
                {
                    if (Question1.IsChecked == false)
                        listWithMistakes.Add(1);
                    if (Question4.IsChecked == false)
                        listWithMistakes.Add(2);
                    if (Question6.IsChecked == false)
                        listWithMistakes.Add(3);
                    if (Question12.IsChecked == false)
                        listWithMistakes.Add(4);
                }
                if (questuins == "5-8")
                {
                    if (Question2.IsChecked == false)
                        listWithMistakes.Add(5);
                    if (Question4.IsChecked == false)
                        listWithMistakes.Add(6);
                    if (Question8.IsChecked == false)
                        listWithMistakes.Add(7);
                    if (Question12.IsChecked == false)
                        listWithMistakes.Add(8);
                }
                if (questuins == "9-12")
                {
                    if (Question1.IsChecked == false)
                        listWithMistakes.Add(9);
                    if (Question5.IsChecked == false)
                        listWithMistakes.Add(10);
                    if (Question7.IsChecked == false)
                        listWithMistakes.Add(11);
                    if (Question11.IsChecked == false)
                        listWithMistakes.Add(12);
                }
                if (questuins == "13-16")
                {
                    if (Question2.IsChecked == false)
                        listWithMistakes.Add(13);
                    if (Question6.IsChecked == false)
                        listWithMistakes.Add(14);
                    if (Question7.IsChecked == false)
                        listWithMistakes.Add(15);
                    if (Question11.IsChecked == false)
                        listWithMistakes.Add(16);
                }
                if (questuins == "17-20")
                {
                    if (Question3.IsChecked == false)
                        listWithMistakes.Add(17);
                    if (Question5.IsChecked == false)
                        listWithMistakes.Add(18);
                    if (Question7.IsChecked == false)
                        listWithMistakes.Add(19);
                    if (Question11.IsChecked == false)
                        listWithMistakes.Add(20);
                }
            }
            if (level == "Intermediate")
            {
                if (questuins == "1-4")
                {
                    if (Question3.IsChecked == false)
                        listWithMistakes.Add(1);
                    if (Question6.IsChecked == false)
                        listWithMistakes.Add(2);
                    if (Question8.IsChecked == false)
                        listWithMistakes.Add(3);
                    if (Question11.IsChecked == false)
                        listWithMistakes.Add(4);
                }
                if (questuins == "5-8")
                {
                    if (Question3.IsChecked == false)
                        listWithMistakes.Add(5);
                    if (Question5.IsChecked == false)
                        listWithMistakes.Add(6);
                    if (Question7.IsChecked == false)
                        listWithMistakes.Add(7);
                    if (Question10.IsChecked == false)
                        listWithMistakes.Add(8);
                }
                if (questuins == "9-12")
                {
                    if (Question2.IsChecked == false)
                        listWithMistakes.Add(9);
                    if (Question6.IsChecked == false)
                        listWithMistakes.Add(10);
                    if (Question9.IsChecked == false)
                        listWithMistakes.Add(11);
                    if (Question11.IsChecked == false)
                        listWithMistakes.Add(12);
                }
                if (questuins == "13- 16")
                {
                    if (Question1.IsChecked == false)
                        listWithMistakes.Add(13);
                    if (Question6.IsChecked == false)
                        listWithMistakes.Add(14);
                    if (Question7.IsChecked == false)
                        listWithMistakes.Add(15);
                    if (Question11.IsChecked == false)
                        listWithMistakes.Add(16);
                }
                if (questuins == "17-20")
                {
                    if (Question1.IsChecked == false)
                        listWithMistakes.Add(17);
                    if (Question6.IsChecked == false)
                        listWithMistakes.Add(18);
                    if (Question7.IsChecked == false)
                        listWithMistakes.Add(19);
                    if (Question11.IsChecked == false)
                        listWithMistakes.Add(20);
                }
            }
            if (level == "Upper-Intermediate")
            {
                if (questuins == "1-4")
                {
                    if (Question1.IsChecked == false)
                        listWithMistakes.Add(1);
                    if (Question6.IsChecked == false)
                        listWithMistakes.Add(2);
                    if (Question7.IsChecked == false)
                        listWithMistakes.Add(3);
                    if (Question11.IsChecked == false)
                        listWithMistakes.Add(4);
                }
                if (questuins == "5-8")
                {
                    if (Question2.IsChecked == false)
                        listWithMistakes.Add(5);
                    if (Question4.IsChecked == false)
                        listWithMistakes.Add(6);
                    if (Question9.IsChecked == false)
                        listWithMistakes.Add(7);
                    if (Question10.IsChecked == false)
                        listWithMistakes.Add(8);
                }
                if (questuins == "9-12")
                {
                    if (Question2.IsChecked == false)
                        listWithMistakes.Add(9);
                    if (Question5.IsChecked == false)
                        listWithMistakes.Add(10);
                    if (Question9.IsChecked == false)
                        listWithMistakes.Add(11);
                    if (Question10.IsChecked == false)
                        listWithMistakes.Add(12);
                }
                if (questuins == "13-16")
                {
                    if (Question2.IsChecked == false)
                        listWithMistakes.Add(13);
                    if (Question4.IsChecked == false)
                        listWithMistakes.Add(14);
                    if (Question9.IsChecked == false)
                        listWithMistakes.Add(15);
                    if (Question11.IsChecked == false)
                        listWithMistakes.Add(16);
                }
                if (questuins == "17-20")
                {
                    if (Question1.IsChecked == false)
                        listWithMistakes.Add(17);
                    if (Question5.IsChecked == false)
                        listWithMistakes.Add(18);
                    if (Question9.IsChecked == false)
                        listWithMistakes.Add(19);
                    if (Question10.IsChecked == false)
                        listWithMistakes.Add(20);
                }
            }
        }

        public static void CheckResult(Tests test, List<int> listWithMistakes, string level)
        {
            ResultTest resultTest = new ResultTest(listWithMistakes, level);
            resultTest.Show();
            test.Close();
        }

        public static void Elementary1(ref int countPage,TextBlock Text1, TextBlock Text2, TextBlock Text3, TextBlock Text4, RadioButton Question1, RadioButton Question2, RadioButton Question3, RadioButton Question4, RadioButton Question5, RadioButton Question6, RadioButton Question7, RadioButton Question8, RadioButton Question9, RadioButton Question10, RadioButton Question11, RadioButton Question12)
        {
            Text1.Text = "My favourite sport …… tennis";
            Text2.Text = "Roberto is Italian. He's …… Italy.";
            Text3.Text = "…… you help me, please?";
            Text4.Text = "Moscow is the …… of Russia";
            Question1.Content = "Are      ";
            Question2.Content = "Is         ";
            Question3.Content = "Be        ";
            Question4.Content = "From   ";
            Question5.Content = "To       ";
            Question6.Content = "At       ";
            Question7.Content = "Have  ";
            Question8.Content = "Do     ";
            Question9.Content = "Can   ";
            Question10.Content = "country    ";
            Question11.Content = "nationality";
            Question12.Content = "capital      ";
            countPage++;
        }

        public static void ResetRadiobutton(RadioButton Question1, RadioButton Question2, RadioButton Question3, RadioButton Question4, RadioButton Question5, RadioButton Question6, RadioButton Question7, RadioButton Question8, RadioButton Question9, RadioButton Question10, RadioButton Question11, RadioButton Question12)
        {
            Question1.IsChecked = false;
            Question2.IsChecked = false;
            Question3.IsChecked = false;
            Question4.IsChecked = false;
            Question5.IsChecked = false;
            Question6.IsChecked = false;
            Question7.IsChecked = false;
            Question8.IsChecked = false;
            Question9.IsChecked = false;
            Question10.IsChecked = false;
            Question11.IsChecked = false;
            Question12.IsChecked = false;
        }

        public static void Elementary2(ref int countPage, TextBlock Text1, TextBlock Text2, TextBlock Text3, TextBlock Text4, RadioButton Question1, RadioButton Question2, RadioButton Question3, RadioButton Question4, RadioButton Question5, RadioButton Question6, RadioButton Question7, RadioButton Question8, RadioButton Question9, RadioButton Question10, RadioButton Question11, RadioButton Question12)
        {
            ResetRadiobutton(Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question9, Question10, Question11, Question12);
            Text1.Text = "I leave for work …… quarter past eight.";
            Text2.Text = "The doctor told me that I …… smoke.";
            Text3.Text = "…… that man in the red hat?";
            Text4.Text = "This letter is for Tom. Give it to ……";
            Question1.Content = "In          ";
            Question2.Content = "At          ";
            Question3.Content = "On         ";
            Question4.Content = "Mustn't         ";
            Question5.Content = "Doesn't have";
            Question6.Content = "At                 ";
            Question7.Content = "Whose  ";
            Question8.Content = "Who     ";
            Question9.Content = "Who's   ";
            Question10.Content = "Him    ";
            Question11.Content = "He      ";
            Question12.Content = "His      ";
            countPage++;
        }

        public static void Elementary3(ref int countPage, TextBlock Text1, TextBlock Text2, TextBlock Text3, TextBlock Text4, RadioButton Question1, RadioButton Question2, RadioButton Question3, RadioButton Question4, RadioButton Question5, RadioButton Question6, RadioButton Question7, RadioButton Question8, RadioButton Question9, RadioButton Question10, RadioButton Question11, RadioButton Question12)
        {
            ResetRadiobutton(Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question9, Question10, Question11, Question12);
            Text1.Text = "We …… to school every day.";
            Text2.Text = "She often …… fish because it's good for her.";
            Text3.Text = "She …… a letter at the moment.";
            Text4.Text = "What …… on Saturdays?";
            Question1.Content = "gos           ";
            Question2.Content = "goes         ";
            Question3.Content = "go            ";
            Question4.Content = "eats         ";
            Question5.Content = "eat          ";
            Question6.Content = "eates       ";
            Question7.Content = "write      ";
            Question8.Content = "is writing";
            Question9.Content = "writes     ";
            Question10.Content = "are you doing";
            Question11.Content = "do you           ";
            Question12.Content = "do you do     ";
            countPage++;
        }

        public static void Elementary4(ref int countPage, TextBlock Text1, TextBlock Text2, TextBlock Text3, TextBlock Text4, RadioButton Question1, RadioButton Question2, RadioButton Question3, RadioButton Question4, RadioButton Question5, RadioButton Question6, RadioButton Question7, RadioButton Question8, RadioButton Question9, RadioButton Question10, RadioButton Question11, RadioButton Question12)
        {
            ResetRadiobutton(Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question9, Question10, Question11, Question12);
            Text1.Text = "Look at Jane! She …… a red dress today!";
            Text2.Text = "Yesterday we …… to the cinema and saw a great film.";
            Text3.Text = "When …… Rome? Last summer or last winter?";
            Text4.Text = "London is …… than New York.";
            Question1.Content = "wearing            ";
            Question2.Content = "is wearing         ";
            Question3.Content = "is wear              ";
            Question4.Content = "go                    ";
            Question5.Content = "have                ";
            Question6.Content = "went                ";
            Question7.Content = "did you visit     ";
            Question8.Content = "are you visiting";
            Question9.Content = "do you visit      ";
            Question10.Content = "nosiest        ";
            Question11.Content = "noisy          ";
            Question12.Content = "vnoisier       ";
            countPage++;
        }

        public static void Elementary5(ref int countPage, TextBlock Text1, TextBlock Text2, TextBlock Text3, TextBlock Text4, RadioButton Question1, RadioButton Question2, RadioButton Question3, RadioButton Question4, RadioButton Question5, RadioButton Question6, RadioButton Question7, RadioButton Question8, RadioButton Question9, RadioButton Question10, RadioButton Question11, RadioButton Question12, Button Check)
        {
            ResetRadiobutton(Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question9, Question10, Question11, Question12);
            Text1.Text = "Paris is the …… city I've ever seen.";
            Text2.Text = "…… your homework yet?";
            Text3.Text = "…… you help me with my project, please?";
            Text4.Visibility =System.Windows.Visibility.Hidden;
            Question1.Content = "beautiful           ";
            Question2.Content = "more beautiful  ";
            Question3.Content = "most beautiful  ";
            Question4.Content = "Do you finish       ";
            Question5.Content = "Have you finished";
            Question6.Content = "Are you finishing ";
            Question7.Content = "Will     ";
            Question8.Content = "Do      ";
            Question9.Content = "Are      ";
            Question10.Visibility = System.Windows.Visibility.Hidden;
            Question11.Visibility = System.Windows.Visibility.Hidden;
            Question12.Visibility = System.Windows.Visibility.Hidden;
            Check.Margin = new System.Windows.Thickness(298, 545, 0, 0);
            Check.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            Check.Width = 185;
            Check.Height = 43;
            Check.Content = "Check";
            countPage++;
        }

        public static void Pre_Intermediate1(ref int countPage, TextBlock Text1, TextBlock Text2, TextBlock Text3, TextBlock Text4, RadioButton Question1, RadioButton Question2, RadioButton Question3, RadioButton Question4, RadioButton Question5, RadioButton Question6, RadioButton Question7, RadioButton Question8, RadioButton Question9, RadioButton Question10, RadioButton Question11, RadioButton Question12)
        {
            Text1.Text = "The blue jacket is …… than the white one.";
            Text2.Text = "I'd rather go out for dinner tonight than ……dinner at home.";
            Text3.Text = "My cousin …… his holidays with us next summer.";
            Text4.Text = "By this time next year, Jane …… Spanish for two years.";
            Question1.Content = "cheaper        ";
            Question2.Content = "cheap           ";
            Question3.Content = "less cheaper ";
            Question4.Content = "have             ";
            Question5.Content = "having          ";
            Question6.Content = "to have         ";
            Question7.Content = "spends          ";
            Question8.Content = "is spending   ";
            Question9.Content = "was spending";
            Question10.Content = "is going to study            ";
            Question11.Content = "will be studying              ";
            Question12.Content = "will have been studying  ";
            countPage++;
        }


        public static void Pre_Intermediate2(ref int countPage, TextBlock Text1, TextBlock Text2, TextBlock Text3, TextBlock Text4, RadioButton Question1, RadioButton Question2, RadioButton Question3, RadioButton Question4, RadioButton Question5, RadioButton Question6, RadioButton Question7, RadioButton Question8, RadioButton Question9, RadioButton Question10, RadioButton Question11, RadioButton Question12)
        {
            ResetRadiobutton(Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question9, Question10, Question11, Question12);
            Text1.Text = "Let's go shopping, ……?";
            Text2.Text = "Alice won't be able to buy that car …… she saves some money.";
            Text3.Text = "Rachel …… be in hospital; I just talked to her and she said she was at home.";
            Text4.Text = "Mary works …… a nurse at Pillby Hospital..";
            Question1.Content = "let's we        ";
            Question2.Content = "shall we        ";
            Question3.Content = "do we           ";
            Question4.Content = "unless          ";
            Question5.Content = "if                  ";
            Question6.Content = "as long as    ";
            Question7.Content = "mustn't        ";
            Question8.Content = "can't            ";
            Question9.Content = "won't           ";
            Question10.Content = "such            ";
            Question11.Content = "like              ";
            Question12.Content = "as                ";
            countPage++;
        }

        public static void Pre_Intermediate3(ref int countPage, TextBlock Text1, TextBlock Text2, TextBlock Text3, TextBlock Text4, RadioButton Question1, RadioButton Question2, RadioButton Question3, RadioButton Question4, RadioButton Question5, RadioButton Question6, RadioButton Question7, RadioButton Question8, RadioButton Question9, RadioButton Question10, RadioButton Question11, RadioButton Question12)
        {
            ResetRadiobutton(Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question9, Question10, Question11, Question12);
            Text1.Text = "John is soaking wet because he …… in the rain.";
            Text2.Text = "If you had studied harder, you …… the entrance exams.";
            Text3.Text = "I wish I …… at Mike; he's not talking to me now.";
            Text4.Text = "I don't think there is …… bread left.";
            Question1.Content = "has been walking        ";
            Question2.Content = "will be walking            ";
            Question3.Content = "had been walking       ";
            Question4.Content = "will have passed          ";
            Question5.Content = "would have passed     ";
            Question6.Content = "will be passing            ";
            Question7.Content = "hadn't shouted          ";
            Question8.Content = "haven't shouted        ";
            Question9.Content = "didn't shout              ";
            Question10.Content = "some           ";
            Question11.Content = "any              ";
            Question12.Content = "no                ";
            countPage++;
        }

        public static void Pre_Intermediate4(ref int countPage, TextBlock Text1, TextBlock Text2, TextBlock Text3, TextBlock Text4, RadioButton Question1, RadioButton Question2, RadioButton Question3, RadioButton Question4, RadioButton Question5, RadioButton Question6, RadioButton Question7, RadioButton Question8, RadioButton Question9, RadioButton Question10, RadioButton Question11, RadioButton Question12)
        {
            ResetRadiobutton(Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question9, Question10, Question11, Question12);
            Text1.Text = "…… he is rich, he never spends any money.";
            Text2.Text = "Do you remember …… that film?";
            Text3.Text = "The authorities …… rebuilding the houses.";
            Text4.Text = "Dogs are very loyal pets. ……, they can guard your property.";
            Question1.Content = "Despite        ";
            Question2.Content = "Although     ";
            Question3.Content = "In spite of    ";
            Question4.Content = "see               ";
            Question5.Content = "to see           ";
            Question6.Content = "seeing          ";
            Question7.Content = "are                ";
            Question8.Content = "are being      ";
            Question9.Content = "been              ";
            Question10.Content = "Because           ";
            Question11.Content = "What is more   ";
            Question12.Content = "Even though    ";
            countPage++;
        }

        public static void Pre_Intermediate5(ref int countPage, TextBlock Text1, TextBlock Text2, TextBlock Text3, TextBlock Text4, RadioButton Question1, RadioButton Question2, RadioButton Question3, RadioButton Question4, RadioButton Question5, RadioButton Question6, RadioButton Question7, RadioButton Question8, RadioButton Question9, RadioButton Question10, RadioButton Question11, RadioButton Question12,Button Check)
        {
            ResetRadiobutton(Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question9, Question10, Question11, Question12);
            Text1.Text = "It's no use …… the hedges cut until next month.";
            Text2.Text = "Her hair is not …… Catherine's.";
            Text3.Text = "I'm not sure …… David lives.";
            Text4.Text = "You …… me!";
            Question1.Content = "have        ";
            Question2.Content = "to have    ";
            Question3.Content = "having     ";
            Question4.Content = "so long    ";
            Question5.Content = "as long as";
            Question6.Content = "long as    ";
            Question7.Content = "where      ";
            Question8.Content = "in which   ";
            Question9.Content = "that          ";
            Question10.Content = "criticise always             ";
            Question11.Content = "are always criticising    ";
            Question12.Content = "always are criticising    ";
            Check.Content = "Check";
            countPage++;
        }


        public static void Intermediate1(ref int countPage, TextBlock Text1, TextBlock Text2, TextBlock Text3, TextBlock Text4, RadioButton Question1, RadioButton Question2, RadioButton Question3, RadioButton Question4, RadioButton Question5, RadioButton Question6, RadioButton Question7, RadioButton Question8, RadioButton Question9, RadioButton Question10, RadioButton Question11, RadioButton Question12)
        {
            Text1.Text = "She was very tired, … she could not sleep.";
            Text2.Text = "She … get a job as a teacher. She loves children.";
            Text3.Text = "“I love going to the beach.” “…”";
            Text4.Text = "By the time the rain stopped, we … two pots of coffee.";
            Question1.Content = "although        ";
            Question2.Content = "despite           ";
            Question3.Content = "yet                  ";
            Question4.Content = "ought            ";
            Question5.Content = "hopes            ";
            Question6.Content = "might            ";
            Question7.Content = "Neither do I          ";
            Question8.Content = "So do I                  ";
            Question9.Content = "Nor do I                ";
            Question10.Content = "have drunk             ";
            Question11.Content = "had drunk               ";
            Question12.Content = "had been drinking  ";
            countPage++;
        }

        public static void Intermediate2(ref int countPage, TextBlock Text1, TextBlock Text2, TextBlock Text3, TextBlock Text4, RadioButton Question1, RadioButton Question2, RadioButton Question3, RadioButton Question4, RadioButton Question5, RadioButton Question6, RadioButton Question7, RadioButton Question8, RadioButton Question9, RadioButton Question10, RadioButton Question11, RadioButton Question12)
        {
            ResetRadiobutton(Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question9, Question10, Question11, Question12);
            Text1.Text = "We're going to the theatre … a play.";
            Text2.Text = "You have a pet, … ?";
            Text3.Text = "If you had studied more, you …… the exam.";
            Text4.Text = "He can't decide who … to his birthday party.";
            Question1.Content = "see                      ";
            Question2.Content = "seeing                 ";
            Question3.Content = "to see                  ";
            Question4.Content = "hasn't you            ";
            Question5.Content = "don't you             ";
            Question6.Content = "have you              ";
            Question7.Content = "would have passed          ";
            Question8.Content = "would pass                       ";
            Question9.Content = "will pass                            ";
            Question10.Content = "to invite             ";
            Question11.Content = "invite                 ";
            Question12.Content = "inviting              ";
            countPage++;
        }

        public static void Intermediate3(ref int countPage, TextBlock Text1, TextBlock Text2, TextBlock Text3, TextBlock Text4, RadioButton Question1, RadioButton Question2, RadioButton Question3, RadioButton Question4, RadioButton Question5, RadioButton Question6, RadioButton Question7, RadioButton Question8, RadioButton Question9, RadioButton Question10, RadioButton Question11, RadioButton Question12)
        {
            ResetRadiobutton(Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question9, Question10, Question11, Question12);
            Text1.Text = "I tried on two pairs of trousers, but … of them fitted me.";
            Text2.Text = "He's tired. He … properly for days.";
            Text3.Text = "If I had a bigger flat, I … a party.";
            Text4.Text = "He … be famous. I've never heard of him.";
            Question1.Content = "both                 ";
            Question2.Content = "neither              ";
            Question3.Content = "either                ";
            Question4.Content = "didn't sleep       ";
            Question5.Content = "doesn't sleep     ";
            Question6.Content = "hasn't slept        ";
            Question7.Content = "have                   ";
            Question8.Content = "will have             ";
            Question9.Content = "would have        ";
            Question10.Content = "must                   ";
            Question11.Content = "can't                   ";
            Question12.Content = "mustn't               ";
            countPage++;
        }

        public static void Intermediate4(ref int countPage, TextBlock Text1, TextBlock Text2, TextBlock Text3, TextBlock Text4, RadioButton Question1, RadioButton Question2, RadioButton Question3, RadioButton Question4, RadioButton Question5, RadioButton Question6, RadioButton Question7, RadioButton Question8, RadioButton Question9, RadioButton Question10, RadioButton Question11, RadioButton Question12)
        {
            ResetRadiobutton(Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question9, Question10, Question11, Question12);
            Text1.Text = "I have … received a letter from my pen-friend.";
            Text2.Text = "When I opened the door, there wasn't …… there.";
            Text3.Text = "I live in the city, so I … busy traffic.";
            Text4.Text = "When I buy a new house, I … every room myself.";
            Question1.Content = "just          ";
            Question2.Content = "still           ";
            Question3.Content = "yet           ";
            Question4.Content = "someone ";
            Question5.Content = "no one     ";
            Question6.Content = "anyone    ";
            Question7.Content = "am used to";
            Question8.Content = "get used to";
            Question9.Content = "used to      ";
            Question10.Content = "paint          ";
            Question11.Content = "will paint    ";
            Question12.Content = "would paint";
            countPage++;
        }

        public static void Intermediate5(ref int countPage, TextBlock Text1, TextBlock Text2, TextBlock Text3, TextBlock Text4, RadioButton Question1, RadioButton Question2, RadioButton Question3, RadioButton Question4, RadioButton Question5, RadioButton Question6, RadioButton Question7, RadioButton Question8, RadioButton Question9, RadioButton Question10, RadioButton Question11, RadioButton Question12, Button Check)
        {
            ResetRadiobutton(Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question9, Question10, Question11, Question12);
            Text1.Text = "We must run to the cinema. The film … in five minutes.";
            Text2.Text = "It's no use … about the exam results. You'll know soon enough.";
            Text3.Text = "He was dirty because he … in the garden.";
            Text4.Text = "We live in … large block of flats.";
            Question1.Content = "starts          ";
            Question2.Content = "is starting   ";
            Question3.Content = "will start     ";
            Question4.Content = "worry          ";
            Question5.Content = "to worry     ";
            Question6.Content = "worrying     ";
            Question7.Content = "had been working";
            Question8.Content = "has been working ";
            Question9.Content = "had worked           ";
            Question10.Content = "one          ";
            Question11.Content = "a              ";
            Question12.Content = "the           ";
            Check.Content = "Check";
            countPage++;
        }

        public static void Upper_Intermediate1(ref int countPage, TextBlock Text1, TextBlock Text2, TextBlock Text3, TextBlock Text4, RadioButton Question1, RadioButton Question2, RadioButton Question3, RadioButton Question4, RadioButton Question5, RadioButton Question6, RadioButton Question7, RadioButton Question8, RadioButton Question9, RadioButton Question10, RadioButton Question11, RadioButton Question12)
        {
            Text1.Text = "The taxi will be here in a couple of minutes. We …… get ready to go.";
            Text2.Text = "The interviewer started off …… me why I wanted the job.";
            Text3.Text = "The stairs …… quite steep, so be careful how you go down.";
            Text4.Text = "“You mean …… Michael Jordan? Can you get his autograph for me?”";
            Question1.Content = "had better     ";
            Question2.Content = "would better ";
            Question3.Content = "should better";
            Question4.Content = "to ask      ";
            Question5.Content = "in asking  ";
            Question6.Content = "by asking ";
            Question7.Content = "are           ";
            Question8.Content = "be            ";
            Question9.Content = "is              ";
            Question10.Content = "–              ";
            Question11.Content = "the           ";
            Question12.Content = "a              ";
            countPage++;
        }

        public static void Upper_Intermediate2(ref int countPage, TextBlock Text1, TextBlock Text2, TextBlock Text3, TextBlock Text4, RadioButton Question1, RadioButton Question2, RadioButton Question3, RadioButton Question4, RadioButton Question5, RadioButton Question6, RadioButton Question7, RadioButton Question8, RadioButton Question9, RadioButton Question10, RadioButton Question11, RadioButton Question12)
        {
            ResetRadiobutton(Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question9, Question10, Question11, Question12);
            Text1.Text = "“Dad won’t mind us borrowing the car, will he?” “No, I ……”";
            Text2.Text = "We …… to the tennis club since we moved here.";
            Text3.Text = "Your eyes are red – ……?";
            Text4.Text = "I don't know when Helen …… back.";
            Question1.Content = "don't suppose it     ";
            Question2.Content = "suppose not           ";
            Question3.Content = "don't suppose        ";
            Question4.Content = "have belonged       ";
            Question5.Content = "are belonging        ";
            Question6.Content = "belong                   ";
            Question7.Content = "did you cry                ";
            Question8.Content = "have you cried           ";
            Question9.Content = "have you been crying";
            Question10.Content = "will be              ";
            Question11.Content = "is                      ";
            Question12.Content = "can                   ";
            countPage++;
        }

        public static void Upper_Intermediate3(ref int countPage, TextBlock Text1, TextBlock Text2, TextBlock Text3, TextBlock Text4, RadioButton Question1, RadioButton Question2, RadioButton Question3, RadioButton Question4, RadioButton Question5, RadioButton Question6, RadioButton Question7, RadioButton Question8, RadioButton Question9, RadioButton Question10, RadioButton Question11, RadioButton Question12)
        {
            ResetRadiobutton(Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question9, Question10, Question11, Question12);
            Text1.Text = "I …… an interview because I'd worked there before.";
            Text2.Text = "When I asked what was wrong, ……";
            Text3.Text = "Steven …… the wallet.";
            Text4.Text = "…… to Paris during the vacation.";
            Question1.Content = "needn't have           ";
            Question2.Content = "didn't need to have";
            Question3.Content = "needn't have had    ";
            Question4.Content = "I was explained the problem        ";
            Question5.Content = "the problem was explained to me";
            Question6.Content = "he explained me the problem       ";
            Question7.Content = "admitted to steal   ";
            Question8.Content = "admitted steal       ";
            Question9.Content = "admitted stealing  ";
            Question10.Content = "They are all going ";
            Question11.Content = "All they are doing  ";
            Question12.Content = "They all are going ";
            countPage++;
        }

        public static void Upper_Intermediate4(ref int countPage, TextBlock Text1, TextBlock Text2, TextBlock Text3, TextBlock Text4, RadioButton Question1, RadioButton Question2, RadioButton Question3, RadioButton Question4, RadioButton Question5, RadioButton Question6, RadioButton Question7, RadioButton Question8, RadioButton Question9, RadioButton Question10, RadioButton Question11, RadioButton Question12)
        {
            ResetRadiobutton(Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question9, Question10, Question11, Question12);
            Text1.Text = "We should use …… time we have available to discuss.";
            Text2.Text = "Some experience is …… for the job.";
            Text3.Text = "She was …… as anyone could have had.";
            Text4.Text = "…… Derek nowadays, he's so busy at the office.";
            Question1.Content = "the little of       ";
            Question2.Content = "the little           ";
            Question3.Content = "little                  ";
            Question4.Content = "really essential ";
            Question5.Content = "fairly essential  ";
            Question6.Content = "very essential   ";
            Question7.Content = "as patient teacher    ";
            Question8.Content = "a patient as teacher ";
            Question9.Content = "as patient a teacher  ";
            Question10.Content = "Hardly we ever see   ";
            Question11.Content = "We hardly ever see  ";
            Question12.Content = "We see hardly ever  ";
            countPage++;
        }

        public static void Upper_Intermediate5(ref int countPage, TextBlock Text1, TextBlock Text2, TextBlock Text3, TextBlock Text4, RadioButton Question1, RadioButton Question2, RadioButton Question3, RadioButton Question4, RadioButton Question5, RadioButton Question6, RadioButton Question7, RadioButton Question8, RadioButton Question9, RadioButton Question10, RadioButton Question11, RadioButton Question12, Button Check)
        {
            ResetRadiobutton(Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question9, Question10, Question11, Question12);
            Text1.Text = "…… in my seventies and rather unfit, I might consider taking.";
            Text2.Text = "We were delayed …… an accident.";
            Text3.Text = "…… that Marie was able to retire at the age of 50.";
            Text4.Text = "…… they slept soundly.";
            Question1.Content = "Were I not       ";
            Question2.Content = "Was I not         ";
            Question3.Content = "If I wasn't         ";
            Question4.Content = "because           ";
            Question5.Content = "because of      ";
            Question6.Content = "of because      ";
            Question7.Content = "So successful her business was,    ";
            Question8.Content = "So was her successful business,    ";
            Question9.Content = "So successful was her business,    ";
            Question10.Content = "Hot though the night air was       ";
            Question11.Content = "Hot though was the night air       ";
            Question12.Content = "Hot although the night air was    ";
            Check.Content = "Check";
            countPage++;
        }

        public static int CheckContentOnButton(string level,List<int> ListWithMistakes, ref int countPage, TextBlock Text1, TextBlock Text2, TextBlock Text3, TextBlock Text4, RadioButton Question1, RadioButton Question2, RadioButton Question3, RadioButton Question4, RadioButton Question5, RadioButton Question6, RadioButton Question7, RadioButton Question8, RadioButton Question9, RadioButton Question10, RadioButton Question11, RadioButton Question12, Button Check, Tests test)
        {
            if (level == "Elementary")
            {
                if (countPage == 1)
                {
                    MiddleResult("1-4", level,ListWithMistakes, Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question9, Question10, Question11, Question12);
                    Elementary2(ref countPage,Text1,Text2,Text3,Text4, Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question9, Question10, Question11, Question12);
                    return 1;
                }
                if (countPage == 2)
                {
                    MiddleResult("5-8", level, ListWithMistakes, Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question9, Question10, Question11, Question12);
                    Elementary3(ref countPage, Text1, Text2, Text3, Text4, Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question9, Question10, Question11, Question12);
                    return 1;
                }
                if (countPage == 3)
                {
                    MiddleResult("9-12", level, ListWithMistakes, Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question9, Question10, Question11, Question12);
                    Elementary4(ref countPage, Text1, Text2, Text3, Text4, Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question9, Question10, Question11, Question12);
                    return 1;
                }
                if (countPage == 4)
                {
                    MiddleResult("13-16", level, ListWithMistakes, Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question9, Question10, Question11, Question12);
                    Elementary5(ref countPage, Text1, Text2, Text3, Text4, Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question9, Question10, Question11, Question12, Check);
                    return 1;
                }
                if (countPage == 5)
                {
                    MiddleResult("17-19", level, ListWithMistakes, Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question9, Question10, Question11, Question12);
                    CheckResult(test, ListWithMistakes,level);
                    return 1;
                }
            }
            if (level == "Pre-Intermediate")
            {
                if (countPage == 1)
                {
                    MiddleResult("1-4", level, ListWithMistakes, Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question9, Question10, Question11, Question12);
                    Pre_Intermediate2(ref countPage, Text1, Text2, Text3, Text4, Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question9, Question10, Question11, Question12);
                    return 1;
                }
                if (countPage == 2)
                {
                    MiddleResult("5-8", level, ListWithMistakes, Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question9, Question10, Question11, Question12);
                    Pre_Intermediate3(ref countPage, Text1, Text2, Text3, Text4, Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question9, Question10, Question11, Question12);
                    return 1;
                }
                if (countPage == 3)
                {
                    MiddleResult("9-12", level, ListWithMistakes, Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question9, Question10, Question11, Question12);
                    Pre_Intermediate4(ref countPage, Text1, Text2, Text3, Text4, Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question9, Question10, Question11, Question12);
                    return 1;
                }
                if (countPage == 4)
                {
                    MiddleResult("13-16", level, ListWithMistakes, Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question9, Question10, Question11, Question12);
                    Pre_Intermediate5(ref countPage, Text1, Text2, Text3, Text4, Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question9, Question10, Question11, Question12, Check);
                    return 1;
                }
                if (countPage == 5)
                {
                    MiddleResult("17-20", level, ListWithMistakes, Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question9, Question10, Question11, Question12);
                    CheckResult(test, ListWithMistakes, level);
                    return 1;
                }
            }
            if (level == "Intermediate")
            {
                if (countPage == 1)
                {
                    MiddleResult("1-4", level, ListWithMistakes, Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question9, Question10, Question11, Question12);
                    Intermediate2(ref countPage, Text1, Text2, Text3, Text4, Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question9, Question10, Question11, Question12);
                    return 1;
                }
                if (countPage == 2)
                {
                    MiddleResult("5-8", level, ListWithMistakes, Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question9, Question10, Question11, Question12);
                    Intermediate3(ref countPage, Text1, Text2, Text3, Text4, Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question9, Question10, Question11, Question12);
                    return 1;
                }
                if (countPage == 3)
                {
                    MiddleResult("9-12", level, ListWithMistakes, Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question9, Question10, Question11, Question12);
                    Intermediate4(ref countPage, Text1, Text2, Text3, Text4, Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question9, Question10, Question11, Question12);
                    return 1;
                }
                if (countPage == 4)
                {
                    MiddleResult("13-16", level, ListWithMistakes, Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question9, Question10, Question11, Question12);
                    Intermediate5(ref countPage, Text1, Text2, Text3, Text4, Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question9, Question10, Question11, Question12, Check);
                    MiddleResult("17-20",level, ListWithMistakes, Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question9, Question10, Question11, Question12);
                    CheckResult(test, ListWithMistakes, level);
                    return 1;
                }
                if (countPage == 5)
                {
                    MiddleResult("17-20", level, ListWithMistakes, Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question9, Question10, Question11, Question12);
                    CheckResult(test, ListWithMistakes, level);
                    return 1;
                }
            }
            if (level == "Upper-Intermediate")
            {
                if (countPage == 1)
                {
                    MiddleResult("1-4", level, ListWithMistakes, Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question9, Question10, Question11, Question12);
                    Upper_Intermediate2(ref countPage, Text1, Text2, Text3, Text4, Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question9, Question10, Question11, Question12);
                    return 1;
                }
                if (countPage == 2)
                {
                    MiddleResult("5-8", level, ListWithMistakes, Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question9, Question10, Question11, Question12);
                    Upper_Intermediate3(ref countPage, Text1, Text2, Text3, Text4, Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question9, Question10, Question11, Question12);
                    return 1;
                }
                if (countPage == 3)
                {
                    MiddleResult("9-12", level, ListWithMistakes, Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question9, Question10, Question11, Question12);
                    Upper_Intermediate4(ref countPage, Text1, Text2, Text3, Text4, Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question9, Question10, Question11, Question12);
                    return 1;
                }
                if (countPage == 4)
                {
                    MiddleResult("13-16", level, ListWithMistakes, Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question9, Question10, Question11, Question12);
                    Upper_Intermediate5(ref countPage, Text1, Text2, Text3, Text4, Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question9, Question10, Question11, Question12, Check);
                    MiddleResult("17-20", level, ListWithMistakes, Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question9, Question10, Question11, Question12);
                    CheckResult(test, ListWithMistakes, level);
                    return 1;
                }
                if (countPage == 5)
                {
                    MiddleResult("17-20", level, ListWithMistakes, Question1, Question2, Question3, Question4, Question5, Question6, Question7, Question8, Question9, Question10, Question11, Question12);
                    CheckResult(test, ListWithMistakes, level);
                    return 1;
                }
            }
            return 1;
        }
    }
}
