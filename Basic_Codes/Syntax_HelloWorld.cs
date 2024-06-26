using System;
//using System means that we can use classes from the System namespace.

namespace file//namespace is avoid the collision between the different program.
//namespace is used to organize your code, and it is a container for classes and other namespaces
{
    public class Syntax_HelloWorld//class is a container for data and methods, which brings functionality to your program.
    // Every line of code that runs in C# must be inside a class.* C# is a Case Sensitive language.
    {
        public static void Main(String[] args)
    {
        System.Console.WriteLine("HELLO WORLD!!");//console does the work of printf.
        //Console is a class of the System namespace, which has a WriteLine() method that is used to output/print text.
    }
    }
}