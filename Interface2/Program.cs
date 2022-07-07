using System;

namespace Interface2
{
    class Program
    {
        static void Main(string[] args)
        {
            ICustomerDal[] customerDals = { new SqlServerCustomerDal(), new OracleCustomerDal(), new MysqlCustomerDal() };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
        }
    }
}
