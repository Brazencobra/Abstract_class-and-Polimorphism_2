using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class_Polymorphism_2.Models
{
    internal class Plane : Vehicle , IEngine
    {
        double _wingLength;

        public double WingLength 
        {
            get => _wingLength;
            set
            {
                if (value >= 3)
                {
                    _wingLength = value;
                }
            }
        }

        public Plane(double winglength,double drivetime,double drivepath) : base(drivetime,drivepath)
        {
            WingLength = winglength;
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

        public override double AvarageSpeed()
        {
            return DrivePath / DriveTime;
        }
    }
}
