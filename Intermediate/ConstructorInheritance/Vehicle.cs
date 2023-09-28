using System;

namespace ConstructorInheritance
{
    public class Vehicle
    {
        private readonly string _registrationNumber;
        public Vehicle(string registrationNumber)                   // Base class constructor are always executed first.
        {                                                           // Base class constructor are not inherited.
            _registrationNumber = registrationNumber;

            Console.WriteLine($"Vehicle is being initialized. {registrationNumber}");
        }
    }
}
