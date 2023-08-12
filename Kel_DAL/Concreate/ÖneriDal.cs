using Kel_DAL.Abstract;
using Kel_DAL.Data;
using Kel_DAL.RepoStory;
using Kel_Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kel_DAL.Concreate
{
	public class ÖneriDal:RepoStory<Öneriler,DataContext>,IÖneriDal
	{
	}
}
