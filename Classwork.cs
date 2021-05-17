using System;

namespace Interfaces
{
    public class Classwork
    {
        
    }

    public interface Vehicle
    {
        public void Engine();
        public void Transmission();
        public void Brake();
        public void Axle();
    }

    public class Truck : Vehicle
    {
        public void Axle()
        {
            Console.WriteLine("Stub Axle");
        }

        public void Brake()
        {
            Console.WriteLine("Hydraulic Brake");
        }

        public void Engine()
        {
            Console.WriteLine("Diesel Engine");
        }

        public void Transmission()
        {
            Console.WriteLine("Manual Transmission");
        }
    }

    public class Sedan : Vehicle
    {
        public void Axle()
        {
            Console.WriteLine("Rear Axle");
        }

        public void Brake()
        {
            Console.WriteLine("Disk");
        }

        public void Engine()
        {
            Console.WriteLine("Petrol Engine");
        }

        public void Transmission()
        {
            Console.WriteLine("Automatic Transmission");
        }
    }
}