using System;

public abstract class Shape
{
    public int X { get; set; }
    public int Y { get; set; }

    public string? Color { get; set; }

    public Shape()
    {

    }
    public Shape(int x, int y, string? color)
    {
        X = x;
        Y = y;
        Color = color;
    }
    public Shape(Shape source)
    {
        X = source.X;
        Y = source.Y;
        Color = source.Color;
    }
    public abstract Shape Clone();
}


public class Rectangle : Shape
{
    public Shape? Shape { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }

    public Rectangle() 
    {

    }
    public Rectangle(Rectangle source) : base(source)
    {
        Width = source.Width;
        Height = source.Height;
    }

    public Rectangle Clone1()
    {
        return new Rectangle(this);
    }

    public override Shape Clone()
    {
        return new Rectangle(this);
    }
}

class Program
{
    static void Main()
    {
        Rectangle original = new Rectangle {X = 40, Y = 20, Color = "green" };
        Rectangle copy = (Rectangle)original.Clone();

        Console.WriteLine($"Original Number: {original.X} {original.Y} {original.Color}");
        Console.WriteLine($"Copy Number: {copy.X} {copy.Y} {copy.Color}");

        copy.X = 100;
        copy.Y = 100;
        copy.Color = "red";

        Console.WriteLine("Copy changed:");
        Console.WriteLine(value: $"Original Number: {original.X} {original.Y} {original.Color}");
        Console.WriteLine($"Copy Number: {copy.X} {copy.Y} {copy.Color}");
    }
}

