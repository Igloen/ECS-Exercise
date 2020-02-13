using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Legacy
{
    public class FakeTempSensor : ITempSensor
    {
        public int temp = 28;
        public int GetTemp()
        {
            return temp;
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}
