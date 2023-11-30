using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class_Polymorphism_2.Models
{
    internal abstract class Vehicle
    {
        double _driveTime;
        double _drivePath;

        public double DriveTime 
        {
            get => _driveTime;
            set
            {
                if (value >= 0)
                {
                    _driveTime = value;
                }
            } 
        }
        public double DrivePath 
        {
            get => _drivePath;
            set
            {
                if (value >= 0)
                {
                    _drivePath = value;
                }
            }
        }

        public Vehicle(double drivetime,double drivepath)
        {
            DriveTime = drivetime;
            DrivePath = drivepath;
        }

        public abstract double AvarageSpeed();
 

    }
}
