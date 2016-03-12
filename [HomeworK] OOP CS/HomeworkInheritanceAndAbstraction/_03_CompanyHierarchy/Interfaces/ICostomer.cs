using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CompanyHierarchy.Interfaces
{
    public interface ICostomer
    {

       decimal NetPurchaseAmount { get; set; }
       void BueProduct(Sale sale);

    }
}
