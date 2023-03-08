using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static cv5.Vehicle;

namespace cv5
{
    internal class Truck : Vehicle
    {
        protected int CargoMax { get; }
        private int _CargoState;
        protected int CargoState
        {
            get
            {
                return _CargoState;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Amount of cargo can not be negative!\n");

                }
                if (value > CargoState)
                {
                    throw new Exception("You are trying to put too much cargo onto the truck!\n" +
                        "Got: " + value + ", Expected max: " + CargoMax);
                }
                _CargoState = value;
            }
        }
        public Truck(FuelType fueltype, int fuelmax, int cargomax) : base(fueltype, fuelmax)
        {
            CargoMax = cargomax;
        }
        public override string ToString()
        {
            return String.Format(base.ToString() + "Max cargo: {0}\n" +
                "Current cargo: {1}\n", CargoMax, CargoState);
        }

    }
}
