using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfProject.Abstract
{
    public interface ICRUDService<T>
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
