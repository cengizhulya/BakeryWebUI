using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    //Concrete tarafinda yapacagim business metotlarinin imzalarini tanimlayacagiz
    //Businessa gelmeden once business tarafinda tanimlayacagim butun metotlar burdan gecip business concrete'e gelecek
    public interface IGenericService<T>
    {
        void TAdd(T entity);
        void TDelete(int id);
        void TUpdate(T entity);
        List<T> TGetAll();
        T TGetById(int id);
    }
}
