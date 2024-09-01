using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCollectionManagement.Repositories
{
    //We give the class condition as T
    public interface IRepository<T> where T : class
    {
        List<T> GetAll();
        //Return T
        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(int id);    

    }
}
