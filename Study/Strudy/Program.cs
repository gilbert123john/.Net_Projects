using System;

namespace study
{
    public delegate void addNum(int a, int b);
    public delegate void subNum(int a, int b);

    public class Program
    {
        class delClass
        {
            public void sum(int a , int b)
            {
                Console.WriteLine("Sum is {0}",a+b);
            }
            public void sub(int a, int b)
            {
                Console.WriteLine("Diff is {0}",a-b);
            }
        }
        public static void Main(string[] args)
        {
            delClass obj = new delClass();

            addNum addObj = new addNum(obj.sum);
            subNum subObj = new subNum(obj.sub);
            addObj(10, 20);
            subObj(40, 20);
        }
    }
}