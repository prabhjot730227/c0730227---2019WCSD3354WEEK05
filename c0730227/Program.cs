using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c0730227
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new TestQuestion2();
            a.PlayingWithForLoops();
        }
    }

    class TestQuestion2
    {
        public int myFavouriteVariable = 0;
        public void PlayingWithForLoops()
        {
            for (; MyMethod();)
            {
                if (myFavouriteVariable > 10)
                {
                    Console.WriteLine("I am so out of here!");
                    break;
                }
                Console.WriteLine("Oh no I have to go through this stupid loop again...");
            }

        }
        public bool MyMethod()
        {
            myFavouriteVariable++;
            return true;

        }
    }

    class dog
    {
        private dog(string name, string breed)
        {
            dog_name = name;
            dog_breed = breed;

        }
            public string dog_name;
            public string dog_breed;
            public dog next_dog;
            public dog prev_dog;

    }
    class birthday_party
    {
        public dog peanut;
        public dog fif;
        public dog clarence;
        public dog roy;

        public dog head;
        public dog tail;
        public dog temporary;
    }
}