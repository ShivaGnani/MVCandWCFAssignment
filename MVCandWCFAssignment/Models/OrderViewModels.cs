using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MVCandWCFAssignment.Models
{
    public class OrderViewModels
    {
        public List<Category> Categories { get; set; }
        [DisplayName("Select Category")]
        public string Category { get; set; }

        public string CustomerID { get; set; }
        public int EmployeeID { get; set; }
        public int ProductID { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
    }


    
}