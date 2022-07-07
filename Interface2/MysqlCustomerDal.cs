using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface2
{
    class MysqlCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Mysql Added!");
        }

        public void Delete()
        {
            Console.WriteLine("Mysql Delete!");
        }

        public void Update()
        {
            Console.WriteLine("Mysql Update!");
        }
    }
}
