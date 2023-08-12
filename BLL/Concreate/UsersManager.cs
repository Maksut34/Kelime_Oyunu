using BLL.Abstarct;
using Kel_DAL.Abstract;
using Kel_DAL.Concreate;
using Kel_Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Concreate
{
	public class UsersManager : IUsersService
	{
		private IUsersDal _users;
		public UsersManager(IUsersDal users)
		{
			_users = users;
		}
		public int Deleted(Users delete)
		{
			return _users.Deleted(delete);
		}

		public Users Find(Expression<Func<Users, bool>> fınd)
		{
			return _users.Find(fınd);
		}

		public Users Fınd(int fınd)
		{
			return _users.Fınd(fınd);
		}

		public List<Users> getAll(Expression<Func<Users, bool>> getall)
		{
			return _users.getAll(getall);
		}

		public Users getbyID(int get)
		{
			return _users.getbyID(get);
		}

		public Users GetRandomSoru()
		{
			return _users.GetRandomSoru();
		}

		public int Insert(Users add)
		{
			return _users.Insert(add);
		}

		public Users List(int list)
		{
			return _users.List(list);
		}

		public List<Users> Lıst(Expression<Func<Users, bool>> list)
		{
			return _users.Lıst(list);
		}

		public int Update(Users up)
		{
			return _users.Update(up);
		}
	}
}
