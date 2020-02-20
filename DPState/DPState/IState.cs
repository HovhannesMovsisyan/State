using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPState
{
    interface IState
    {
        void OpenWarehouse();
        void ProcureGoods();
        void DeliverGoods();
        void Closed();
    }
}
