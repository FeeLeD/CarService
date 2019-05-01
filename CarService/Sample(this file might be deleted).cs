using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CarService
{
    class Program
    {
        /// <summary>
        /// Пример реализации 
        /// </summary>
        public static void Main()
        {
            var clientBase = new ClientBase();

            var truck1 = new Trucks()
            {
                Name = TruckNames.IVECO,
                VIN = "VASD2932",
                Model = "EuroStar",
                EngineVolume = 1.5,
                ManufactureYear = DateTime.Now
            };

            //var truck1 = new Trucks(TruckNames.IVECO, "VASD2932", "EuroStar", 10, DateTime.Now);
            //var car2 = new Cars(CarNames.BMW, "GD32932", "X5", 3, DateTime.Now);
            //var truck3 = new Trucks(TruckNames.MAN, "UIZF932", "TGX", 10.5, DateTime.Now);

            var client1 = new Clients()
            {
                Name = "Роман Иванов",
                Number = new PhoneNumber()
                {
                    Number = "88005553535"
                },
                OrderDate = DateTime.Now,
                Trucks = new List<Trucks> { truck1 }
            };

            //var client1 = new Clients("Роман Иванов", new PhoneNumber("8888"), DateTime.Now, null, new List<Trucks> { truck1 });
            //var client2 = new Clients("Дмитрий Полоз", new PhoneNumber("8778"), DateTime.Now, new List<Cars> { car2 });
            //var client3 = new Clients("Никита Шубин", new PhoneNumber("8123"), DateTime.Now, null, new List<Trucks> { truck3 });

            clientBase.List.Add(client1);
            //clientBase.Base.Add(client2);
            //clientBase.Base.Add(client3);

            Console.WriteLine("Клиентская база: ");
            foreach (var client in clientBase.List)
                Console.WriteLine(client.Name);

            Console.WriteLine();

            client1.Trucks.Last().DefectsDescription.Add("Посторонний шум из под капота");
            client1.Trucks.Last().DefectsDescription.Add("Заменить масло");

            //client2.Cars.Last().DefectsDescription.Add("Шум слева при торможении");
            //client2.Cars.Last().DefectsDescription.Add("Пинается коробка");

            //client3.Trucks.Last().DefectsDescription.Add("Не держит холостые обороты");
            //client3.Trucks.Last().DefectsDescription.Add("Заменить тормозную жидкость, антифриз");

            Console.WriteLine(client1.Name + "," + client1.Trucks.Last().Name + ":");
            foreach (var e in client1.Trucks.Last().DefectsDescription)
                Console.WriteLine(e);

            //Console.WriteLine();

            //Console.WriteLine(client2.Name + "," + client2.Cars.Last().Name + ":");
            //foreach (var e in client2.Cars.Last().DefectsDescription)
            //    Console.WriteLine(e);

            //Console.WriteLine();

            //Console.WriteLine(client3.Name + "," + client3.Trucks.Last().Name + ":");
            //foreach (var e in client3.Trucks.Last().DefectsDescription)
            //    Console.WriteLine(e);

            //Console.WriteLine();

            //client2.OrderDone = true;

            Console.WriteLine("Клиентская база: ");
            foreach (var client in clientBase.List)
                Console.WriteLine(client);

            Console.WriteLine(client1.Trucks.Last().EngineVolume);

        }
    }
}
