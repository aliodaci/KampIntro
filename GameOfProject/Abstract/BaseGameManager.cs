using GameOfProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfProject.Abstract
{
    public class BaseGameManager : IGameService
    {
        public void Add(Game entity)
        {
            Console.WriteLine("{0} eklendi.",entity.Name);
        }

        public void Delete(Game entity)
        {
            Console.WriteLine("{0} silindi.",entity.Name);
        }

        public void Update(Game entity)
        {
            Console.WriteLine("{0} güncellendi.",entity.Name);
        }
    }
}
