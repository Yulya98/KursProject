using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace English2._0
{
	public class UnitOfWork
	{
		public CodeFirst context = new CodeFirst();

		public CodeFirst context2 = new CodeFirst();

		public CodeFirst context3 = new CodeFirst();

		public QuerysToSql querys;

		public QuerysToSql Sql
		{
			get
			{
				if (querys == null)
					querys = new QuerysToSql(context,context2,context3);
				return querys;
			}

		}

		public void Save()
		{
			context.SaveChanges();
		}

		private bool disposed = false;

		public virtual void Dispose(bool disposing)
		{
			if (!this.disposed)
			{
				if (disposing)
				{
					context.Dispose();
				}
				this.disposed = true;
			}
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
	}
}
