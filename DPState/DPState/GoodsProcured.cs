using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPState
{
    class GoodsProcured : IState
    {
        Delivery _dv;
      
        public GoodsProcured(Delivery dv)
        {
            _dv = dv;
        }
        public void Closed()
        {
            Console.WriteLine("we cant work becouse warehouse is closed");
        }

        public void DeliverGoods()
        {
            Console.WriteLine("Goods are sent to deliver");
            _dv.SetState(_dv.sentToDeliver);
        }

        public void OpenWarehouse()
        {
            Console.WriteLine("We are entering to warehouse");
        }

        public void ProcureGoods()
        {
            Work();
        }
        public void Work()
        {
            if (_dv.Order > 0)
            {
                Console.WriteLine("We are starting");
                _dv.SetState(_dv.goodsProcured);
            }
            else
            {
                Console.WriteLine("We havent anything to do");
                _dv.SetState(_dv.warehouseClosed);
                
            }
        }
    }
}
