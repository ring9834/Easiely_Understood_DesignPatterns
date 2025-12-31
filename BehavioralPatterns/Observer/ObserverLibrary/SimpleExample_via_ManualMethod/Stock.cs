using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverLibrary.SimpleExample_via_ManualMethod
{
    // 2. THE SUBJECT (The Observable)
    // This class keeps track of all observers and notifies them of changes.
    public abstract class Stock
    {
        private readonly List<IInvestor> _investors = new List<IInvestor>();
        public string Symbol { get; }
        private double _price;

        protected Stock(string symbol, double price)
        {
            Symbol = symbol;
            _price = price;
        }

        public void Attach(IInvestor investor) => _investors.Add(investor);
        public void Detach(IInvestor investor) => _investors.Remove(investor);

        public double Price
        {
            get => _price;
            set
            {
                if (_price != value)
                {
                    _price = value;
                    Notify(); // Automatically notify when price changes
                }
            }
        }

        private void Notify()
        {
            foreach (var investor in _investors)
            {
                investor.Update(Symbol, _price);
            }
        }
    }
}
