using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DataService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IOrdersService" in both code and config file together.
    [ServiceContract]
    public interface IOrdersService
    {
        [OperationContract]
        void GetCategories();
    }
}
