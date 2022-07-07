using GameOfProject.Abstract;
using GameOfProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfProject.Concrete
{
    public class GamerManager:BaseGamerManager
    {
        private IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public override void Add(Gamer entity)
        {
            if (_gamerCheckService.CheckIfRealPerson(entity))
            {
                 base.Add(entity);
            }
            else
            {
                throw new Exception("hatalı işlem");
            }
            
        }
    }
}
