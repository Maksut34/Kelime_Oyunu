using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Kel_DAL.RepoStory
{
	public class RepoStory<T, TContext> : IRepoStory<T> where T : class where TContext : DbContext, new()
	{
		public int Deleted(T delete)
		{
			using (var context = new TContext())
			{
				context.Set<T>().Remove(delete);
				return context.SaveChanges();
			}
		}

		public T Fınd(int fınd)
		{
			using (var context = new TContext())
			{
				return context.Set<T>().Find(fınd);
			}
		}



		public List<T> getAll(Expression<Func<T, bool>> getall)
		{
			using (var context = new TContext())
			{
				return context.Set<T>().Where(getall).ToList();
			}
		}

		public T getbyID(int get)
		{
			using (var context = new TContext())
			{
				return context.Set<T>().Find(get);

			}
		}

		public int Insert(T add)
		{
			using (var context = new TContext())
			{
				context.Set<T>().Add(add);
				return context.SaveChanges();
			}
		}

		public T List(int list)
		{
			using (var context = new TContext())
			{
				return context.Set<T>().Find(list);
			}
		}

		public List<T> Lıst(Expression<Func<T, bool>> list)
		{
			using (var context = new TContext())
			{
				return context.Set<T>().Where(list).ToList();
			}
		}

		public int Update(T up)
		{
			using (var context = new TContext())
			{
				//context.Set<T>().Update(up);
				context.Entry(up).State = EntityState.Modified;
				return context.SaveChanges();

			}
		}

		public T Find(Expression<Func<T, bool>> fınd)
		{
			using (var context = new TContext())
			{
				return context.Set<T>().FirstOrDefault(fınd);
			}
		}

		public T GetRandomSoru()
		{
			using (var context = new TContext())
			{
				var sorular = context.Set<T>().ToList();
				if (sorular.Count > 0)
				{
					Random random = new Random();
					int randomIndex = random.Next(0, sorular.Count);
					return sorular[randomIndex];
				}
				return null;
			}
		}
	}
}
