using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bolnica.Model;

namespace Bolnica.Repository
{
    public interface GenericRepository<T> where T: class
    {
        List<T> GetAll();
        T GetOne();
        T Save(T newObj);
        T Delete(T obj);
        // bool DeleteByIndex(int index);
        T Update(T obj);
    }
}
