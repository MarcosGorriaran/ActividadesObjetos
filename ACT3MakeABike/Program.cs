namespace ACT3MakeABike
{
    public class Execute
    {
        public static void Main()
        {
            Bike[] badCar = { new Bike(50, "NOPE"), new Bike(300,"SPEED") };
            for(int i = 0; i < badCar.Length; i++) 
            {
                Console.Write(badCar[i].GetCarType());
                Console.WriteLine(badCar[i].GetTopSpeed());
            }
        }
    }
}