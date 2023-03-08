using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv5
{
    internal class Car : Vehicle
    {
        protected int PassengersMax { get; }
        private int _passengersState = 0;
        protected int PassengersState
        {
            get
            {
                return _passengersState;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Number of passengers can not be negative!\n");

                }
                if (value > PassengersMax)
                {
                    throw new Exception("You are trying to put too many passengers into the vehicle!\n" +
                        "Got: " + value + ", Expected max: " + PassengersMax);
                }
                _passengersState = value;
            }
        }
        public Car(FuelType fueltype, int fuelmax, int passengersmax) : base(fueltype, fuelmax)
        {
            PassengersMax = passengersmax;
        }
        public override string ToString()
        {
            return String.Format(base.ToString() +"Max passengers: {0}\n" +
                "Current passengers: {1}\n", PassengersMax, PassengersState);
        }


    }
}

