using System;

namespace program;

class SpaceVector
{
    public double X { get; }
    public double Y { get; }
    public double Z { get; }
    public SpaceVector(double x, double y, double z) => (X, Y, Z) = (x, y, z);
    public SpaceVector Add(SpaceVector v) => new(X + v.X, Y + v.Y, Z + v.Z);
    public SpaceVector Subtract(SpaceVector v) => new(X - v.X, Y - v.Y, Z - v.Z);
    public double Length() => Math.Sqrt(X * X + Y * Y + Z * Z);
    public double Dot(SpaceVector v) => X * v.X + Y * v.Y + Z * v.Z;
    public double CosAngle(SpaceVector v) => Dot(v) / (Length() * v.Length());
    public override string ToString() => $"({X}, {Y}, {Z})";
}

class Program
{
    static double ReadCoord(string name)
    {
        double val;
        while (!double.TryParse(Console.ReadLine(), out val))
        {
            Console.Write($"Помилка! Введіть число для {name}: ");
        }
        return val;
    }

    static void Main()
    {
        Console.WriteLine("Введіть координати першого вектора падіння зірки:");
        var v1 = new SpaceVector(ReadCoord("X"), ReadCoord("Y"), ReadCoord("Z"));
        Console.WriteLine("Введіть координати другого вектора падіння зірки:");
        var v2 = new SpaceVector(ReadCoord("X"), ReadCoord("Y"), ReadCoord("Z"));
        Console.WriteLine($"Сума: {v1.Add(v2)} | Довжина 1-го: {v1.Length():F2} | Косинус кута: {v1.CosAngle(v2):F4}");
    }
}
