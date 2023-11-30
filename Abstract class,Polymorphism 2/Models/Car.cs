using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class_Polymorphism_2.Models
{
    internal class Car : Vehicle , IEngine
    {
        byte _doorcount;
        public byte DoorCount 
        {
            get => _doorcount;
            set
            {
                if (value >= 0)
                {
                    _doorcount = value;
                }
            }
        }

        public Car(byte doorcount,double drivetime,double drivepath):base(drivetime,drivepath)
        {
            DoorCount = doorcount;            
        }

        public override double AvarageSpeed()
        {
            return DrivePath / DriveTime;
        }

        public void RemainOilAmount(double oilcapacity, double currentoil, string fueltype)
        {
            fueltype = fueltype.ToLower().Trim();
            switch (fueltype)
            {
                case "benzin":
                    Console.WriteLine(oilcapacity - currentoil - 5);
                    break;
                case "dizel":
                    Console.WriteLine(oilcapacity - currentoil);
                    break;
            }
        }
    }
}
