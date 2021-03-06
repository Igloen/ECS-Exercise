﻿namespace ECS.Legacy
{
    public class ECSSys
    {
        private int _threshold;
        private readonly ITempSensor _tempSensor; //Afhængigheder. 
        private readonly IHeater _heater;

        public ECSSys(int thr, ITempSensor tempSensor, IHeater heater) // Constructor injection. 
        {
            SetThreshold(thr);
            _tempSensor = tempSensor;
            _heater = heater;
        }

        public void Regulate()
        {
            var t = _tempSensor.GetTemp();
            if (t < _threshold)
                _heater.TurnOn();
            else
                _heater.TurnOff();

        }

        public void SetThreshold(int thr)
        {
            _threshold = thr;
        }

        public int GetThreshold()
        {
            return _threshold;
        }

        public int GetCurTemp()
        {
            return _tempSensor.GetTemp();
        }

        public bool RunSelfTest()
        {
            return _tempSensor.RunSelfTest() && _heater.RunSelfTest();
        }
    }
}
