using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
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
        IWriterDal _writerDal;
        //private EfWriterDal _efWriterDal;
        //public WriterManager(EfWriterDal efWriterDal)
        //{
        //    _efWriterDal = efWriterDal;
        //}

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public WriterManager(IWriterDal writerDal, EfWriterDal efWriterDal)
        {
            _writerDal = writerDal;
           //_efWriterDal = efWriterDal;
        }

        public Writer GetByID(int id)
        {
            return _writerDal.Get(x => x.WriterID == id);
        }

        public List<Writer> GetList()
        {
            return _writerDal.List();
            //return _efWriterDal.List();
        }

        public void WriterAdd(Writer writer)
        {
            _writerDal.Insert(writer);
        }

        public void WriterDelete(Writer writer)
        {
            _writerDal.Delete(writer);
        }

        public void WriterUpdate(Writer writer)
        {
            _writerDal.Update(writer);
        }
    }
}
