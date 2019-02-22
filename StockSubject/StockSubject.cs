using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StockSubject
{
    public class StockSubject
    {
        private List<IStockObserver.IStockObserver> _observers = new List<IStockObserver.IStockObserver>(); 

        public void Attach()
        {

        }

        public void Detach()
        {

        }
        public void Notify()
        {

        }
    }
}
