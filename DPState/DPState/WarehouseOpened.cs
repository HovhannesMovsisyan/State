using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPState
{
    class WarehouseOpened : IState
    {
        Delivery _dv;
       
        public WarehouseOpened(Delivery dv)
        {
            _dv = dv;
        }
        public void Closed()
        {
            Console.WriteLine("It is already closed");
        }

        public void DeliverGoods()
        {
            Console.WriteLine("We are still waiting for goods to deliver");
        }

        public void OpenWarehouse()
        {
            Console.WriteLine("It is already opened");
            
        }

        public void ProcureGoods()
        {
            Console.WriteLine("Lets start working");
            _dv.SetState(_dv.goodsProcured);
        }
    }
}
