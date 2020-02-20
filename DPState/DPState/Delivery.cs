using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPState
{
    class Delivery
    {
        
        public int Order { get; private set; }
        public WarehouseClosed warehouseClosed { get; private set; }
        public WarehouseOpened warehouseOpened { get; private set; }
        public GoodsProcured goodsProcured { get; private set; }
        public SentToDeliver sentToDeliver { get; private set; }
        public Deliver deliver { get; private set; }
        private IState _state;
        

        public Delivery()
        {
            warehouseClosed = new WarehouseClosed(this);
            warehouseOpened = new WarehouseOpened(this);
            goodsProcured = new GoodsProcured(this);
            sentToDeliver = new SentToDeliver(this);
            deliver = new Deliver(this);
            _state = warehouseClosed;
            Order = 0;
        }
        public void OpenWarehouse()
        {
            Order = 100;
            _state.OpenWarehouse();
        }
        public void ProcureGoods()
        {
            _state.ProcureGoods();
            Order--;
        }
        public void DeliverGoods()
        {
            _state.DeliverGoods();
        }
        public void Closed()
        {
            _state.Closed();
        }
        public void SetState(IState state)
        {
            _state = state;
        }
       
    }
}
