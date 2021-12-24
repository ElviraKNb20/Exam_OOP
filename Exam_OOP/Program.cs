using System;

namespace Exam_OOP
{
    interface IDevice
    {
        string Type();
        string CostDevice { get; }
        string Function();
        string TypeOfPowerSupply();
        string MakerOfDevice();
    }
    interface IoTDevice : IDevice
    {
        string GetTime();
        string ShowTime();
    }
    class KitchenDevice : IDevice
    {
        public string Type()
        {
            return "Тип: мікрохвильова піч";
        }
        private double c { get; set; }
        public KitchenDevice(double c)
        {
            this.c = c;
        }
        public string CostDevice
        {
            get
            {
                return $"Цiна девайсу: {c}";
            }
        } 
        public string Function()
        {
            return "Призначення: Розiгрiвання їжi";
        }
        public string TypeOfPowerSupply()
        {
            return "Тип живлення: розетка";
        }
        public string MakerOfDevice()
        {
            return "Виробник: Samsung";
        }
    }
    class SmartTracker : IoTDevice
    {
        public string Time;

        public string CostDevice => throw new NotImplementedException();

        public SmartTracker(string Time)
        {
            this.SetTime(Time);
        }

        private void SetTime(string time)
        {
            throw new NotImplementedException();
        }

        public string GetTime()
        {
            return $"Час автономностi: 20 год";
        }

        public string ShowTime()
        {
            throw new NotImplementedException();
        }

        public string Type()
        {
            throw new NotImplementedException();
        }

        public string Function()
        {
            throw new NotImplementedException();
        }

        public string TypeOfPowerSupply()
        {
            throw new NotImplementedException();
        }

        public string MakerOfDevice()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            KitchenDevice kd = new KitchenDevice(2500);
            SmartTracker st = new SmartTracker("20 годин");
        }
    }
}
