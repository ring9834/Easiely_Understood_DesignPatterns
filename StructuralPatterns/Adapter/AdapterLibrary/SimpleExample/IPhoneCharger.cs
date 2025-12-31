using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterLibrary.SimpleExample
{
    // 1. The "Target" Interface
    // This is what our application expects to use.
    public interface IPhoneCharger
    {
        void ChargeWithLightning();
    }
}
