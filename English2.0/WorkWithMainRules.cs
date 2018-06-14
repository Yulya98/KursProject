using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English2._0
{
    class WorkWithMainRules
    {
        public static void OpenElementary(MainRules main)
        {
            RulesElementary rule = new RulesElementary("Elementary");
            rule.Show();
            main.Close();
        }

        public static void OpenPreIntermediate(MainRules main)
        {
            RulesElementary rule = new RulesElementary("Pre-Intermediate");
            rule.Show();
            main.Close();
        }

        public static void OpenIntermediate(MainRules main)
        {
            RulesElementary rule = new RulesElementary("Intermediate");
            rule.Show();
            main.Close();
        }

        public static void OpenUpperIntermediate(MainRules main)
        {
            RulesElementary rule = new RulesElementary("Upper-IntermediateRule");
            rule.Show();
            main.Close();
        }

        public static void OpenMain(MainRules mainRule)
        {
            MainWindow main = new MainWindow();
            main.Show();
            mainRule.Close();
        }
    }
}
