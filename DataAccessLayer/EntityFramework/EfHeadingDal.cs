using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Concrete.Repositories;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfHeadingDal : GenericRepository<Heading>, IHeadingDal
    {
        public void Status(int id)
        {
            Context context = new Context();
            var x = context.Headings.Find(id);
            if (x.HeadingStatus)
            {
                x.HeadingStatus = false;
            }
            else
            {
                x.HeadingStatus = true;
            }
            context.SaveChanges();
        }
    }
}
