namespace ACT2CreateThreeObjects
{
    public class Execute
    {
        public Execute() 
        {
            Card leCard = new Card('H','A');
            Flight leFlight = new Flight(new DateTime(1,1,1,1,1,1),new DateTime(2,1,1,1,1,1),"Some Plane");
            Lamp leLamp = new Lamp();
        }
    }
}