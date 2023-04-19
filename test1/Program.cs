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

//            Console.WriteLine("Виберіть транспортний засіб:");
//            Console.WriteLine("1 - мотоцикл");
//            Console.WriteLine("2 - велосипед");
//            Console.WriteLine("3 - мопед");
//            Console.WriteLine("4 - автомобіль");
//            Console.WriteLine("5 - потяг");
//            Console.WriteLine("6 - двоколісний транспортний засіб");

//            char a = char.Parse(Console.ReadLine());

//            if (a == 1)
//            {
//                Console.WriteLine("Задайте швидкість транспортного засобу: ");
//                int notorcycleSpeed = int.Parse(Console.ReadLine());
                
//            }

//            Console.ReadKey();
//        }
//    }
//}