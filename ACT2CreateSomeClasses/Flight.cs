namespace ACT2CreateSomeClasses
{
    
    public class Flight
    {
        private string startCityCode;
        private string endCityCode;
        private int flightCode;
        private int airplaneCode;

        public Flight(string startCityCode, string endCityCode, int flightCode, int airplaneCode)
        {
            this.StartCityCode = startCityCode;
            this.EndCityCode = endCityCode;
            this.FlightCode = flightCode;
            this.AirplaneCode = airplaneCode;
        }
        public string StartCityCode 
        {
            get => startCityCode;
            set => startCityCode = value;
        }
        public string EndCityCode 
        { 
            get => endCityCode;
            set => endCityCode = value;
        }
        public string FlightCode
        {

        }
    }
}
