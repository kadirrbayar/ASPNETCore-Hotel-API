using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TutorialManager : ITutorialService
    {
        private readonly ITutorialDal _tutorialDal;

        public TutorialManager(ITutorialDal tutorialDal)
        {
            _tutorialDal = tutorialDal;
        }

        public void TDelete(Tutorial item)
        {
            _tutorialDal.Delete(item);
        }

        public Tutorial TGetId(int id)
        {
            return _tutorialDal.GetId(id);
        }

        public List<Tutorial> TGetList()
        {
            return _tutorialDal.GetList();
        }

        public void TInsert(Tutorial item)
        {
            _tutorialDal.Insert(item);
        }

        public void TUpdate(Tutorial item)
        {
            _tutorialDal.Update(item);
        }
    }
}
