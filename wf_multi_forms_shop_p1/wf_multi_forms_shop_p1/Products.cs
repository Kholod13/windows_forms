using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wf_multi_forms_shop_p1
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Country { get; set; }
        public int DiscountPercent { get; set; }
        public Product(string name, decimal price, int quantity, string country, int discount)
        {
            Name = name; Price = price; Quantity = quantity; Country = country; DiscountPercent = discount;
        }
        public Product()
        {
            Name = string.Empty;
            Price = default;
            Quantity = default;
            Country = string.Empty;
            DiscountPercent = default;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price}UAH, Quantity: {Quantity}, Country: {Country}, Discount: {DiscountPercent}";
        }
    }
}
