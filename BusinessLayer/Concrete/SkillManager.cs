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
    public class SkillManager : ISkillService
    {
        public SkillManager(EfSkillDal efSkillDal)
        {
            EfSkill = efSkillDal;
        }
        private EfSkillDal EfSkill;
        public List<Skill> GetList()
        {
            return EfSkill.List();
        }
    }
}
