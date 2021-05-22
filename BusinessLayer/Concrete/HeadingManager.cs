using BusinessLayer.Abstract;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Abstract;

namespace BusinessLayer.Concrete
{
    public class HeadingManager : IHeadingService
    {
        private EfHeadingDal _efHeadingDal;
        public HeadingManager(EfHeadingDal efHeadingDal)
        {
            _efHeadingDal = efHeadingDal;
        }
        
        public List<Heading> GetList()
        {
            return _efHeadingDal.List();
        }
    }
}
