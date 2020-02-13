using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECS.Legacy;
using NUnit.Framework;
using ECS = ECS.Legacy.ECSSys;


namespace ECS1.Test.Unit
{
   [TestFixture]
    public class ECS_TEST
    {
        private ECSSys uut_;
        private FakeHeater heater;
        private FakeTempSensor sensor;
        
        [SetUp]
       public void Setup()
       {
           heater = new FakeHeater();
           sensor = new FakeTempSensor();

       }

       [TestCase(27,30)]
       [TestCase(3, 84)]
       [TestCase(20, 21)]
       public void Regulate_TurnOff(int thr,int temp)
       {
           sensor.temp = temp;

           uut_ = new ECSSys(thr, sensor, heater);

            uut_.Regulate();

            Assert.That(heater.status, Is.EqualTo("off"));

        } //Vi tester at den rigtige metode bliver kaldt i heater-klassen


        [TestCase(31, 30)]
       [TestCase(92, 84)]
       [TestCase(25, 21)]
       public void Regulate_TurnOn(int thr, int temp) //Vi tester at den rigtige metode bliver kaldt i heater-klassen
       {
           sensor.temp = temp;

           uut_ = new ECSSys(thr, sensor, heater);

           uut_.Regulate();

           Assert.That(heater.status, Is.EqualTo("on"));

       }




    }
}
