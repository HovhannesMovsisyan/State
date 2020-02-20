using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPState
{
    class Program
    {
        static void Main(string[] args)
        {
            Delivery d = new Delivery();
            d.OpenWarehouse();
            d.ProcureGoods();
            d.DeliverGoods();
            d.Closed();
            
           
        }
    }
}
