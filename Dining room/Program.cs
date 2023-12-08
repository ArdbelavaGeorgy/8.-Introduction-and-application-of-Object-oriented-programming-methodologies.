using System;

// Базовый класс Еда
class Food
{
    public string Name { get; set; }

    public Food(string name)
    {
        Name = name;
    }

    public virtual void Prepare()
    {
        Console.WriteLine($"\"{Name}\" готовится.");
    }
}

// Производный класс Бутерброд
class Sandwich : Food
{
    public Sandwich(string name) : base(name) { }

    public override void Prepare()
    {
        Console.WriteLine($"Бутерброд \"{Name}\" собирается.");
    }
}

// Производный класс Пицца
class Pizza : Food
{
    public Pizza(string name) : base(name) { }

    public override void Prepare()
    {
        Console.WriteLine($"Пицца \"{Name}\" готовится в печи.");
    }
}

// Производный класс Блины
class Pancake : Food
{
    public Pancake(string name) : base(name) { }

    public override void Prepare()
    {
        Console.WriteLine($"Блины \"{Name}\" готовятся на сковороде.");
    }
}

// Производный класс Десерт Тирамису
class Tiramisu : Food
{
    public Tiramisu(string name) : base(name) { }

    public override void Prepare()
    {
        Console.WriteLine($"Десерт Тирамису \"{Name}\" готовится.");
    }
}

// Производный класс Стейк
class Steak : Food
{
    public Steak(string name) : base(name) { }

    public override void Prepare()
    {
        Console.WriteLine($"Стейк \"{Name}\" жарится.");
    }
}

// Производный класс Салат Цезарь
class CaesarSalad : Food
{
    public CaesarSalad(string name) : base(name) { }

    public override void Prepare()
    {
        Console.WriteLine($"Салат Цезарь \"{Name}\" нарезается и заправляется.");
    }
}

// Производный класс Борщ
class Borsch : Food
{
    public Borsch(string name) : base(name) { }

    public override void Prepare()
    {
        Console.WriteLine($"Борщ \"{Name}\" варится.");
    }
}

// Производный класс Паста
class Pasta : Food
{
    public Pasta(string name) : base(name) { }

    public override void Prepare()
    {
        Console.WriteLine($"Паста \"{Name}\" готовится.");
    }
}

// Производный класс Рыба
class Fish : Food
{
    public Fish(string name) : base(name) { }

    public override void Prepare()
    {
        Console.WriteLine($"Рыба \"{Name}\" жарится.");
    }
}

// Производный класс Курица
class Chicken : Food
{
    public Chicken(string name) : base(name) { }

    public override void Prepare()
    {
        Console.WriteLine($"Курица \"{Name}\" запекается.");
    }
}

class Program
{
    static void Main()
    {
        // Создание объектов различных классов еды
        Food[] dishes = new Food[]
        {
            new Sandwich("С ветчиной и сыром"),
            new Pizza("Пепперони"),
            new Pancake("С икрой"),
            new Tiramisu("Классический"),
            new Steak("Рибай"),
            new CaesarSalad("С курицей"),
            new Borsch("Классический"),
            new Pasta("Карбонара"),
            new Fish("Лосось"),
            new Chicken("Гриль")
        };

        // Подготовка каждого блюда
        foreach (var dish in dishes)
        {
            dish.Prepare();
        }
    }
}
