using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DataModels;
using Newtonsoft.Json;

namespace DataServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ProductsService" in both code and config file together.
    public class ProductsService : IProductsService
    {
        public string GetCategories()
        {
            NORTHWINDEntities db = new NORTHWINDEntities();
            var categories = db.GetAllCategories();
            string str = JsonConvert.SerializeObject(categories);
            return str;
        }

        public string GetProductsByID(int categoryID)
        {
            string str;
            using (var db = new NORTHWINDEntities())
            {
                var products = db.Products.Where(s => s.CategoryID == categoryID).Select(x => new { x.ProductID, x.ProductName, x.UnitPrice }).ToList();
                str = JsonConvert.SerializeObject(products);
            }
            return str;
        }

        public string SaveOrder(Order order)
        {
            try
            {
                using (var db = new NORTHWINDEntities())
                {
                    var newOrder = new DataModels.Order() { OrderDate = DateTime.Now, EmployeeID = 3, CustomerID = "GREAL" };
                    db.Orders.Add(newOrder);
                    db.SaveChanges();
                    var newOrderDetail = new Order_Detail() { OrderID = newOrder.OrderID, ProductID = order.ProductID, UnitPrice = order.UnitPrice, Quantity = order.Quantity, Discount = 0 };
                    db.Order_Details.Add(newOrderDetail);
                    db.SaveChanges();
                    return "Inserted successfully";
                }
            }
            catch(Exception e)
            {
                throw new FaultException<ServiceExecptions>(new ServiceExecptions() { Reason = e.Message });
            }

            
        }
    }
}
