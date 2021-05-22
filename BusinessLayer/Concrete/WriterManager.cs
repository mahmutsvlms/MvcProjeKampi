using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WriterManager:IWriterService
    {
        private EfWriterDal _efWriterDal;
        public WriterManager(EfWriterDal efWriterDal)
        {
            _efWriterDal = efWriterDal;
        }

        public List<Writer> GetList()
        {
            return _efWriterDal.List();
        }
    }
}
