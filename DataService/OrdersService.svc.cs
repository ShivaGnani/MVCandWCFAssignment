using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DataModels;

namespace DataService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "OrdersService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select OrdersService.svc or OrdersService.svc.cs at the Solution Explorer and start debugging.
    public class OrdersService : IOrdersService
    {
        public void GetCategories()
        {
            NORTHWINDEntities db = new NORTHWINDEntities();
            var categories = new getCategories_Result();
            categories = db.getCategories();

        }
    }
}
