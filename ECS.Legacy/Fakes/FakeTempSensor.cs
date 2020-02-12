using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Legacy
{
    public class FakeTempSensor : ITempSensor
    {
        public int GetTemp()
        {
            throw new NotImplementedException();
        }

        public bool RunSelfTest()
        {
            throw new NotImplementedException();
        }
    }
}
