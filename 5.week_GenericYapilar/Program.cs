using System;

namespace _5.week_GenericYapilar
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };

            PrintArray(array);

            DisplayStructType(1);

            Circle circle = new Circle();

            DisplayShapeType(circle);

            CreateInstance<Circle>();

            DisplayType(circle);

            GenericClass<int> genericClass = new GenericClass<int>(4);

            Stack<int> stack = new Stack<int>();

            Console.WriteLine(stack.IsEmpty());

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());

            Stack<string> strStack = new Stack<string>();

            Console.WriteLine(strStack.Pop());
            Console.WriteLine(strStack.Peek());
            Console.WriteLine(strStack.Pop());

            Repository<Student> student = new Repository<Student>();   
            

        }

        public abstract class Shape
        {

        }

        public class Circle: Shape
        {

        }

       

        public static void PrintArray<T>(T[] array)
        {
            foreach (T item in array)
            {
                Console.WriteLine(item);


            }
        }


        public void GenericMethod<T>(T i)
        {

            Console.WriteLine(i);

        }

        public void DisplayClassType<T>(T item) where T: class
        {

        }

        public static void DisplayStructType<T>(T item) where T: struct
        {

        }

        public static void DisplayShapeType<T>(T item) where T: Shape
        {

        }

        public static T CreateInstance<T>() where T: new()
        {
            return new T();
        }

        public static void DisplayType<T>(T item) where class, IEntity,new()
        {

        }

        public interface IEntity
        {



        }







    }
}
