using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace English2._0
{
    public class WorkWithActiveDictionary
    {
		public WorkWithActiveDictionary()
		{
			unitOfWork = new UnitOfWork();
		}

		UnitOfWork unitOfWork;

		public void CheckDatabase(TextBlock ActveListBox)
        {
            CodeFirst context = new CodeFirst();
			IEnumerable<int> query = unitOfWork.Sql.CheckDatabase();
			CodeFirst context2 = new CodeFirst();
			IEnumerable<string> queryToWords = unitOfWork.Sql.ConnectWithCheckDatabase();
			foreach (string str in queryToWords)
            {
                ActveListBox.Text = str + "\n";
            }
        }

        public void OpenLearnWindow(ActiveDictionary active)
        {
            Learn_words main = new Learn_words();
            main.Show();
            active.Close();
        }
    }
}
