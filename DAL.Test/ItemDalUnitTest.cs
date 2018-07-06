using System;
using Xunit;
using MySql.Data.MySqlClient;
using DAL;
using Persistence;

namespace DAL.Test
{
    public class ItemDalUnitTest
    {
        private ItemsDAL itemDal = new ItemsDAL();
        
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        public void GetByCustomerIdTest(int id)
        {
            Item result = itemDal.GetItemById(id);
            Assert.NotNull(result);
        }
    }
}