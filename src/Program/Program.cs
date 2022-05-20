using System;
using System.Collections;
using Library;


namespace PII_Herencia
{
    class Program
    {
        static void Main(string[] args)
        {

            Person pasajero1 = new Passenger("Pepe", "Rodriguez", 34567890, 10);
            Person pasajero2 = new Passenger("Javi", "nasheer", 34422220, 9);

            Person conductor1 = new Driver("Ionas", "Josponis", 52429030, 10, "Volkswagen Gol");
            Person conductorPool1 = new PoolDriver("primo", "del iona", 4566540, 9, "Ford Ranger", 8);
            UcuRideShare rideShare = new UcuRideShare();

            rideShare.AddUser(conductor1);
            //Se publica en Twitter un nuevo conductor!

            rideShare.AddUser(conductorPool1);
            //Se publica en Twitter un nuevo conductor!

            rideShare.AddUser(pasajero1);
            //Se publica en Twitter nuevo registro de pasajero!

            rideShare.AddUser(pasajero2);
            //Se publica en Twitter nuevo registro de pasajero!      



            foreach (var user in rideShare.users)
            {
                Console.WriteLine(user.Name);
            }



            // var twitter = new TwitterImage();
            // Console.WriteLine(twitter.PublishToTwitter("New employer!",@"bill2.jpg"));
            var twitter = new TwitterMessage();
            twitter.SendMessage("Hola!", "1335377487279349760");



        }
    }
}
