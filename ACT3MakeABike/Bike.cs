using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT3MakeABike
{
    public class Bike
    {
        private int topSpeed;
        private string carType;
        public Bike(int topSpeed, string carType) 
        { 
            this.SetTopSpeed(topSpeed);
            this.SetCarType(carType);
        }
        public int GetTopSpeed()
        {
            return this.topSpeed;
        }
        public string GetCarType()
        {
            return this.carType;
        }
        public void SetTopSpeed(int topSpeed)
        {
            this.topSpeed = topSpeed;
        }
        public void SetCarType(string carType)
        {
            this.carType = carType;
        }
    }
}
