using GameOfProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfProject.Abstract
{
    public class BaseCampaignManager : ICampaignService
    {
        public void Add(Campaign entity)
        {
            Console.WriteLine("{0} kampanya eklendi.",entity.Name);
        }

        public void Delete(Campaign entity)
        {
            Console.WriteLine("{0} kampanya silindi.",entity.Name);
        }

        public void Update(Campaign entity)
        {
            Console.WriteLine("{0} kampanya güncellendi.",entity.Name);
        }
    }
}
