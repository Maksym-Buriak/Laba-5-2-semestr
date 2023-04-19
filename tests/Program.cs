//using System;

//namespace Завдання_1
//{
//    interface IVehicle
//    {
//        void Speed(int speed);
//        bool AreDoorsOpen();
//        int GetNumberOfWheels();
//    }

//    abstract class Transport : IVehicle
//    {
//        protected int speed;
//        protected int numberOfWheels;
//        protected bool doorsOpen;

//        public void Speed(int speed)
//        {
//            this.speed = speed;
//        }

//        public bool AreDoorsOpen()
//        {
//            return doorsOpen;
//        }

//        public int GetNumberOfWheels()
//        {
//            return numberOfWheels;
//        }

//        public abstract void OpenDoors();
//        public abstract void CloseDoors();
//    }


//    class Motorcycle : Transport
//    {
//        public Motorcycle()
//        {
//            numberOfWheels = 2;
//        }

//        public override void OpenDoors()
//        {
//            throw new NotSupportedException();
//        }

//        public override void CloseDoors()
//        {
//            throw new NotSupportedException();
//        }
//    }

//    class Bicycle : Motorcycle
//    {
//        public Bicycle()
//        {
//            numberOfWheels = 2;
//        }
//    }

//    class Motorbike : Motorcycle
//    {
//        public Motorbike()
//        {
//            numberOfWheels = 2;
//        }
//    }

//    class Car : Transport
//    {
        
//        public Car()
//        {
//            numberOfWheels = 4;
            
//        }

//        public override void OpenDoors()
//        {
//            doorsOpen = true;
//        }

//        public override void CloseDoors()
//        {
//            doorsOpen = false;
//        }
//    }

//    class Train : Transport
//    {
//        public Train()
//        {
//            numberOfWheels = 12;
//        }

//        public override void OpenDoors()
//        {
//            doorsOpen = true;
//        }

//        public override void CloseDoors()
//        {
//            doorsOpen = false;
//        }
//    }

//    class Two_wheeled_ransport : Motorcycle
//    {
//        public Two_wheeled_ransport()
//        {
//            numberOfWheels = 2;
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            IVehicle[] vehicles = new IVehicle[]
//            {
//                new Motorcycle(),
//                new Bicycle(),
//                new Motorbike(),
//                new Car(),
//                new Train(),
//                new Two_wheeled_ransport()

//            };

//            bool conti = true;
//            do
//            {
//                Console.WriteLine("Виберіть транспортний засіб:");
//                Console.WriteLine("1 - мотоцикл");
//                Console.WriteLine("2 - велосипед");
//                Console.WriteLine("3 - мопед");
//                Console.WriteLine("4 - автомобіль");
//                Console.WriteLine("5 - потяг");
//                Console.WriteLine("6 - двоколісний транспортний засіб");

//                int a = int.Parse(Console.ReadLine());

//                if (a == 1) //мотоцикл
//                {
//                    Console.WriteLine("Задайте швидкість транспортного засобу: ");
//                    int motorcycleSpeed = int.Parse(Console.ReadLine());

//                    IVehicle motorcycle = vehicles[0];
//                    motorcycle.Speed(motorcycleSpeed);

//                    Console.WriteLine("\nМотоциклу задана швидкість " + motorcycleSpeed + " км/год.");

//                    Console.WriteLine("\nВизначити, чи відкриті двері у транспортному засобі?");
//                    Console.WriteLine("1 - так");
//                    Console.WriteLine("2 - ні");

//                    int ch = int.Parse(Console.ReadLine());
//                    if (ch == 1)
//                    {
//                        if (motorcycle.AreDoorsOpen() == false)
//                        {
//                            Console.WriteLine("У мотоцикла немає дверей");
//                        }
//                    }
//                    else if (ch == 2)
//                    {
//                        conti = true;
//                    }
//                    else
//                    {
//                        Console.WriteLine("Виберіть дію 1 або 2");
//                        conti = true;
//                    }

