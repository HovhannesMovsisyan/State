using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DPState.Delivery;

namespace DPState
{
    class WarehouseClosed : IState
    {
        Delivery _dv;
       
        public WarehouseClosed(Delivery dv)
        {
            _dv = dv;
        }
        public void Closed()
        {
            Console.WriteLine("Warehouse is closed");
        }

        public void DeliverGoods()
        {
            Console.WriteLine("We need some goods to deliver");
        }

        public void OpenWarehouse()
        {
            Console.WriteLine("Warehouse is opened");
            _dv.SetState(_dv.warehouseOpened);
        }

        public void ProcureGoods()
        {
            Console.WriteLine("We cant do this while warehouse is closed");
        }
    }
}
