using BLL.Abstarct;
using Kel_DAL.Abstract;
using Kel_Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Concreate
{
	public class ÖneriManager : IÖneriService
	{
		private IÖneriDal _öneri;
		public ÖneriManager(IÖneriDal öneri) 
		{
			_öneri = öneri;
		}

		public int Deleted(Öneriler delete)
		{
			return _öneri.Deleted(delete);
		}

		public Öneriler Find(Expression<Func<Öneriler, bool>> fınd)
		{
			return _öneri.Find(fınd);
		}

		public Öneriler Fınd(int fınd)
		{
			return _öneri.Fınd(fınd);
		}

		public List<Öneriler> getAll(Expression<Func<Öneriler, bool>> getall)
		{
			return _öneri.getAll(getall);
		}

		public Öneriler getbyID(int get)
		{
			return _öneri.getbyID(get);
		}

		public Öneriler GetRandomSoru()
		{
			return _öneri.GetRandomSoru();
		}

		public int Insert(Öneriler add)
		{
			return _öneri.Insert(add);
		}

		public Öneriler List(int list)
		{
			return _öneri.List(list);
		}

		public List<Öneriler> Lıst(Expression<Func<Öneriler, bool>> list)
		{
			return _öneri.Lıst(list);
		}

		public int Update(Öneriler up)
		{
			return _öneri.Update(up);	
		}
	}
}
