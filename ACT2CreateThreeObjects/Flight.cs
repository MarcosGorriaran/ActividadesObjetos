namespace ACT2CreateThreeObjects
{
    public class Flight
    {
        private DateTime startDate;
        private DateTime endDate;
        private string planeID;

        public Flight(DateTime startDate, DateTime endDate, string planeID)
        {
            this.startDate = startDate;
            this.EndDate = endDate;
            this.PlaneID = planeID;
        }

        public DateTime StartDate
        {
            get
            {
                return this.startDate;
            }
            set
            {
                if (this.startDate.CompareTo(this.EndDate) != 1)
                {
                    throw new Exception();
                }
                this.startDate = value;
            }
        }
        public DateTime EndDate
        {
            get { return this.endDate;}
            set
            {
                if(this.endDate.CompareTo(this.StartDate)!=-1) 
                {
                    throw new Exception();
                }
                this.endDate = value;
            }
        }
        public string PlaneID
        {
            get { return this.planeID; }
            set
            {
                this.planeID = value;
            }
        }
    }
}
