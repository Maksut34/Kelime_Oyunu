﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Kel_DAL.RepoStory
{
	public interface IRepoStory<T> where T : class
	{
		T getbyID(int get);
		T List(int list);
		T Fınd(int fınd);
		int Insert(T add);
		int Update(T up);
		int Deleted(T delete);
		List<T> getAll(Expression<Func<T, bool>> getall);
		List<T> Lıst(Expression<Func<T, bool>> list);
		T Find(Expression<Func<T, bool>> fınd);
		T GetRandomSoru();
	}
}
