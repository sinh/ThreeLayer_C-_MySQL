using System;
using System.Collections.Generic;

namespace Persistence
{
    public static class OrderStatus
    {
        public const int CREATE_NEW_ORDER = 1;
    }
    public class Order
    {
        public int OrderId { set; get; }
        public DateTime OrderDate { set; get; }
        public Customer OrderCustomer { set; get; }
        public List<Item> ItemsList { set; get; }

        public Item this[int index]
        {
            get
            {
                if (ItemsList == null || ItemsList.Count == 0 || index < 0 || ItemsList.Count < index) return null;
                return ItemsList[index];
            }
            set
            {
                if (ItemsList == null) ItemsList = new List<Item>();
                ItemsList.Add(value);
            }
        }

        public Order()
        {
            ItemsList = new List<Item>();
        }
    }
}
