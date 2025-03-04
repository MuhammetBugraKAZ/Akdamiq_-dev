using System;

class Car  // Ana sınıf (Base Class)
{
    public string Brand { get; set; }  // Araç markasını tutan özellik

    public virtual void ShowTransmission() // Sanal metot (Override edilebilir)
    {
        Console.WriteLine($"{Brand} → Vites tipi belirtilmemiştir.");
    }
}

// BMW sınıfı
class BMW : Car
{
    public BMW()
    {
        Brand = "BMW";
    }

    public override void ShowTransmission()
    {
        Console.WriteLine($"{Brand} → Düz viteslidir.");
    }
}

// Porsche sınıfı
class Porsche : Car
{
    public Porsche()
    {
        Brand = "Porsche";
    }

    public override void ShowTransmission()
    {
        Console.WriteLine($"{Brand} → Otomatik viteslidir.");
    }
}

// Mercedes sınıfı
class Mercedes : Car
{
    public Mercedes()
    {
        Brand = "Mercedes";
    }

    public override void ShowTransmission()
    {
        Console.WriteLine($"{Brand} → Otomatik viteslidir.");
    }
}

// Togg sınıfı
class Togg : Car
{
    public Togg()
    {
        Brand = "Togg";
    }

    public override void ShowTransmission()
    {
        Console.WriteLine($"{Brand} → Otomatik viteslidir.");
    }
}

// Audi sınıfı
class Audi : Car
{
    public Audi()
    {
        Brand = "Audi";
    }

    public override void ShowTransmission()
    {
        Console.WriteLine($"{Brand} → Otomatik viteslidir.");
    }
}

// Toyota sınıfı
class Toyota : Car
{
    public Toyota()
    {
        Brand = "Toyota";
    }

    public override void ShowTransmission()
    {
        Console.WriteLine($"{Brand} → Düz viteslidir.");
    }
}

class Program
{
    static void Main()
    {
        // Araç nesneleri oluşturuluyor
        Car[] cars = { new BMW(), new Porsche(), new Mercedes(), new Togg(), new Audi(), new Toyota() };

        // Araçların vites bilgilerini ekrana yazdır
        foreach (var car in cars)
        {
            car.ShowTransmission();
        }
    }
}


abstract class Animal
{
    public abstract void Speak(); // İçeriği yok, türeyen sınıflar bunu dolduracak.
}

class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Köpek: Hav Hav!");
    }
}


abstract class Payment
{
    public abstract void MakePayment();  // Kullanıcı bu metodu çağırır, ama nasıl çalıştığını bilmek zorunda değildir.
}

class CreditCardPayment : Payment
{
    public override void MakePayment()
    {
        Console.WriteLine("Kredi kartı ile ödeme yapıldı.");
    }
}
abstract class Payment
{
    public abstract void MakePayment();  // Kullanıcı bu metodu çağırır, ama nasıl çalıştığını bilmek zorunda değildir.
}

class CreditCardPayment : Payment
{
    public override void MakePayment()
    {
        Console.WriteLine("Kredi kartı ile ödeme yapıldı.");
    }
}
class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("Hayvan ses çıkarıyor.");
    }
}

class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Köpek: Hav Hav!");
    }
}

class MathOperations
{
    public int Sum(int a, int b)
    {
        return a + b;
    }

    public double Sum(double a, double b)
    {
        return a + b;
    }
}
