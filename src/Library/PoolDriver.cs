namespace Library
{
    public class PoolDriver : Driver
    {
      
        int maxPassengers;

        public PoolDriver(string name, string lastName, int id, int rating, string modelCar, int maxPassengers) : base(name, lastName, id, rating, modelCar)
        {
            this.maxPassengers = maxPassengers;
        }
    }
}