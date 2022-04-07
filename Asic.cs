using System;

namespace ImmersionBath
{
    public class Asic
    {
        
        public double ChipTemp { get; set; }

        public double FanSpeed { get; set; }

        
        public void ChangeFanSpeed(double asicChipTemp)
        {
            if (asicChipTemp > ChipTemp)
            {
                do
                {
                    FanSpeed += 100;
                    Console.WriteLine("Остужаюсь");
                } while (ChipTemp>80);
                
            }
        }

        public void SetAsicMinigPower(double power, double asicChipTemp, double asicFanSpeed)
        {
            do
            {
                power+=10;
                Console.WriteLine("Разгоняюсь");
            } while (asicChipTemp<80 && power < 100);
        }
    }
}
