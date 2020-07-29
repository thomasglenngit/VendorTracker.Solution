using System.Collections.Generic;

namespace VendorTracker.Models
{
    public class Order
    {
        public string Bread { get; set; }
        public string Pastry { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Date { get; set; }

        // public string Date { get; set; }
        public int Id { get; }
        private static List<Order> _instances = new List<Order> { };

        public Order(string bread, string pastry, string title, string description, string date)
        {
            Bread = bread;
            Pastry = pastry;
            Title = title;
            Description = description;
            Date = Date;
            _instances.Add(this);
            Id = _instances.Count;
        }

        // public void AddItems(int numberOfItems)
        // {
        //     Quantity += numberOfItems;
        // }

        // public void CalculateOrder()
        // {
        //     foreach (Order order in _instances)
        //     {
        //         TotalPrice = Price * Quantity;
        //     }

        // }

        public static List<Order> GetAll()
        {
            return _instances;
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

        public static Order Find(int searchId)
        {
            return _instances[searchId - 1];
        }
    }
}