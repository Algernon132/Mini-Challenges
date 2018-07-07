/*
 * Charles Bruscato
 * July 6, 2018
 * Musser IT 2001
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog
{
    public enum Gender { Male, Female };

     public class Dog
    {
        public string name;
        public string owner;
        public int age; 
        public Gender gender;

        public Dog(string Name , string Owner , int Age, Gender dogGender)
        {
            this.name = Name;
            this.owner = Owner;
            this.age = Age;
            this.gender = dogGender;
        }
        public Dog()
        {

        }

        public void bark(int num)
        {
            for(int i = 0;i<num;i++)
            {
                Console.WriteLine("Woof!");
            }
        }

        public string getTag()
        {
            string hisHer = (this.gender == Gender.Male ? "His" : "Her");
            string heShe = (this.gender == Gender.Male ? "he" : "she");
            string yearYears = (this.age == 1 ? "year" : "years");

            string returnText = "If lost, call " + this.owner + ". " + hisHer + " name is " + this.name + " and " + heShe + " is " + this.age + " " + yearYears + " old.";
            return (returnText);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var puppy =  new Dog("Orion", "Shawn", 1, Gender.Male);  // create object instance
            puppy.bark(3); // output: Woof!Woof!Woof!
            Console.WriteLine(puppy.getTag()); // output: If lost, call Shawn. His name is Orion and he is 1 year old.

            Console.WriteLine();

            var myDog = new Dog("Lileu", "Dale", 4, Gender.Female);  // create object instance
            myDog.bark(1); // output: Woof!
            Console.WriteLine(myDog.getTag()); // output: If lost, call Dale. Her name is Lileu and she is 4 years old.

            Console.ReadLine();
            
            /* I'm not sure if I should have declared these using "new". If I didn't put "new" there, the compiler gave the error "Non-invocable member 'Dog' cannot be used like a method" */
        }
    }
}