//                    Console.WriteLine("\nВизначити кількість коліс у транспортному засобі?");
//                    Console.WriteLine("1 - так");
//                    Console.WriteLine("2 - ні");
                    
//                    int ch2 = int.Parse(Console.ReadLine());
//                    if (ch2 == 1)
//                    {
//                        Console.WriteLine($"Мотоцикл має {motorcycle.GetNumberOfWheels()} колеса");
//                    }
//                    else if (ch2 == 2)
//                    {
//                        conti = true;
//                    }
//                    else
//                    {
//                        Console.WriteLine("Виберіть дію 1 або 2");
//                        conti = true;
//                    }
//                }
//                else if (a == 2) //велосипед
//                {
//                    Console.WriteLine("Задайте швидкість транспортного засобу: ");
//                    int bicycleSpeed = int.Parse(Console.ReadLine());

//                    IVehicle bicycle = vehicles[1];
//                    bicycle.Speed(bicycleSpeed);

//                    Console.WriteLine("\nВелосипеду задана швидкість " + bicycleSpeed + " км/год.");

//                    Console.WriteLine("Визначити, чи відкриті двері у транспортному засобі?");
//                    Console.WriteLine("1 - так");
//                    Console.WriteLine("2 - ні");

//                    int ch = int.Parse(Console.ReadLine());
//                    if (ch == 1)
//                    {
//                        if (bicycle.AreDoorsOpen() == false)
//                        {
//                            Console.WriteLine("У велосипеда немає дверей");
//                        }
//                    }
//                    else if (ch == 2)
//                    {
//                        conti = true;
//                    }
//                    else
//                    {
//                        Console.WriteLine("Виберіть дію 1 або 2");
//                        conti = true;
//                    }

//                    Console.WriteLine("Визначити кількість коліс у транспортному засобі?");
//                    Console.WriteLine("1 - так");
//                    Console.WriteLine("2 - ні");

//                    int ch2 = int.Parse(Console.ReadLine());
//                    if (ch2 == 1)
//                    {
//                        Console.WriteLine($"Велосипед має {bicycle.GetNumberOfWheels()} колеса");
//                    }
//                    else if (ch2 == 2)
//                    {
//                        conti = true;
//                    }
//                    else
//                    {
//                        Console.WriteLine("Виберіть дію 1 або 2");
//                        conti = true;
//                    }
//                }
//                else if (a == 3) //мопед
//                {
//                    Console.WriteLine("Задайте швидкість транспортного засобу: ");
//                    int motorbikeSpeed = int.Parse(Console.ReadLine());

//                    IVehicle motorbike = vehicles[2];
//                    motorbike.Speed(motorbikeSpeed);

//                    Console.WriteLine("\nМопеду задана швидкість " + motorbikeSpeed + " км/год.");

//                    Console.WriteLine("\nВизначити, чи відкриті двері у транспортному засобі?");
//                    Console.WriteLine("1 - так");
//                    Console.WriteLine("2 - ні");

//                    int ch = int.Parse(Console.ReadLine());
//                    if (ch == 1)
//                    {
//                        if (motorbike.AreDoorsOpen() == false)
//                        {
//                            Console.WriteLine("У мопеда немає дверей");
//                        }
//                    }
//                    else if (ch == 2)
//                    {
//                        conti = true;
//                    }
//                    else
//                    {
//                        Console.WriteLine("Виберіть дію 1 або 2");
//                        conti = true;
//                    }

//                    Console.WriteLine("\nВизначити кількість коліс у транспортному засобі?");
//                    Console.WriteLine("1 - так");
//                    Console.WriteLine("2 - ні");

//                    int ch2 = int.Parse(Console.ReadLine());
//                    if (ch2 == 1)
//                    {
//                        Console.WriteLine($"Мопед має {motorbike.GetNumberOfWheels()} колеса");
//                    }
//                    else if (ch2 == 2)
//                    {
//                        conti = true;
//                    }
//                    else
//                    {
//                        Console.WriteLine("Виберіть дію 1 або 2");
//                        conti = true;
//                    }
//                }
//                else if (a == 4) //автомобіль
//                {
//                    Console.WriteLine("Задайте швидкість транспортного засобу: ");
//                    int carSpeed = int.Parse(Console.ReadLine());

