using System;
using System.Collections.Generic;

// Базовий клас "Живий організм"
public class LivingOrganism
{
    public double Energy { get; set; }
    public int Age { get; set; }
    public double Size { get; set; }

    public LivingOrganism(double energy, int age, double size)
    {
        Energy = energy;
        Age = age;
        Size = size;
    }
}

// Інтерфейс для організмів, які можуть розмножуватися
public interface IReproducible
{
    void Reproduce();
}

// Інтерфейс для організмів, які можуть полювати на інших організмів
public interface IPredator
{
    void Hunt(LivingOrganism prey);
}

// Клас "Тварина" успадковує "Живий організм" і реалізує інтерфейс "IPredator"
public class Animal : LivingOrganism, IPredator
{
    public string Species { get; set; }

    public Animal(double energy, int age, double size, string species)
        : base(energy, age, size)
    {
        Species = species;
    }

    public void Hunt(LivingOrganism prey)
    {
        // Логіка полювання
    }
}

// Клас "Рослина" успадковує "Живий організм"
public class Plant : LivingOrganism
{
    public string Type { get; set; }

    public Plant(double energy, int age, double size, string type)
        : base(energy, age, size)
    {
        Type = type;
    }
}

// Клас "Мікроорганізм" успадковує "Живий організм" і реалізує інтерфейс "IReproducible"
public class Microorganism : LivingOrganism, IReproducible
{
    public string Strain { get; set; }

    public Microorganism(double energy, int age, double size, string strain)
        : base(energy, age, size)
    {
        Strain = strain;
    }

    public void Reproduce()
    {
        // Логіка розмноження
    }
}

// Клас "Екосистема" моделює взаємодію різних організмів
public class Ecosystem
{
    private List<LivingOrganism> organisms = new List<LivingOrganism>();

    public void AddOrganism(LivingOrganism organism)
    {
        organisms.Add(organism);
    }

    public void SimulateEcosystem()
    {
        // Логіка моделювання взаємодії організмів в екосистемі
    }
}

public class Program
{
    public static void Main()
    {
        // Ваш код моделювання екосистеми можна розмістити тут
    }
}
