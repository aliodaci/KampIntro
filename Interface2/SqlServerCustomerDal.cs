using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface2
{
    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("SqlServer Added!");
        }

        public void Delete()
        {
            Console.WriteLine("SqlServer Deleted!");
        }

        public void Update()
        {
            Console.WriteLine("SqlServer Updated!");
        }
    }
}
