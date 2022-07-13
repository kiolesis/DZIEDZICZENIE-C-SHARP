using System;
using System.Threading;

namespace Consoleapp2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Dziedziczenie - Wstęp

            BMW car = new BMW();
            //car.Cost = 8000;
            //car.Speed = 80;
            //car.Description = "Niezawodny i szybki samochód!";
            
            car.Ride(10001);

            car.Stop();

            //car.ImmediateStop();

            Console.WriteLine("Koniec gry!");

            //Console.WriteLine(car.Cost);
            //Console.WriteLine(car.Description);

        }
    }

    public class Car
    {
        public string _brand;

        public int Cost { get; set; }
        public int Speed { get; set; }
        public string Description { get; set; }

    }

    public interface IVehicle
    {
        void Ride(int time);
    }

    public abstract class Vehicle
    {
        public abstract void Ride(int time);
        public abstract void Stop();
    }

    public class BMW : Car
    {

        public BMW()
        {
            _brand = "BMW";
            Cost = 20000;
            Speed = 40;
            Description = "Nowy samochód";
        }

        public void Ride(int time)
        {
            Console.WriteLine($"Samochód marki {_brand} w trasie!" +
                "\nPrzejażdzka będzie trwała " + time / 1000 + " sekund.");

            Console.WriteLine("Szybkość: " + Speed + " kilometrów na godzinę");
            Console.WriteLine("Opis: " + Description);
            Console.WriteLine("Cena: " + Cost);

            if (Speed > 50)
            {   
                Thread.Sleep(1000);
                ImmediateStop();
            }
            else
                Thread.Sleep(time);
        }

        public void Stop()
        {
            Console.WriteLine("Samochód się zatrzymał!");
        }

        private void ImmediateStop()
        {
            Console.WriteLine("Samochód został natychmiastowo zatrzymany!");
        }
    }
}
