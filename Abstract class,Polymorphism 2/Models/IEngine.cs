using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class_Polymorphism_2.Models
{
    internal interface IEngine
    {
        void RemainOilAmount(double oilcapacity,double currentoil,string fueltype);
    }
}
