using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiniraneNaKlassChovek
{
    public class Person
    {
        private string name;

        public string Name
        {
            get 
            {
                return name;
            }
            set 
            { 
                name = value;
            }
        }

        private int age;

        public int Age
        {
            get 
            {
                return age; 
            }
            set
            {
                age = value;
            }
        }

        public void IntroduceYourself()
        {
            Console.WriteLine($"Hello! My name is {name} and I am {age} years old.");
        }
    }
}
    

