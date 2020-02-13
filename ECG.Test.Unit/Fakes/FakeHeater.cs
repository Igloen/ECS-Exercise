using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Legacy
{
    public class FakeHeater : IHeater
    {
        public string status;

        public void TurnOn()
        {
            status = "on";
        }

        public void TurnOff()
        {
            status = "off";
        }

        public bool RunSelfTest()
        {
            throw new NotImplementedException();
        }
    }
}
