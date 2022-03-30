using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_30._03._22.Models
{
    class Vehicle
    {
        private string _brand;
        private string _model;
        private int _tankCapacity;
        private double _engine;
        private int _maxSpeed;

        public string Brand { get { return _brand; } set { _brand = value; } }
        public string Model { get { return _model; } set { _model = value; } }
        public int TankCapacity
        {
            get
            {
                return _tankCapacity;
            }
            set
            {
                if (value > 0)
                {
                    _tankCapacity = value;
                }
            }
        }

        public double Engine
        {
            get
            {
                return _engine;
            }
            set
            {
                if (value > 0)
                {
                    _engine = value;
                }
            }
        }
        public int MaxSpeed
        {
            get
            {
                return _maxSpeed;
            }
            set
            {
                if (value > 0)
                {
                    _maxSpeed = value;
                }
            }
        }

        public Vehicle(string brand, string model, int tankCapacity, double engine, int maxSpeed)
        {
            _brand = brand;
            _model = model;
            _tankCapacity = tankCapacity;
            _engine = engine;
            _maxSpeed = maxSpeed;
        }
    }
}

