using System;

// Старий інтерфейс, який ми хочемо адаптувати
public class OldSystem
{
    public void DoSomethingOld()
    {
        Console.WriteLine("Doing something in the old system.");
    }
}

// Новий інтерфейс, який ми хочемо використовувати
public interface INewSystem
{
    void DoSomethingNew();
}

// Адаптер, який реалізує новий інтерфейс та використовує старий
public class Adapter : INewSystem
{
    private OldSystem oldSystem;

    public Adapter(OldSystem oldSystem)
    {
        this.oldSystem = oldSystem;
    }

    public void DoSomethingNew()
    {
        // Виклик функції старої системи в новому інтерфейсі
        oldSystem.DoSomethingOld();
    }
}

// Клас, який використовує новий інтерфейс
public class Client
{
    public void UseNewSystem(INewSystem newSystem)
    {
        newSystem.DoSomethingNew();
    }
}

class Program
{
    static void Main()
    {
        // Використання адаптера для з'єднання старої системи з новою
        OldSystem oldSystem = new OldSystem();
        INewSystem adapter = new Adapter(oldSystem);

        // Використання нової системи через адаптер
        Client client = new Client();
        client.UseNewSystem(adapter);
    }
}
