using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv5
{
    internal class Vehicle
    {
        private Radio Radio = new Radio();
        protected int FuelTankMax { get; set; }
        protected FuelType FuelTankType { get; set; }
        protected int FuelTankState { get; set; } = 0;
        //protected int PassengersMax { get; set; }
        //protected int PassengersState { get; set; }
        //public int CargoMax;
        //public int CargoState;
        public enum FuelType
        {
            Gasoline,
            Diesel
        }
        protected Vehicle(FuelType fueltype, int fuelmax)
        {
            FuelTankType = fueltype;
            FuelTankMax = fuelmax;
        }

        public void FillTank(int volume, FuelType fuel)
        {
            if (fuel != FuelTankType) {
                throw new Exception("You are trying to fill the tank with wrong fuel!\n" +
                    "Got: "+ fuel +", Expected: " + FuelTankType);
                
            }
            if (volume < 0)
            {
                throw new Exception("Volume can not be negative!\n");

            }
            if (volume + FuelTankState > FuelTankMax)
            {
                throw new Exception("You are trying to fill the tank with too much fuel!\n" +
                    "Got: " + volume+FuelTankState + ", Expected max: " + FuelTankMax);
            }
            FuelTankState =+ volume;
        }
        public void RadioSavePreset(int number, double frequency) {
        Radio.SavePreset(number, frequency);
        }
        public void RadioLoadPreset(int number)
        {
            Radio.LoadPreset(number);
        }
        public void RadioTurn (bool toggle)
        {
            Radio.isOn = toggle;
        }

        public override string ToString()
        {
            return String.Format("Fuel tank type: {0}\n" +
                "Fuel tank max: {1}\n" +
                "Fuel tank state: {2}\n" +
                "Radio on: {3}\n"+
                "Radio frequency: {4}\n", FuelTankType, FuelTankMax, FuelTankState, Radio.isOn, Radio.tunedFrequncy);
        }


    }

}
