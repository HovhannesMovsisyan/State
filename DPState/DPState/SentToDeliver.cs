using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPState
{
    class SentToDeliver : IState
    {
        Delivery _dv;
       
        public SentToDeliver(Delivery dv)
        {
            _dv = dv;
        }
        public void Closed()
        {
            Console.WriteLine("we cant sent goods to deliver becouse warehouse is closed");
        }

        public void DeliverGoods()
        {
            Console.WriteLine("Finely.. Lets start");
            _dv.SetState(_dv.warehouseOpened);
        }

        public void OpenWarehouse()
        {
            Console.WriteLine("There are no goods to sent for deliver yet");
        }

        public void ProcureGoods()
        {
            Console.WriteLine("Goods are sent to deliver");
           
        }
    }
}
