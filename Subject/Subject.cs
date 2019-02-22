using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subject
{
    public class Subject
    {
        private List<Observer.Observer> _observers = new List<Observer.Observer>();

        public void Attach(Observer.Observer toAdd)
        {
            _observers.Add(toAdd);
        }
    }
}
