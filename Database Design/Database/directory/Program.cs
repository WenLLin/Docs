using System;
using static directory.Store;

namespace directory
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StoreContext())
            {
                var order = context.order;
                var orderDetail = context.orderDetail;
                var customer = context.customer;
                var product = context.product;
                var category = context.category;
                var supplier = context.supplier;

                var count = context.SaveChanges();
                Console.WriteLine("{0} records saved to database", count);

                Console.ReadLine();
            }
        }
    }
}
