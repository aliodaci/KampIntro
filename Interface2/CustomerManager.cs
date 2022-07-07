using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface2
{
    class CustomerManager
    {
        public void Add(ICustomerDal customerDal) { customerDal.Add(); }
    }
}
