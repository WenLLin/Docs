using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace directory
{
    public class Store
    {
        public class StoreContext : DbContext
        {
            public DbSet<Order> order { get; set; }
            public DbSet<OrderDetails> orderDetail { get; set; }
            public DbSet<Customer> customer { get; set; }
            public DbSet<Supplier> supplier { get; set; }
            public DbSet<Product> product { get; set; }
            public DbSet<Category> category { get; set; }


            protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
            {
                optionBuilder.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = onlineStore; Trusted_Connection = True;");
            }
        }

        public class Order
        {
            [Key]
            public int OrderID { get; set; }
            public int custID { get; set; }
            public string orderDate { get; set; }
            public string shipDate { get; set; }
            public string shipName { get; set; }
            public string shipAddress { get; set; }
            public string shipCity { get; set; }
            public string shipRegion { get; set; }
            public int postalCode { get; set; }
            public string shipCountry { get; set; }
        }

        public class Customer
        {
            [Key]
            public int custID { get; set; }
            public string shipName { get; set; }
            public string shipAddress { get; set; }
            public string shipCity { get; set; }
            public string shipRegion { get; set; }
            public int postalCode { get; set; }
            public string shipCountry { get; set; }
            public string phoneNumber { get; set; }
            public string emailAddress { get; set; }

        }

        public class OrderDetails
        {
            [Key]
            public int orderID { get; set; }
            public int productID { get; set; }
            public double unitPrice { get; set; }
            public int quantity { get; set; }
        }
        public class Product
        {
            [Key]
            public int productID { get; set; }
            public int supplierID { get; set; }
            public int categoryID { get; set; }
            public double unitPrice { get; set; }
            public int availability { get; set; }
        }
        public class Category
        {
            [Key]
            public int categoryID { get; set; }
            public string categoryName { get; set; }

        }
        public class Supplier
        {
            [Key]
            public int supplierID { get; set; }
            public string companyName { get; set; }
            public string contactName { get; set; }
            public string address { get; set; }
            public string city { get; set; }
            public string region { get; set; }
            public int postalCode { get; set; }
            public string country { get; set; }
            public string phoneNumber { get; set; }
            public string fax { get; set; }
        }       
    }
}
