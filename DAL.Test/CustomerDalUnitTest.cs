using System;
using Xunit;
using MySql.Data.MySqlClient;
using DAL;
using Persistence;

namespace DAL.Test
{
    public class CustomerDalUnitTest
    {
        private CustomerDAL customerDal = new CustomerDAL();
        
        [Theory]
        [InlineData("VTCA 1", "Ha Noi")]
        [InlineData("VTCA 2", "HCM")]
        public void AddCustomerTest(string name, string address)
        {
            Customer c = new Customer{CustomerName=name, CustomerAddress=address};
            int? result = customerDal.AddCustomer(c);
            Assert.NotNull(result);
            Assert.True((result??0) > 0);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void GetByCustomerIdTest(int id)
        {
            Customer result = customerDal.GetById(id);
            Assert.NotNull(result);
        }
    }
}