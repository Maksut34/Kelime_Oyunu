using Kel_Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kel_DAL.Data
{
	public class DataContext:DbContext
	{
		public DataContext()
		{
			Database.Connection.ConnectionString = "Server=Maksut-OZDEMIR\\SQLEXPRESS02;Database=Kelime_Oyunu;uid=sa;pwd=1;";
		}

		DbSet<Öneriler> öneriler { get; set; }
		DbSet<Users> Users { get; set; }
		
	}
}
