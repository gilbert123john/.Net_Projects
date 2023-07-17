//To create a project that act like chat bot  
using System;

namespace AssignmentProject1
{
    public class Details
    {
        public string name;
        public int age;
        public string qualification;

        public void Disp()
        {
            Console.WriteLine("Hai My name is " + name + " am having " + age.ToString() + " years and have completed my " + qualification);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Good day ! can you spend some time to be a part of our interview ? yes/no ");
            ch = Console.ReadLine()[0];
            if (ch == 'y')
            {
                Console.WriteLine("Thank you for your coperation. Lets start....");
                Details d1= new Details();
                Console.WriteLine("Your Good name :");
                d1.name = Console.ReadLine();
                Console.WriteLine("Age :");
                d1.age = int.Parse(Console.ReadLine());
                Console.WriteLine("Educational Qualification :");
                d1.qualification = Console.ReadLine();

                d1.Disp();
            }
            else
            {
                Console.WriteLine("Thank you!!!");
            }
        }
    }
}