using System;

namespace Practice
{
    class Cylinder
    {
        double BaseArea;
        double LateralArea;
        double TotalArea;
        double Volume;
        double Radius;
        double Height;
        public void Process()
        {
            Console.WriteLine("Enter the dimenstions of the cylinder");
            Console.WriteLine("Radius: ");
            Radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Height: ");
            Height = Convert.ToDouble(Console.ReadLine());
            BaseArea = Radius * Radius * Math.PI;
            LateralArea = 2 * Math.PI * Radius * Height;
            TotalArea = 2 * Math.PI * Radius * (Height + Radius);
            Volume = Math.PI * Radius * Radius * Height;
        }
        public void Result()
        {
            Console.WriteLine();
            Console.WriteLine("Cylinder Characteristics ");
            Console.WriteLine("Radius: {0}, Height: {1}", Radius, Height);
            Console.WriteLine("Base: {0:0.00} | Lateral: {1:0.00} | Total: {2:0.00} | Volume: {3:0.00}", BaseArea, LateralArea, TotalArea, Volume);
        }
        static void Main(string[] args)
        {
            Cylinder objClinder = new Cylinder();
            objClinder.Process();
            objClinder.Result();

        }
    }

}
