using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English2._0
{
    public class WorkWithSelectLevel
    {
        public static void ChooseLevel(string level,SelectLevel select)
        {
            if (level == "Elementary")
            {
                Tests tests = new Tests(level);
                tests.Show();
                select.Close();
            }

            if(level == "Pre-Intermediate")
            {
                Tests tests = new Tests(level);
                tests.Show();
                select.Close();
            }
            if(level == "Intermediate")
            {
                Tests tests = new Tests(level);
                tests.Show();
                select.Close();
            }
            if(level == "Upper - Intermediate")
            {
                Tests tests = new Tests(level);
                tests.Show();
                select.Close();
            }
            if(level == "")
            {
                MainWindow main = new MainWindow();
                main.Show();
                select.Close();
            }
        }
    }
}
