using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using MVCandWCFAssignment.Models;
using System.ComponentModel.DataAnnotations;

namespace MVCandWCFAssignment.Controllers
{
    public class OrdersController : Controller
    {
        ProductsService.IProductsService svc = new ProductsService.ProductsServiceClient();
        public ActionResult Index()
        { 
            string strCategories = svc.GetCategories();
            OrderViewModels model = new OrderViewModels();
            model.Categories = JsonConvert.DeserializeObject<List<Category>>(strCategories);
            return View(model);
        }
        [HandleError]
        public string GetProductsByID(int categoryID)
        {
            string strProducts = svc.GetProductsByID(categoryID);
            return strProducts;
        }

        [HttpPost]
        public ActionResult Index([Bind(Include = "CustomerID, EmployeeID, ProductID, UnitPice, Quantity ")]OrderViewModels order)
        {
            ProductsService.Order oOrder = new ProductsService.Order() { ProductID = order.ProductID, UnitPrice = order.UnitPrice, Quantity = order.Quantity };
            string response = svc.SaveOrder(oOrder);
            return View();
            
        }
    }
}