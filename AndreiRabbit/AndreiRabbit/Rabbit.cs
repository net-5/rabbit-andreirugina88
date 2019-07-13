using System;
using System.Collections.Generic;
using System.Text;

namespace MyAwesomeRabbit
{
    //Model the Rabbit class knowing that:

    //A rabbit can have Blue, Red or Black eyes.
    //A rabbit's fur can be white, brown, black or grey.
    //It has a gender.
    //It has a birth date, and based on that you should be able to see how old the rabbit is.
    //We also know that a rabbit is a mammal that moves, sleeps and eats.

    public enum Eyes
    {
        blue,
        red,
        black
    }

    public enum Fur
    {
        White,
        Brown,
        Black,
        Grey
    }

    public enum Gender
    {
        Male,
        Female
    }
    public class Rabbit
    {
        Eyes eyes;
        Fur fur;
        Gender gender;

        public Eyes Eyes
        {
            get { return this.eyes; }
            set { this.eyes = value; }
        }

        public Fur Fur
        {
            get { return this.fur; }
            set { this.fur = value; }
        }
        public Gender Gender
        {
            get { return this.gender; }
            set { this.gender = value; }
        }
        private DateTime birthDate;
        public DateTime BirthDate
        {
            get { return this.birthDate; }
            set { this.birthDate = value; }
        }

        public Rabbit(Eyes eyes, Fur fur, Gender gender, DateTime birthDate)
        {
            Eyes = eyes;
            Fur = fur;
            Gender = gender;
            this.birthDate = birthDate;
        }

        public int Age
        {
            get
            {
                DateTime currentDate = DateTime.Today;
                int age = currentDate.Year - BirthDate.Year;

                if (currentDate.Month < BirthDate.Month || (currentDate.Month == BirthDate.Month && currentDate.Day < BirthDate.Day))
                {
                    age--;
                }
                return age;
            }
        }

        public string MyDescription()
        {
            return $"I am a {Gender} rabbit. I have {Eyes} eyes. My fur is {Fur}. I am {Age} years old.";
        }

        public string MyAge()
        {
            return $"I am a {(Age).ToString()} years old {Gender} rabbit.";
        }

        public string Moveing()
        {
            return $"I am a very fast animal.";
        }

        public string Sleeping()
        {
            return $"I sleep a little and I am very vigilant during my sleep.";
        }

        public string Eating()
        {
            return $"I'm a rodent who eats carrots and cabbage.";
        }


    }
} 
