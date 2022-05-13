namespace Library
{
    public class Driver : Person
    {
       
        string car;
        public Driver (string name, string lastName, int id, int rating, string modelCar) : base(name, lastName, id, rating)
        {
            
            this.car = modelCar;
        }
    }
}