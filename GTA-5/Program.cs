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
        Console.WriteLine($"Двигатель транспорта \"{Model}\" запущен.");
    }
}

// Производный класс Танк
class Tank : Transport
{
    public string Division { get; set; }

    public Tank(string model, string division) : base(model)
    {
        Division = division;
    }

    public override void StartEngine()
    {
        Console.WriteLine($"Двигатель танка \"{Division} {Model}\" запущен.");
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

    public override void StartEngine()
    {
        Console.WriteLine($"Двигатели самолета \"{Airline} {Model}\" запущены.");
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

    public override void StartEngine()
    {
        Console.WriteLine($"Двигатель вертолета \"{Manufacturer} {Model}\" запущен.");
    }
}

// Производный класс Автобус
class Bus : Transport
{
    public string Route { get; set; }

    public Bus(string model, string route) : base(model)
    {
        Route = route;
    }

    public override void StartEngine()
    {
        Console.WriteLine($"Двигатель автобуса \"{Route} {Model}\" запущен.");
    }
}

// Производный класс Велосипед
class Bicycle : Transport
{
    public string Type { get; set; }

    public Bicycle(string model, string type) : base(model)
    {
        Type = type;
    }

    // Велосипед не имеет двигателя, поэтому метод переопределен
    public override void StartEngine()
    {
        Console.WriteLine($"Велосипед \"{Type} {Model}\" готов к поездке.");
    }
}

// Производный класс Водный мотоцикл
class JetSki : Transport
{
    public string Make { get; set; }

    public JetSki(string model, string make) : base(model)
    {
        Make = make;
    }

    public override void StartEngine()
    {
        Console.WriteLine($"Двигатель водного мотоцикла \"{Make} {Model}\" запущен.");
    }
}

// Производный класс Грязевой мотоцикл
class DirtBike : Transport
{
    public string Type { get; set; }

    public DirtBike(string model, string type) : base(model)
    {
        Type = type;
    }

    public override void StartEngine()
    {
        Console.WriteLine($"Двигатель грязевого мотоцикла \"{Type} {Model}\" запущен.");
    }
}

// Производный класс Спортивный автомобиль
class SportsCar : Transport
{
    public string Brand { get; set; }

    public SportsCar(string model, string brand) : base(model)
    {
        Brand = brand;
    }

    public override void StartEngine()
    {
        Console.WriteLine($"Двигатель спортивного автомобиля \"{Brand} {Model}\" запущен.");
    }
}

class Program
{
    static void Main()
    {
        // Создание объектов различных классов транспорта
        Transport[] vehicles = new Transport[]
        {
            new Tank("Khanjali", "Warstock"),
            new Airplane("Boeing 747", "Delta"),
            new Helicopter("Apache", "Boeing"),
            new Bus("City Bus", "Route 66"),
            new Bicycle("Mountain Bike", "Off-Road"),
            new JetSki("Seashark", "Speedophile"),
            new DirtBike("BF400", "Nagasaki"),
            new SportsCar("Zentorno", "Grotti"),
        };

        // Запуск двигателей (или подготовка к поездке для велосипеда) каждого транспортного средства
        foreach (var vehicle in vehicles)
        {
            vehicle.StartEngine();
        }
    }
}
