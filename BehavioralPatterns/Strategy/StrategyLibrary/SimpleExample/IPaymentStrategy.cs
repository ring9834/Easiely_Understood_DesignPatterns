using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyLibrary.SimpleExample
{
    // 1. STRATEGY INTERFACE
    // This interface defines the contract for all concrete strategies (algorithms).
    public interface IPaymentStrategy
    {
        void Pay(decimal amount);
    }
}
