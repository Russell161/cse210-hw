using System;
using System.Diagnostics.Tracing; 
using System.IO.Compression;
using System.Runtime.ConstrainedExecution;


class Cylinder
{
    private Circle _circle;
    private double _height;

    public Cylinder()
    {
        _height = 0.0;
        _circle = null;
    }

    public Cylinder(Circle circle)
    {
        _height = height;
        _circle = circle;
    }

    public Cylinder(double height, double radius)
    {
        _height = height;
        _circle = 
    }

    public void SetCircle(Circle circle)
    {
        _circle = circle;
        SetHeight(10);
    }

    public Cylinder(double height, double radius)
    {
        
    }

    public void SetHeight(double height)
    {
        if (height < 0)
        {
            Console.WriteLine("Error, cannont set a negative value.");
            return;
        }
        _height = height;
    }

    public double GetVolume()
    {
        return _circle.GetArea() * _height;
    }
}
