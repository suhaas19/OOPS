using System;

namespace OOPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Person s1 = new Person {firstName="Suhaas Gupta", lastName="Nagaralla"};
            Console.WriteLine(s1.firstName+" "+s1.lastName);
            Console.WriteLine(s1.getName());
            Person s2 = new Person { firstName = "LOL", lastName = "Reddy" };
            Console.WriteLine(s2.sal+" "+s2.firstName + " " + s2.lastName);

            Person s3 = new Person("","chinna", "singh");
            Console.WriteLine(s3.sal+" "+s3.firstName + " " + s3.lastName);

            Student meme= new Student();
            Console.WriteLine(meme.Snum + " " + meme.getName());
            meme.setSSN("999");
            Console.WriteLine("The Student SSN is: "+meme.getSSN());

            GradStudent s4= new GradStudent();
            Console.WriteLine(s4.Snum + " " + s4.getName()+" "+s4.Rest());

        }
    }
}
