using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_30._03._22.Models
{
    class Car : Vehicle
    {
        public double km;
        public double liter;
        private double _consumption;
        public double Consumption
        {
            get
            {
                return _consumption;
            }
            set
            {
                if (value > 0)
                {
                    _consumption = value;
                }
            }
        }
        public Car(double consumption)
        {
            _consumption = consumption;
        }

        public double Drive(double consumption, double liter, double km)
        {
            
            return km;
        }
        public double Drive()
        {

        }
    }
}
