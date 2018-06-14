using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace English2._0
{
    public class WorkWithRule
    {
        public static void SelectElementary(int number,Label Header, TextBlock TextRule)
        {
            if (number == 1)
            {
                Header.Content = "Употребление am/is/are в английском языке";
                TextRule.Text = "I    -    am  \n  She   -    is \n He   -    is \n It    -   is  \n You   -   are \n  We    -    are  \n They   -    are";
            }
            if (number == 2)
            {
                Header.Content = "Устойчивые выражения с from/to/at";
                TextRule.Text = "Употребление предлога \"from\": Направления действия («откуда? от кого?») Пример: I did not hear from him for 20 years. Стартового момента выполнения действия: This bank is working from 9 to 6. Английский предлог to может обозначать направление. Значение предлога в таком случае равноценно дательному падежу в русском языке: Throw the ball to me! Также предлог to может вводить лицо, на которое было направлено некое действие: Our daughter loves to sing to us. Предлог at может обозначать место: The sofa at the window is too old. C названиями городов могут использоваться два английских предлога – at и in. Предлог at при этом обозначает город как точку на карте: We had a change of plane at Budapest on our way to Roma. Также предлог at может обозначать время.";
            }
            if (number == 3)
            {
                Header.Content = "Модальный глагол can";
                TextRule.Text = "Модальный глагол Can, как и почти все модальные глаголы, является недостаточным глаголом, то есть не имеет всех обычных для глагола форм. Он используется только в двух формах: can – для употребления в настоящем времени и could – в прошедшем времени и сослагательном наклонении. Заметьте, что в третьем лице единственного числа к Can и другим недостаточным глаголам не прибавляется окончание –s: He can write poems. Для отражения физической или умственной способности, умения что-то сделать: I cannot run so fast! Для обозначения общей возможности: He can be anywhere right now. Теоретической возможности: You can find any kind of information on the Internet. Для того, чтобы попросить/дать разрешение: Can I try on that coat? Для запрещения чего-либо (в отрицательной форме cannot / can’t): You cannot walk on the grass. При просьбе: Can I have a glass of water?";
            }
            if (number == 4)
            {
                Header.Content = "Как сказать время на английском";
                TextRule.Text = "Разберем на примерах, как сказать время на английском языке: It’s three o’clock. – Три часа. Если время не точное, а с минутами, то есть два варианта, как это сказать. Когда минут менее 30, то мы говорим past, а если минутная стрелка уже перешагнула за 30, то to: It’s five past three. – «Пять минут после трех», то есть пять минут четвертого. Самое интересное начинается, когда нам надо сказать «15 минут» или «без 15». По-русски мы иногда говорим «четверть», и в английском то же самое – quarter. It’s a quarter past six. – «Четверть после шести», то есть четверть седьмого или пятнадцать минут седьмого. Также у нас есть отдельное слово для «половины» – half. И обычно используют только past, когда говорят «половина пятого», например: It’s half past four. – «Половина после четырех», то есть половина пятого.Если мы сообщаем приблизительное время, то используем предлоги about (около) / almost (почти): It’s about eight. – Около восьми.";
            }
            if (number == 5)
            {
                Header.Content = "Модальный глагол must";
                TextRule.Text = "Модальный глагол Must имеет общее значение долженствования и употребляется для выражения необходимости совершения действия в силу определенных обстоятельств, а также для выражения приказания или совета. Для выражения непосредственной необходимости или обязанности: I must make sure cargoes reach their destination. В отличие от глагола Have to модальный глагол Must скорее означает осознанную необходимость, исходящую изнутри, а не вызванную по принуждению внешними обстоятельствами: People must take care of nature. При использовании во втором лице модальный глагол Must означает прямой приказ: You must prepare the monthly sales report. При запрете (отрицательных приказах): You must not use computer for more than 6 hours straight. Для выражения уверенности, высокой вероятности (переводится на русский язык как «должно быть», «наверняка»): He must be on his way here. Иногда модальный глагол Must используется для придания предложению большей эмоциональности: At this time, when I have no money, they must fire me.";
            }
            if (number == 6)
            {
                Header.Content = "Вопросительные слова";
                TextRule.Text = "Who? - Кто. \n What? - 	Что. \n Which? - 	Какой? \n Который? \n When? - Когда? \n Where? - 	Где? \n Why? - 	Почему? \n How? - 	Как? \n How much/many? - Сколько? \n How much time? - Сколько времени? ";
            }
            if (number == 7)
            {
                Header.Content = "Указательные местоимения";
                TextRule.Text = "К указательным местоимениям в английском языке относятся следующие местоимения: this, that, these, those, such. Указательные местоимения служат для указания на предметы, находящиеся рядом (this, these) или на некотором расстоянии (that, those) от говорящего.";
            }
            if (number == 8)
            {
                Header.Content = "Притяжательные местоимения";
                TextRule.Text = "Притяжательные местоимения: my, your, his, her, its, our, their, mine, yours, his, hers, ours, theirs. Притяжательные местоимения отражают принадлежность или связь предметов: My book is black and his is yellow. ";
            }
            if (number == 9)
            {
                Header.Content = "Окончание -s";
                TextRule.Text = "Практически все существительные образуют множественное число путем прибавления -s (-es). Например:dog — dogs. Глаголы в 3-ем лице единственном числе во времени Present Simple: She plays tennis every weekend. Притяжательный падеж существительных: John’s car — машина Джона";
            }
            if (number == 10)
            {
                Header.Content = "Постановка вопроса";
                TextRule.Text = "Общий вопрос. Если на вопрос надо ответить «да» или «нет», то это общий вопрос. Его еще называют “Yes / No question”. Общая схема для такого вопроса выглядит так: Do (вспомогательный глагол) you (подлежащее) play (сказуемое) computer games (дополнение)? – Ты играешь в компьютерные игры? Специальный вопрос: На такой вопрос уже просто «да» или «нет» не ответить. Он требует подробного и развернутого ответа. Специальный вопрос в английском языке отличается тем, что он может быть задан к любому члену предложения. Порядок слов в таких вопросах такой же, как и в общем, только в начале надо поставить одно из вопросительных слов: Where (вопросительное слово) are (вспомогательный глагол) you (подлежащее) going (сказуемое)? – Куда ты идешь? Разделительный вопрос: He reads a book, doesn’t he? – Он читает книгу, не так ли? Вопрос к подлежащему.Самый легкий для формирования вопрос. Вам нужно взять утвердительное предложение, убрать подлежащее и вместо него поставить who (кто) или what (что). Никакие вспомогательные глаголы не нужны. Есть лишь один нюанс – в настоящем времени прибавляем окончание —s к глаголу: Who invites guests for the party? – Кто приглашает гостей на вечеринку?";
            }
            if (number == 11)
            {
                Header.Content = "Формирование Past Simple";
                TextRule.Text = "Время Past Simple используется для обозначения действия, которое произошло в определенное время в прошлом и время совершения которого уже истекло. Для уточнения момента совершения действия в прошлом при использовании времени Past Simple обычно используются такие слова, как five days ago (пять дней назад), last year (в прошлом году), yesterday (вчера), in 1980 (в 1980 году) и т.п.Для того, чтобы поставить английский глагол во время Past Simple, нужно использовать его «вторую форму». Для большинства глаголов она образуется прибавлением окончания -ed: examine – examined, enjoy – enjoyed, close – closed. Однако есть также достаточно большая группа неправильных английских глаголов, которые образуют форму прошедшего времени не по общим правилам, для них форму прошедшего времени нужно просто запомнить: We saw your dog two blocks from here. В вопросительном предложении перед подлежащим нужно использовать вспомогательный глагол do в прошедшем времени – did, а после подлежащего поставить основной, значимый глагол в начальной форме: В отрицательных предложениях перед глаголом нужно поставить вспомогательный глагол did и отрицательную частицу not: We did not find our car.";
            }
            if (number == 12)
            {
                Header.Content = "Сравнительные степени";
                TextRule.Text = "Изменяться по степени сравнения могут только качественные прилагательные, которые обозначают какие-либо качества предмета и чье значение может быть выражено в большей или меньшей степени. Существует три степени сравнения прилагательных в английском языке – положительная, сравнительная и превосходная. Сравнительная степень, это когда мы сравниваем – «легче», «труднее», «зеленее», и т.д. Если слово короткое(один иди два слога), мы просто добавляем окончание -er. Если слово уже заканчивается на -е, то прибавляем только -r: large (большой) – larger (больше). Если слово заканчивается на согласную, а перед ней стоит гласная, то согласная удваивается. Если в конце слова стоит -y, а перед ней согласная, то -y меняется на -i. Превосходная степень: мы говорим о предмете, что он самый-самый – «самый красивый», «самый простой», «самый опасный», либо «наименее простой, красивый, опасный» и т.д. К коротким словам добавляем -est. С такими словами почти всегда идёт артикль the. Бывает, нужно сказать, что предмет не более красивый, умный, и т.д., а менее. Тогда перед словом ставим less (для сравнительной степени) или the least (для превосходной).Если слово сложное, состоит их двух элементов, то используем more / most или less / least.";
            }
            if (number == 13)
            {
                Header.Content = "Формирование Present Perfect";
                TextRule.Text = "Время Present Perfect обозначает действие, которое завершилось к настоящему моменту или завершено в период настоящего времени. Хотя английские глаголы в Present Perfect обычно переводятся на русский язык в прошедшем времени, следует помнить, что в английском языке эти действия воспринимаются в настоящем времени, так как привязаны к настоящему результатом этого действия: I have done my homework already. Время Present Perfect образуется при помощи вспомогательного глагола to have в настоящем времени и причастия прошедшего времени значимого глагола, то есть его «третьей формы».";
            }
            if (number == 14)
            {
                Header.Content = "Формирование Future Simple";
                TextRule.Text = "Время Future Simple ссылается на действие, которое совершится в неопределенном или отдаленном будущем. Простое будущее время обычно используется с обстоятельствами: tomorrow (завтра), next year (в следующем году), in five years (через пять лет), in 2035 (в 2035 году) и т.п. Для того, чтобы поставить глагол во временную форму Future Simple, нужно использовать его начальную форму и вспомогательный глагол will. В устной речи will чаще всего сокращается до формы ‘ll, которая может использоваться во всех лицах: I will go to Shanghai next summer. В вопросительном предложении вспомогательный глагол will ставится перед подлежащим. Значимый глагол остается после подлежащего в своей начальной форме: Will we go to the beach? В отрицательных предложениях за вспомогательным глаголом следует отрицательная частица not. Вместе они могут быть сокращены до формы won’t: I will not (won’t) let you down.";
            }
        }

        public static void PreIntermediate(int number, Label Header, TextBlock TextRule)
        {
            if (number == 1)
            {
                Header.Content = "Правило 1";
                TextRule.Text = "Текст правила 1";
            }
            if (number == 2)
            {
                Header.Content = "Правило 2";
                TextRule.Text = "Текст правила 2";
            }
            if (number == 3)
            {
                Header.Content = "Правило 3";
                TextRule.Text = "Текст правила 3";
            }
            if (number == 4)
            {
                Header.Content = "Правило 4";
                TextRule.Text = "Текст правила 4";
            }
            if (number == 5)
            {
                Header.Content = "Правило 5";
                TextRule.Text = "Текст правила 5";
            }
            if (number == 6)
            {
                Header.Content = "Правило 6";
                TextRule.Text = "Текст правила 6";
            }
            if (number == 7)
            {
                Header.Content = "Правило 7";
                TextRule.Text = "Текст правила 7";
            }
            if (number == 8)
            {
                Header.Content = "Правило 8";
                TextRule.Text = "Текст правила 8";
            }
            if (number == 9)
            {
                Header.Content = "Правило 9";
                TextRule.Text = "Текст правила 9";
            }
            if (number == 10)
            {
                Header.Content = "Правило 10";
                TextRule.Text = "Текст правила 10";
            }
            if (number == 11)
            {
                Header.Content = "Правило 11";
                TextRule.Text = "Текст правила 11";
            }
            if (number == 12)
            {
                Header.Content = "Правило 12";
                TextRule.Text = "Текст правила 12";
            }
            if (number == 13)
            {
                Header.Content = "Правило 13";
                TextRule.Text = "Текст правила 13";
            }
            if (number == 14)
            {
                Header.Content = "Правило 14";
                TextRule.Text = "Текст правила 14";
            }
        }

        public static void Intermediate(int number, Label Header, TextBlock TextRule)
        {
            if (number == 1)
            {
                Header.Content = "Правило 1";
                TextRule.Text = "Текст правила 1";
            }
            if (number == 2)
            {
                Header.Content = "Правило 2";
                TextRule.Text = "Текст правила 2";
            }
            if (number == 3)
            {
                Header.Content = "Правило 3";
                TextRule.Text = "Текст правила 3";
            }
            if (number == 4)
            {
                Header.Content = "Правило 4";
                TextRule.Text = "Текст правила 4";
            }
            if (number == 5)
            {
                Header.Content = "Правило 5";
                TextRule.Text = "Текст правила 5";
            }
            if (number == 6)
            {
                Header.Content = "Правило 6";
                TextRule.Text = "Текст правила 6";
            }
            if (number == 7)
            {
                Header.Content = "Правило 7";
                TextRule.Text = "Текст правила 7";
            }
            if (number == 8)
            {
                Header.Content = "Правило 8";
                TextRule.Text = "Текст правила 8";
            }
            if (number == 9)
            {
                Header.Content = "Правило 9";
                TextRule.Text = "Текст правила 9";
            }
            if (number == 10)
            {
                Header.Content = "Правило 10";
                TextRule.Text = "Текст правила 10";
            }
            if (number == 11)
            {
                Header.Content = "Правило 11";
                TextRule.Text = "Текст правила 11";
            }
            if (number == 12)
            {
                Header.Content = "Правило 12";
                TextRule.Text = "Текст правила 12";
            }
            if (number == 13)
            {
                Header.Content = "Правило 13";
                TextRule.Text = "Текст правила 13";
            }
            if (number == 14)
            {
                Header.Content = "Правило 14";
                TextRule.Text = "Текст правила 14";
            }
        }

        public static void UpperIntermediate(int number, Label Header, TextBlock TextRule)
        {
            if (number == 1)
            {
                Header.Content = "Правило 1";
                TextRule.Text = "Текст правила 1";
            }
            if (number == 2)
            {
                Header.Content = "Правило 2";
                TextRule.Text = "Текст правила 2";
            }
            if (number == 3)
            {
                Header.Content = "Правило 3";
                TextRule.Text = "Текст правила 3";
            }
            if (number == 4)
            {
                Header.Content = "Правило 4";
                TextRule.Text = "Текст правила 4";
            }
            if (number == 5)
            {
                Header.Content = "Правило 5";
                TextRule.Text = "Текст правила 5";
            }
            if (number == 6)
            {
                Header.Content = "Правило 6";
                TextRule.Text = "Текст правила 6";
            }
            if (number == 7)
            {
                Header.Content = "Правило 7";
                TextRule.Text = "Текст правила 7";
            }
            if (number == 8)
            {
                Header.Content = "Правило 8";
                TextRule.Text = "Текст правила 8";
            }
            if (number == 9)
            {
                Header.Content = "Правило 9";
                TextRule.Text = "Текст правила 9";
            }
            if (number == 10)
            {
                Header.Content = "Правило 10";
                TextRule.Text = "Текст правила 10";
            }
            if (number == 11)
            {
                Header.Content = "Правило 11";
                TextRule.Text = "Текст правила 11";
            }
            if (number == 12)
            {
                Header.Content = "Правило 12";
                TextRule.Text = "Текст правила 12";
            }
            if (number == 13)
            {
                Header.Content = "Правило 13";
                TextRule.Text = "Текст правила 13";
            }
            if (number == 14)
            {
                Header.Content = "Правило 14";
                TextRule.Text = "Текст правила 14";
            }
        }

        public static void SelectRule(string level, int number, Label Header, TextBlock TextRule)
        {
            if (level == "Elementary")
            {
                SelectElementary(number, Header,TextRule);
            }

            if (level == "Pre-Intermediate")
            {
                PreIntermediate(number, Header, TextRule);
            }
            if (level == "Intermediate")
            {
                Intermediate(number, Header, TextRule);
            }
            if (level == "Upper-Intermediate")
            {
                UpperIntermediate(number, Header, TextRule);
            }
        }

        public static void OpenRuleElementary(string level, Rule rule)
        {
            RulesElementary main = new RulesElementary(level);
            main.Show();
            rule.Close();
        }
    }
}
