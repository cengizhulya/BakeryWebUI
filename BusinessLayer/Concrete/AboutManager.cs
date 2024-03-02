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
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;
        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        //IAboutDal'a yukaridaki gibi ulasmamiz gerekiyor cunku interfaceimde degerler iaboutdalda
        //Yukarida DI kullandık. AMAC gelen entitye ulasmak
        //_aboutDal uzerinden ilgili interfacedeki metotlara erisicez
        //IAboutDal'i cagirinca IGenericDal'daki metotlara ulasicaz
        public void TAdd(About entity)
        {
            _aboutDal.Add(entity);
        }

        public void TDelete(int id)
        {
            _aboutDal.Delete(id);
        }

        public List<About> TGetAll()
        {
           return _aboutDal.GetAll();
        }

        public About TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(About entity)
        {
            _aboutDal.Update(entity);
        }
    }
}
