using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPState
{
    class Deliver : IState
    {
        Delivery _dv;
        public Deliver(Delivery dv)
        {
            _dv = dv;
        }
        public void Closed()
        {
            Console.WriteLine("we cant deliver becouse warehouse is closed");
        }

        public void DeliverGoods()
        {
            Console.WriteLine("Good luck");
            _dv.SetState(_dv.warehouseClosed);
        }

        public void OpenWarehouse()
        {
            Console.WriteLine("Waiting...");
        }

        public void ProcureGoods()
        {
            Console.WriteLine("Goods are delivering");
        }
    }
}
