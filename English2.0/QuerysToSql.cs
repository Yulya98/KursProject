using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English2._0
{
	public class QuerysToSql
	{
		private CodeFirst db;

		private CodeFirst db2;

		private CodeFirst db3;

		public QuerysToSql(CodeFirst context,CodeFirst context2, CodeFirst context3)
		{
			this.db = context;
			this.db2 = context2;
			this.db3 = context3;
		}

		//WorkWithActiveDictionary
		public IEnumerable<int> CheckDatabase()
		{
			IEnumerable<int> query = from userId in db.UsersWords
									 join user in db.Users
									 on new { userId.UserId }
									 equals new { user.UserId }
									 where user.UserName == Users.aktivePlyer && userId.flag == true
									 select userId.WordId;
			return query;
		}

		public IEnumerable<string> ConnectWithCheckDatabase()
		{
			IEnumerable<int> query = CheckDatabase();
			var queryToWords = from word in db2.Words
							   where query.Contains(word.WordId)
							   select word.Word;
			return queryToWords;
		}
		//WorkWithAgreeOtherPlyer

		public IEnumerable<int> queryToUsersFirst()
		{
			IEnumerable<int> indexFirst = from u in db.Users
										  where u.UserName == Users.aktivePlyer
										  select u.UserId;
			return indexFirst;
		}

		public IEnumerable<int> queryToUsersSecond(int indexS)
		{
			IEnumerable<int> index = from u in db.Play
									 where u.SecondId == indexS
									 select u.FirstId;
			return index;
		}

		public IEnumerable<string> ContentAgree(int index)
		{
			IEnumerable<string> name = from u in db.Users
									   where u.UserId == index
									   select u.UserName;
			return name;
		}

		public void Update()
		{
			WorkWithAgreeOtherPlyer work = new WorkWithAgreeOtherPlyer();
			DateTime date = new DateTime();
			date = DateTime.Today;
			Play result = (from p in db.Play
						   where p.FirstId == work.queryToUsersSecond(work.queryToUsersFirst()) && p.SecondId == work.queryToUsersFirst()
						   select p).SingleOrDefault();

			result.Date = date;
			result.Start = true;

			db.SaveChanges();
		}

		public void Delete()
		{
			WorkWithAgreeOtherPlyer work = new WorkWithAgreeOtherPlyer();
			CodeFirst context = new CodeFirst();
			Play play = context.Play
				.Where(o => o.FirstId == work.queryToUsersSecond(work.queryToUsersFirst()) && o.SecondId == work.queryToUsersFirst())
				.FirstOrDefault();
			context.Play.Remove(play);
			context.SaveChanges();
		}
		//WorkWithCreatePlyer
		public IEnumerable<string> Check()
		{
			IEnumerable<string> checkEnum = from u in db.Users
											select u.UserName;
			return checkEnum;
		}

		public IEnumerable<int> SelectUserId(string text)
		{
			var queryToUsers = from u in db.Users
							   where u.UserName == text
							   select u.UserId;
			return queryToUsers;
		}

		public IEnumerable<int> SelectWordId()
		{
			var queryToWords = from u in db.Words
							   select u.WordId;
			return queryToWords;
		}

		public void SaveToDB()
		{
			db.SaveChanges();
		}

		public void AddToDB(UsersWords users)
		{
			db.UsersWords.Add(users);
		}

		public void AddToDbUser(Users users)
		{
			db.Users.Add(users);
		}

		//WorkWithGame
		public IEnumerable<int> getWordsFromAktivePlyer()
		{
			IEnumerable<int> query = from userId in db.UsersWords
									 join user in db.Users
									 on new { userId.UserId }
									 equals new { user.UserId }
									 where user.UserName == Users.aktivePlyer && userId.flag == true && userId.flagForPlay == false
									 select userId.WordId;
			return query;
		}

		public IEnumerable<Words> getWordsFromAktivePlyer2()
		{
			IEnumerable<int> query = getWordsFromAktivePlyer();
			IEnumerable<Words> queryToWords = from word in db2.Words
											   where query.Contains(word.WordId)
											   select word;
			return queryToWords;
		}

		public IEnumerable<Play> CheckPlayDB()
		{
			IEnumerable<int> index = queryToUsersFirst();
			IEnumerable<Play> succsessPlyer1 = from u in db3.Play
											   where index.Contains(u.FirstId)
											   select u;
			return succsessPlyer1;
		}

		public IEnumerable<Play> CheckPlayDB2()
		{
			IEnumerable<int> index = queryToUsersFirst();
			IEnumerable<Play> succsessPlyer2 = from u in db2.Play
											   where index.Contains(u.SecondId)
											   select u;
			return succsessPlyer2;
		}

		public void ConnectToPlay(int index)
		{
			Play result = (from p in db.Play
						   where p.FirstId == index
						   select p).SingleOrDefault();
			result.Result += 1;
			db.SaveChanges();
		}

		public void ConnectToPlaySecondId(int index)
		{
			//CodeFirst context = new CodeFirst();
			Play result = (from p in db.Play
						   where p.SecondId == index
						   select p).SingleOrDefault();

			result.Result -= 1;
			db.SaveChanges();
		}

		public IEnumerable<int> ConnectToDatabaseAndDelete(string str)
		{
			var SerchWordWithTranslate = from word in db3.Words
										 where word.Translate == str
										 select word.WordId;
			return SerchWordWithTranslate;
		}

		public IEnumerable<UsersWords> ConnectToDatabaseAndDelete2(string str)
		{
			IEnumerable<int> SerchWordWithTranslate = ConnectToDatabaseAndDelete(str);
			IEnumerable<UsersWords> query = from userId in db.UsersWords
											join user in db.Users
											on new { userId.UserId }
											equals new { user.UserId }
											where user.UserName == Users.aktivePlyer && SerchWordWithTranslate.Contains(userId.WordId)
											select userId;
			return query;
		}

		//WorkWithLearnWords
		public IEnumerable<int> getWordsFromAktivePlyer3()
		{
			IEnumerable<int> query = from userId in db3.UsersWords
									 join user in db3.Users
									 on new { userId.UserId }
									 equals new { user.UserId }
									 where user.UserName == Users.aktivePlyer && userId.flag == false
									 select userId.WordId;
			return query;
		}

		public IEnumerable<Words> getWordsFromAktivePlyer4()
		{
			IEnumerable<int> query = getWordsFromAktivePlyer3();
			IEnumerable<Words> queryToWords = from word in db2.Words
							   where query.Contains(word.WordId)
							   select word;
			return queryToWords;
		}

		public IEnumerable<int> ConnectToDatabaseAndDelete3(string str)
		{
			var SerchWordWithTranslate = from word in db2.Words
										 where word.Translate ==str
										 select word.WordId;
			return SerchWordWithTranslate;
		}

		public IEnumerable<UsersWords> ConnectToDatabaseAndDelete4(string str)
		{
			IEnumerable<int> SerchWordWithTranslate = ConnectToDatabaseAndDelete3(str);
			IEnumerable<UsersWords> query = from userId in db.UsersWords
											join user in db.Users
											on new { userId.UserId }
											equals new { user.UserId }
											where user.UserName == Users.aktivePlyer && SerchWordWithTranslate.Contains(userId.WordId)
											select userId;
			return query;
		}

		//WorkWithMainForm
		public IEnumerable<UsersWords> CanUseBuutonPlay(int id)
		{
			IEnumerable<UsersWords> words = from u in db.UsersWords
											where u.UserId == id && u.flag == true
											select u;
			return words;
		}

		public IEnumerable<DateTime> CheckDate(int index)
		{
			IEnumerable<DateTime> date = from u in db.Play
										 where u.FirstId == index || u.SecondId == index
										 select u.Date;
			return date;
		}

		public IEnumerable<Play> CheckOnAgree(int index)
		{
			IEnumerable<Play> play = from u in db.Play
									 where u.SecondId == index && u.Start == false
									 select u;
			return play;
		}

		public IEnumerable<Play> CheckOnAgree2(int index)
		{
			IEnumerable<Play> playSituation2 = from u in db.Play
											   where u.FirstId == index && u.Start == false
											   select u;
			return playSituation2;
		}

		public IEnumerable<Play> CheckOnAgree3(int index)
		{
			WorkWithMainForm work = new WorkWithMainForm();
			IEnumerable<Play> playSituation3 = from u in db.Play
											   where u.FirstId == index && u.Start == true && work.CheckDate(index) < 1
											   select u;
			return playSituation3;
		}

		public IEnumerable<Play> CheckOnAgree4(int index)
		{
			WorkWithMainForm work = new WorkWithMainForm();
			IEnumerable<Play> playSituation4 = from u in db.Play
											   where u.SecondId == index && u.Start == true && work.CheckDate(index) < 1
											   select u;
			return playSituation4;
		}

		//WorkWithResult
		public IEnumerable<Users> CheckNewLevel(string level)
		{
			IEnumerable<Users> usersList = db.Users
	                     .Where(c => c.UserName == Users.aktivePlyer)
	                     .AsEnumerable()
	                     .Select(c =>
	                         {
		                     c.level = level;
		                     return c;
	                      });
			db.SaveChanges();
			return usersList;
		}

		//WorkWithSelectPlyer
		public IEnumerable<UsersWords> DownladContent()
		{
			IEnumerable<int> idActivePlyer = queryToUsersFirst();
			IEnumerable<UsersWords> wordActiveCount = from u in db3.UsersWords
													  where idActivePlyer.Contains(u.UserId) && u.flag == true
													  select u;
			return wordActiveCount;
		}

		public IEnumerable<UsersWords> DownladContent2()
		{
			IEnumerable<int> idActivePlyer = queryToUsersFirst();
			IEnumerable<UsersWords> wordsOtherUsers = from u in db2.UsersWords
													  where u.flag == true && !idActivePlyer.Contains(u.UserId)
													  select u;
			return wordsOtherUsers;
		}

		public object DownladContent3()
		{
			IEnumerable<UsersWords> wordsOtherUsers = DownladContent2();
			var count = from p in wordsOtherUsers
						group p by p.UserId into g
						select new
						{
							Name = g.Key,
							Count = g.Count()
						};
			return count;
		}

		public IEnumerable<int> CheckPlyer(string str)
		{
			IEnumerable<int> secondPlyer = from u in db3.Users
										   where u.UserName == str
										   select u.UserId;
			return secondPlyer;
		}

		public void AddToPlay(Play plyers)
		{
			db.Play.Add(plyers);
		}

		//WorkWithWinner
		public IEnumerable<int> CheckPlayDB(int index)
		{
			IEnumerable<int> result = from u in db3.Play
									  where u.FirstId == index
									  select u.Result;
			return result;
		}

		public IEnumerable<int> CheckPlayResult(int index)
		{
			IEnumerable<int> result = from u in db2.Play
									  where u.FirstId == index
									  select u.Result;
			return result;
		}

		public IEnumerable<Users> CheckPlyer()
		{
			IEnumerable<Users> checkEnum = from u in db.Users
										   select u;
			return checkEnum;
		}
	}
}