//                    IVehicle car = vehicles[3];
//                    car.Speed(carSpeed);

//                    Console.WriteLine("\nАвтомобілю задана швидкість " + carSpeed + " км/год.");

//                    Console.WriteLine("\nБажаєте перевірити, чи відкриті двері у транспортному засобі?");
//                    Console.WriteLine("1 - так");
//                    Console.WriteLine("2 - ні");

//                    Console.WriteLine("Двері автомобіля зараз " + (car.AreDoorsOpen() ? "відкриті" : "закриті"));

                    //Console.WriteLine("Відкрити двері автомобіля? (y/n)");
                    //if (Console.ReadLine() == "y")
                    //{
                    //    car.AreDoorsOpen();
                    //}
                    //else
                    //{
                        
                    //}
                    //Console.WriteLine("Двері автомобіля зараз " + (car.AreDoorsOpen() ? "відкриті" : "закриті"));

                    //int ch = int.Parse(Console.ReadLine());
                    //if (ch == 1)
                    //{

                    //}
                    //else if (ch == 2)
                    //{
                    //    conti = true;

                    //}
                    //else
                    //{
                    //    Console.WriteLine("Виберіть дію 1 або 2");
                    //    conti = true;
                    //}

//                    Console.WriteLine("\nВизначити кількість коліс у транспортному засобі?");
//                    Console.WriteLine("1 - так");
//                    Console.WriteLine("2 - ні");

//                    int ch2 = int.Parse(Console.ReadLine());
//                    if (ch2 == 1)
//                    {
//                        Console.WriteLine($"Автомобіль має {car.GetNumberOfWheels()} колеса");
//                    }
//                    else if (ch2 == 2)
//                    {
//                        conti = true;
//                    }
//                    else
//                    {
//                        Console.WriteLine("Виберіть дію 1 або 2");
//                        conti = true;
//                    }
//                }
//                else if (a == 5)
//                {
//                    Console.WriteLine("Задайте швидкість транспортного засобу: ");
//                    int trainSpeed = int.Parse(Console.ReadLine());

//                    IVehicle train = vehicles[4];
//                    train.Speed(trainSpeed);

//                    Console.WriteLine("\nПотягу задана швидкість " + trainSpeed + " км/год.");

//                    Console.WriteLine("\nБажаєте перевірити, чи відкриті двері у транспортному засобі?");
//                    Console.WriteLine("1 - так");
//                    Console.WriteLine("2 - ні");

//                    int ch = int.Parse(Console.ReadLine());
//                    if (ch == 1)
//                    {
//                        if (train.AreDoorsOpen() == false)
//                        {
//                            Console.WriteLine("\nДвері зачинені");
//                        }
//                        if (train.AreDoorsOpen() == true)
//                        {
//                            Console.WriteLine("\nВідчинено одну з дверей");
//                        }
//                    }
//                    else if (ch == 2)
//                    {
//                        conti = true;

//                    }
//                    else
//                    {
//                        Console.WriteLine("Виберіть дію 1 або 2");
//                        conti = true;
//                    }

//                    Console.WriteLine("\nВизначити кількість коліс у транспортному засобі?");
//                    Console.WriteLine("1 - так");
//                    Console.WriteLine("2 - ні");

//                    int ch2 = int.Parse(Console.ReadLine());
//                    if (ch2 == 1)
//                    {
//                        Console.WriteLine($"Потяг має {train.GetNumberOfWheels()} колеса");
//                    }
//                    else if (ch2 == 2)
//                    {
//                        conti = true;
//                    }
//                    else
//                    {
//                        Console.WriteLine("Виберіть дію 1 або 2");
//                        conti = true;
//                    }
//                }
//            }
//            while (conti);



//            Console.ReadKey();
//        }
//    }
//}