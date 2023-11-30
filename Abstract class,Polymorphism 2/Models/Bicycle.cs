using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class_Polymorphism_2.Models
{
    internal class Bicycle : Vehicle , IEngine
    {
        string _pedalKind;

        public string PedalKind 
        {
            get => _pedalKind;
            set
            {
                if (value.Trim().Length >= 3)
                {
                    _pedalKind = value;
                }
            } 
        }

        public Bicycle(string pedalkind,double drivetime,double drivepath) : base(drivetime, drivepath)
        {
            PedalKind = pedalkind;
        }

        public void RemainOilAmount(double oilcapacity, double currentoil, string fueltype)
        {
            Console.WriteLine("Bu neqliyyat vasitesinde yanacaq serfiyyati yoxdur");
        }

        public override double AvarageSpeed()
        {
            return DrivePath / DriveTime;
        }
    }
}
