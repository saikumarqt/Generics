using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    /*
     * Generics is similar like c++ templates
     * Generics was introduced with .net framework .net 2.0
     * Generics will allow the programmer to decide parameeter type
     * at the time of consumption that is in declaration we will
     * declare it as a genric type and which can be consumed as int or
     * flot or char or double requirement
     * In C# .net we can have generic varibale,generic property,generic constructor,
     * generic method,generic class
     * To implement generics we will use place holder operator(<>)
     * will type parameter like below<T>
     * Generic Function:
     * when we implement generics on method or function then we call it as a generic function
     * syntax:
     * <am><rt><fun name><T>(t <arg>)
     * {
     * }
     * 
     * Note:We can defined static and instance memebers as generic members
     */
    class myclass
    {
        internal void Display<T> (T u)
        {
            Console.WriteLine(u);
        }  
        internal static void show<T>(T d, T b)
        {
            Console.WriteLine(d + " ," + b);

        }
        internal void print<T ,k>(T a,k b)
        {
            Console.WriteLine(a + "," + b);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            myclass obj=new myclass();
            obj.Display<int>(10);
            obj.Display<string>("nagesh");
            myclass.show<int>(10, 20);
            myclass.show<string>("nagesh", "kumar");
            obj.print<int, string>(100, "patil");
        }
    }
}
