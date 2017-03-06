using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DataServiceLibrary
{
    [DataContract]
    public class Order
    {

        [DataMember]
        public int ProductID { get; set; }

        [DataMember]
        public decimal UnitPrice { get; set; }

        [DataMember]
        public short Quantity { get; set; }

        [DataMember]
        public float Discount { get; set; }

        [DataMember]
        public string CustomerID { get; set; }

        [DataMember]
        public Nullable<int> EmployeeID { get; set; }

        [DataMember]
        public Nullable<System.DateTime> OrderDate { get; set; }

        [DataMember]
        public Nullable<System.DateTime> RequiredDate { get; set; }
        //public Nullable<System.DateTime> ShippedDate { get; set; }
        //public Nullable<int> ShipVia { get; set; }
        //public Nullable<decimal> Freight { get; set; }
        //public string ShipName { get; set; }
        //public string ShipAddress { get; set; }
        //public string ShipCity { get; set; }
        //public string ShipRegion { get; set; }
        //public string ShipPostalCode { get; set; }
        //public string ShipCountry { get; set; }
    }
}
