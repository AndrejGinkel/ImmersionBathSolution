using System;

namespace ImmersionBath
{
    public class WaterPamp
    {
        public double WaterPampSpeed { get; set; }


        public void ChangeWaterPampSpeed(double WaterPampSpeed )
        {
            if (Asic.ChipTemp >= 80 && TemperatureSensor.TempSensor >=80)
            {
                WaterPampSpeed++;
            }
            else WaterPampSpeed--;
        }
    }


    
}
