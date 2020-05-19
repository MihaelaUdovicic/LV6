using System;
using System.Collections.Generic;
using System.Text;

namespace LV6
{
    public class HomeThermostat : WeatherObserver
    {
        bool HeatingIsOn = false;
        bool CoolingIsOn = true;
        const int HeatingThreshold = 15;
        const int CoolingThreshold = 25;
        public void Update(int temperature)
        {
            if (temperature < HeatingThreshold) { StartHeating(); }
            else if (temperature > CoolingThreshold) { StartCooling(); }
            //else {  StopAll(); }   //javlja gresku kod StopAll()
        }
        private void StartHeating()
        {
            Console.WriteLine("Now heating"); HeatingIsOn = true; CoolingIsOn = false;
        }
        private void StartCooling()
        {
            Console.WriteLine("Now cooling.");
        }
    }
}
