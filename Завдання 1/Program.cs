using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Завдання_1
{

    abstract class Transport //базовий клас
    {
        public abstract void SetSpeed(int speed);
        public abstract void OpenDoors(bool doors);
        public abstract void CloseDoors(bool doors);
        public abstract void ShowWeels();
    }

    class Vehicle
    {
        public void SetSpeed(Transport transport, int speed)
        {
            transport.SetSpeed(speed);
        }
        
        public void OpenDoors(Transport transport, bool doors)
        {
            if (doors == true)
            {
                transport.OpenDoors(doors);
            }
            
        }

        public void CloseDoors(Transport transport, bool doors)
        {
            if (doors == true)
                transport.CloseDoors(doors);
        }

        public void ShowWeels(Transport transport)
        {
            transport.ShowWeels();
        }

    }

    class Motorcycle : Transport
    {
        public override void SetSpeed(int speed)
        {
            int motorcycleSpeed = speed;
            Console.WriteLine($"Встановлено шидкість мотоцикла: {motorcycleSpeed} км/год");
        }

        public override void OpenDoors(bool doors)
        {
            Console.WriteLine("Помилка: у мотоцикла немає дверей");
        }

        public override void CloseDoors(bool doors)
        {
            Console.WriteLine("Помилка: у мотоцикла немає дверей");
        }

        public override void ShowWeels()
        {
            int motorcycleWeels = 2;
            Console.WriteLine($"У мотоцикла {motorcycleWeels} колеса");
        }

    }

    class Bicycle : Transport
    {
        public override void SetSpeed(int speed)
        {
            int bicycleSpeed = speed;
            Console.WriteLine($"Встановлено шидкість велосипеда: {bicycleSpeed} км/год");
        }
        
        public override void OpenDoors(bool doors)
        {
            Console.WriteLine("Помилка: у велосипеда немає дверей");
        }

        public override void CloseDoors(bool doors)
        {
            Console.WriteLine("Помилка: у велосипеда немає дверей");
        }

        public override void ShowWeels()
        {
            int bicycleWeels = 2;
            Console.WriteLine($"У велосипеда {bicycleWeels} колеса");
        }
    }

    class Motorbike : Transport
    {
        public override void SetSpeed(int speed)
        {
            int motorbikeSpeed = speed;
            Console.WriteLine($"Встановлено шидкість мопеда: {motorbikeSpeed} км/год");
        }

        public override void OpenDoors(bool doors)
        {
            Console.WriteLine("Помилка: у мопеда немає дверей");
        }

        public override void CloseDoors(bool doors)
        {
            Console.WriteLine("Помилка: у мопеда немає дверей");
        }

        public override void ShowWeels()
        {
            int motorbikeWeels = 2;
            Console.WriteLine($"У мопеда {motorbikeWeels} колеса");
        }
    }

    class Car : Transport
    {
        public override void SetSpeed(int speed)
        {
            int carSpeed = speed;
            Console.WriteLine($"Встановлено шидкість автомобіля: {carSpeed} км/год");
        }

        public override void OpenDoors(bool doors)
        {
            Console.WriteLine("Двері автомобіля відчинено");
        }

        public override void CloseDoors(bool doors)
        {
            Console.WriteLine("Двері автомобіля зачинено");
        }

        public override void ShowWeels()
        {
            int carWeels = 4;
            Console.WriteLine($"У автомобіля {carWeels} колеса");
        }
    }

    class Train : Transport
    {
        public override void SetSpeed(int speed)
        {
            int trainSpeed = speed;
            Console.WriteLine($"Встановлено шидкість потяга: {trainSpeed} км/год");
        }

        public override void OpenDoors(bool doors)
        {
            Console.WriteLine("Двері потяга відчинено");
        }

        public override void CloseDoors(bool doors)
        {
            Console.WriteLine("Двері автомобіля потяга");
        }

        public override void ShowWeels()
        {
            int trainWeels = 12;
            Console.WriteLine($"У потяга {trainWeels} коліс");
        }
    }

    



    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            Motorcycle motorcycle = new Motorcycle();
            Bicycle bicycle = new Bicycle();
            Motorbike motorbike = new Motorbike();
            Car car = new Car();
            Train train = new Train();


            bool cont = true;
            do
            {
                bool continue1 = true;
                do
                {
                    Console.WriteLine("1 - мотоцикл");
                    Console.WriteLine("2 - велосипед");
                    Console.WriteLine("3 - мопед");
                    Console.WriteLine("4 - автомобіль");
                    Console.WriteLine("5 - потяг");
                    Console.Write("Виберіть транспортний засіб: ");

                    int t = int.Parse(Console.ReadLine());


                    Console.WriteLine("\nВиберіть дію: ");
                    Console.WriteLine("1 - задати швидкість");
                    Console.WriteLine("2 - показати кількість колес");
                    Console.WriteLine("3 - відкрити двері");
                    Console.WriteLine("4 - закрити двері");

                    int c = int.Parse(Console.ReadLine());


                    if (t == 1 && c == 1) //МОТОЦИКЛ    
                    {
                        Console.Write("Введіть швидкість у км/год: ");
                        int speed = int.Parse(Console.ReadLine());

                        vehicle.SetSpeed(motorcycle, speed);

                        Console.WriteLine("\nПовернутися в меню:");
                        Console.WriteLine("Натисніть 1");
                        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                        if (keyInfo.Key == ConsoleKey.NumPad1)
                        {
                            continue1 = false; // зупиняємо роботу циклу
                        }

                    }
                    else if (t == 1 && c == 2)
                    {
                        vehicle.ShowWeels(motorcycle);

                        Console.WriteLine("\nПовернутися в меню:");
                        Console.WriteLine("Натисніть 1");
                        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                        if (keyInfo.Key == ConsoleKey.NumPad1)
                        {
                            continue1 = false; // зупиняємо роботу циклу
                        }

                    }
                    else if (t == 1 && c == 3)
                    {
                        vehicle.OpenDoors(motorcycle, true);

                        Console.WriteLine("\nПовернутися в меню:");
                        Console.WriteLine("Натисніть 1");
                        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                        if (keyInfo.Key == ConsoleKey.NumPad1)
                        {
                            continue1 = false; // зупиняємо роботу циклу
                        }
                    }
                    else if (t == 1 && c == 4)
                    {
                        vehicle.CloseDoors(motorcycle, true);

                        Console.WriteLine("\nПовернутися в меню:");
                        Console.WriteLine("Натисніть 1");
                        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                        if (keyInfo.Key == ConsoleKey.NumPad1)
                        {
                            continue1 = false; // зупиняємо роботу циклу
                        }
                    }
                    else if (t == 2 && c == 1) //ВЕЛОСИПЕД
                    {

                        Console.Write("Введіть швидкість у км/год: ");
                        int speed = int.Parse(Console.ReadLine());

                        vehicle.SetSpeed(bicycle, speed);

                        Console.WriteLine("\nПовернутися в меню:");
                        Console.WriteLine("Натисніть 1");
                        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                        if (keyInfo.Key == ConsoleKey.NumPad1)
                        {
                            continue1 = false; // зупиняємо роботу циклу
                        }
                    }
                    else if (t == 2 && c == 2)
                    {
                        vehicle.ShowWeels(bicycle);

                        Console.WriteLine("\nПовернутися в меню:");
                        Console.WriteLine("Натисніть 1");
                        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                        if (keyInfo.Key == ConsoleKey.NumPad1)
                        {
                            continue1 = false; // зупиняємо роботу циклу
                        }
                    }
                    else if (t == 2 && c == 3)
                    {
                        vehicle.OpenDoors(bicycle, true);

                        Console.WriteLine("\nПовернутися в меню:");
                        Console.WriteLine("Натисніть 1");
                        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                        if (keyInfo.Key == ConsoleKey.NumPad1)
                        {
                            continue1 = false; // зупиняємо роботу циклу
                        }
                    }
                    else if (t == 2 && c == 4)
                    {
                        vehicle.CloseDoors(bicycle, true);

                        Console.WriteLine("Повернутися в меню:");
                        Console.WriteLine("Натисніть 1");
                        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                        if (keyInfo.Key == ConsoleKey.NumPad1)
                        {
                            continue1 = false; // зупиняємо роботу циклу
                        }
                    }
                    else if (t == 3 && c == 1) //МОПЕД
                    {
                        Console.Write("Введіть швидкість у км/год: ");
                        int speed = int.Parse(Console.ReadLine());

                        vehicle.SetSpeed(motorbike, speed);

                        Console.WriteLine("\nПовернутися в меню:");
                        Console.WriteLine("Натисніть 1");
                        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                        if (keyInfo.Key == ConsoleKey.NumPad1)
                        {
                            continue1 = false; // зупиняємо роботу циклу
                        }
                    }
                    else if (t == 3 && c == 2)
                    {
                        vehicle.ShowWeels(motorbike);

                        Console.WriteLine("\nПовернутися в меню:");
                        Console.WriteLine("Натисніть 1");
                        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                        if (keyInfo.Key == ConsoleKey.NumPad1)
                        {
                            continue1 = false; // зупиняємо роботу циклу
                        }
                    }
                    else if (t == 3 && c == 3)
                    {
                        vehicle.OpenDoors(motorbike, true);

                        Console.WriteLine("\nПовернутися в меню:");
                        Console.WriteLine("Натисніть 1");
                        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                        if (keyInfo.Key == ConsoleKey.NumPad1)
                        {
                            continue1 = false; // зупиняємо роботу циклу
                        }
                    }
                    else if (t == 3 && c == 4)
                    {
                        vehicle.CloseDoors(motorbike, true);

                        Console.WriteLine("\nПовернутися в меню:");
                        Console.WriteLine("Натисніть 1");
                        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                        if (keyInfo.Key == ConsoleKey.NumPad1)
                        {
                            continue1 = false; // зупиняємо роботу циклу
                        }
                    }
                    else if (t == 4 && c == 1)
                    {
                        Console.Write("Введіть швидкість у км/год: ");
                        int speed = int.Parse(Console.ReadLine());

                        vehicle.SetSpeed(car, speed);

                        Console.WriteLine("\nПовернутися в меню:");
                        Console.WriteLine("Натисніть 1");
                        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                        if (keyInfo.Key == ConsoleKey.NumPad1)
                        {
                            continue1 = false; // зупиняємо роботу циклу
                        }
                    }
                    else if (t == 4 && c == 2)
                    {
                        vehicle.ShowWeels(car);

                        Console.WriteLine("\nПовернутися в меню:");
                        Console.WriteLine("Натисніть 1");
                        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                        if (keyInfo.Key == ConsoleKey.NumPad1)
                        {
                            continue1 = false; // зупиняємо роботу циклу
                        }
                    }
                    else if (t == 4 && c == 3)
                    {
                        vehicle.OpenDoors(car, true);

                        Console.WriteLine("\nПовернутися в меню:");
                        Console.WriteLine("Натисніть 1");
                        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                        if (keyInfo.Key == ConsoleKey.NumPad1)
                        {
                            continue1 = false; // зупиняємо роботу циклу
                        }
                    }
                    else if (t == 4 && c == 4)
                    {
                        vehicle.CloseDoors(car, true);

                        Console.WriteLine("\nПовернутися в меню:");
                        Console.WriteLine("Натисніть 1");
                        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                        if (keyInfo.Key == ConsoleKey.NumPad1)
                        {
                            continue1 = false; // зупиняємо роботу циклу
                        }
                    }
                    else if (t == 5 && c == 1)
                    {
                        Console.Write("Введіть швидкість у км/год: ");
                        int speed = int.Parse(Console.ReadLine());

                        vehicle.SetSpeed(train, speed);

                        Console.WriteLine("\nПовернутися в меню:");
                        Console.WriteLine("Натисніть 1");
                        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                        if (keyInfo.Key == ConsoleKey.NumPad1)
                        {
                            continue1 = false; // зупиняємо роботу циклу
                        }
                    }
                    else if (t == 5 && c == 2)
                    {
                        vehicle.ShowWeels(train);

                        Console.WriteLine("\nПовернутися в меню:");
                        Console.WriteLine("Натисніть 1");
                        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                        if (keyInfo.Key == ConsoleKey.NumPad1)
                        {
                            continue1 = false; // зупиняємо роботу циклу
                        }
                    }
                    else if (t == 5 && c == 3)
                    {
                        vehicle.OpenDoors(train, true);

                        Console.WriteLine("\nПовернутися в меню:");
                        Console.WriteLine("Натисніть 1");
                        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                        if (keyInfo.Key == ConsoleKey.NumPad1)
                        {
                            continue1 = false; // зупиняємо роботу циклу
                        }
                    }
                    else if (t == 5 && c == 4)
                    {
                        vehicle.CloseDoors(train, true);

                        Console.WriteLine("\nПовернутися в меню:");
                        Console.WriteLine("Натисніть 1");
                        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                        if (keyInfo.Key == ConsoleKey.NumPad1)
                        {
                            continue1 = false; // зупиняємо роботу циклу
                        }
                    }

                }
                while (continue1);





            }
            while (cont);
        
            Console.ReadKey();
        }
    }
}