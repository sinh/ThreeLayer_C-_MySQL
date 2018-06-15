using System;

namespace Persistence
{
    public static class ItemStatus{
        public const int NOT_ACTIVE = 0;
        public const int ACTIVE = 1;
    }
    public class Item
    {
        public int? ItemId {set;get;}
        public string ItemName {set;get;}
        public decimal ItemPrice {set;get;}
        public int? Amount {set;get;}
        public int? Status{set;get;}
        public string Description {set;get;}
    }
}
