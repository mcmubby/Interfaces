using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // Consultant doctor = new Consultant();
            // doctor.DoAThing();

            Cats newCat = new Cats();
            Dogs newDog = new Dogs();

            newCat.cats();
            newDog.dogs();
        }
    }


    interface IStudent
    {
        void PrintSomething();
        void DoSomething();
    }

    interface ICourse
    {
        void CourseRegistration();
    }

    class Student : RandomClass, IStudent, ICourse
    {
        public void CourseRegistration()
        {
            throw new NotImplementedException();
        }

        public void DoSomething()
        {
            Console.WriteLine("my do something");
        }

        public void PrintSomething()
        {
            Console.WriteLine("my full name");
        }
    }

    class RandomClass
    {

    }

    public abstract class Dentist
    {
        public int id;

        public void DoAThing()
        {
            Console.WriteLine("A thing");
        }

        public abstract void PrintAThing();
    }

    public class Consultant : Dentist
    {

        public override void PrintAThing()
        {
            throw new NotImplementedException();
        }
    }

    // interface members are public by default
    // interface does not contain fields
    // a class must implement the interface members
    // the signature of the method must be equak to the signature of the interface
    // Classes allow multiple interface inheritance
    // You cannot create an instance of interface
    // An interface reference variable can point to a derived class objects


    //------------Differences between interface & abstract
    // abstract class can have implementations while interfaces can't
    // Interfaces are public by default while abstract classes are not
    // Interface cannot have fields but abstract class can
    // You can inherit multiple interfaces but can't inherit multiple abstract classes

    public abstract class Animal
    {
        public abstract void cats();
        public abstract void dogs();
    }

    public class Dogs : Animal
    {
        public override void cats()
        {
            throw new NotImplementedException();
        }

        public override void dogs()
        {
            Console.WriteLine("Dogs Bark");
        }
    }

    public class Cats : Animal
    {
        public override void cats()
        {
            Console.WriteLine("Cats Meow");
        }

        public override void dogs()
        {
            throw new NotImplementedException();
        }
    }
}
