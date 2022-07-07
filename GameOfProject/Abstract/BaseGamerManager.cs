using GameOfProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfProject.Abstract
{
    public abstract class BaseGamerManager : IGamerService
    {
        public virtual void Add(Gamer entity)
        {
            Console.WriteLine("{0},{1} üye kaydedildi.",entity.FirstName," ",entity.LastName);
        }

        public void Delete(Gamer entity)
        {
            Console.WriteLine("{0},{1} adlı kullanıcı silindi.",entity.FirstName," ",entity.LastName);
        }

        public void Update(Gamer entity)
        {
            Console.WriteLine("{0},{1}",entity.FirstName," ",entity.LastName);
        }
    }
}
