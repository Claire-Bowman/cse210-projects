using System.Collections.Generic;
using System.Text;

public class Order
    {
        private List<Product> _products;
        private Customer _customer;

        public Order(Customer customer)
        {
            _customer = customer;
            _products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public decimal GetTotalCost()
        {
            decimal total = 0;
            foreach (var product in _products)
            {
                total += product.TotalCost;
            }

            total += _customer.LivesInUSA() ? 5 : 35;
            return total;
        }

        public string GetPackingLabel()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Packing Label:");
            foreach (var product in _products)
            {
                sb.AppendLine($"{product.Name} - ID: {product.ProductId}");
            }
            return sb.ToString();
        }

        public string GetShippingLabel()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Shipping Label:");
            sb.AppendLine(_customer.Name);
            sb.AppendLine(_customer.Address.GetFullAddress());
            return sb.ToString();
        }
    }