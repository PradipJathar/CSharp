using System;

namespace AccessModifiersAndProperties
{
    public class Person
    {
        public DateTime Birtdate { get; private set; }

        public Person(DateTime birthdate)
        {
            this.Birtdate = birthdate;
        }

        public int Age 
        { 
            get 
            {
                TimeSpan timeSpan = DateTime.Today - Birtdate;

                return timeSpan.Days / 365;
            }
        }


    }
}
