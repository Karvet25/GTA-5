using System;

// Базовый класс Транспорт
class Transport
{
    public string Model { get; set; }

    public Transport(string model)
    {
        Model = model;
    }

    public virtual void StartEngine()
    {
        Console.WriteLine($"Двигатель транспорта {Model} запущен.");
    }
}

// Производный класс Автомобиль
class Car : Transport
{
    public string Brand { get; set; }

    public Car(string model, string brand) : base(model)
    {
        Brand = brand;
    }

    // Переопределение метода StartEngine
    public override void StartEngine()
    {
        Console.WriteLine($"Двигатель автомобиля {Brand} {Model} запущен.");
    }
}

// Производный класс Мотоцикл
class Motorcycle : Transport
{
    public string Type { get; set; }

    public Motorcycle(string model, string type) : base(model)
    {
        Type = type;
    }

    // Переопределение метода StartEngine
    public override void StartEngine()
    {
        Console.WriteLine($"Двигатель мотоцикла {Type} {Model} запущен.");
    }
}

// Производный класс Вертолет
class Helicopter : Transport
{
    public string Manufacturer { get; set; }

    public Helicopter(string model, string manufacturer) : base(model)
    {
        Manufacturer = manufacturer;
    }

    // Переопределение метода StartEngine
    public override void StartEngine()
    {
        Console.WriteLine($"Двигатель вертолета {Manufacturer} {Model} запущен.");
    }
}

// Производный класс Самолет
class Airplane : Transport
{
    public string Airline { get; set; }

    public Airplane(string model, string airline) : base(model)
    {
        Airline = airline;
    }

    // Переопределение метода StartEngine
    public override void StartEngine()
    {
        Console.WriteLine($"Двигатель самолета {Airline} {Model} запущен.");
    }
}

// Производный класс Мопед
class Moped : Transport
{
    public string Style { get; set; }

    public Moped(string model, string style) : base(model)
    {
        Style = style;
    }

    // Переопределение метода StartEngine
    public override void StartEngine()
    {
        Console.WriteLine($"Двигатель мопеда {Style} {Model} запущен.");
    }
}

// Производный класс Катер
class Motorboat : Transport
{
    public string BoatType { get; set; }

    public Motorboat(string model, string boatType) : base(model)
    {
        BoatType = boatType;
    }

    // Переопределение метода StartEngine
    public override void StartEngine()
    {
        Console.WriteLine($"Двигатель катера {BoatType} {Model} запущен.");
    }
}

// Производный класс Трамвай
class Tram : Transport
{
    public string City { get; set; }

    public Tram(string model, string city) : base(model)
    {
        City = city;
    }

    // Переопределение метода StartEngine
    public override void StartEngine()
    {
        Console.WriteLine($"Двигатель трамвая в городе {City} {Model} запущен.");
    }
}

class Programm
{
    static void Main()
    {
        // Создание объектов
        Transport[] vehicles = new Transport[]
        {
            new Car("Civic", "Honda"),
            new Car("Camry", "Toyota"),
            new Motorcycle("Ninja", "Sport"),
            new Motorcycle("Harley", "Cruiser"),
            new Helicopter("H145", "Airbus"),
            new Airplane("Boeing 747", "Delta"),
            new Moped("Vespa", "Classic"),
            new Motorboat("Speedster", "Speedboat"),
            new Tram("T-1000", "New York")
        };

        // Запуск двигателей с использованием цикла
        foreach (var vehicle in vehicles)
        {
            vehicle.StartEngine();
        }
    }
}

