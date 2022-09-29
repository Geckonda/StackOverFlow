using System.Collections.Generic;

namespace myProgramm
{
    class Programm
    {
        static void Main()
        {
            //Stack<string> stackNames = new Stack<string>(5);
            //Stack<Person> stackPeople = new Stack<Person>(12);
            Test1();
            //Test2();
        }
        public static void Test2()
        {
            Stack<Person> stackPeople = new Stack<Person>(12);
            Person mike = new Person("Mike", 18,"Life goes on");
            Person kalamity = new Person("Kalamity", 21, "To secure poeple");
            stackPeople.Push(mike);
            var stranger = stackPeople.Top();
            Console.WriteLine("This:" + stranger.Age);
            Console.WriteLine(stackPeople.Pop());
        }
        public static void Test1()
        {
            Stack<int> stackCard = new Stack<int>(10);
            for (int i = 0; i < 4; i++)
                stackCard.Push(i + 1);
            stackCard.Show();
            //Console.WriteLine(stackCard.Pop());
            //Console.WriteLine(stackCard.Pop());
            //Console.WriteLine(stackCard.Top());
            //Console.WriteLine(stackCard.Pop());
            //Console.WriteLine(stackCard.Top());
            //stackCard.Push(32);
            //stackCard.Push(543);
            //Console.WriteLine();
            //Console.WriteLine(stackCard.Pop());
            //Console.WriteLine(stackCard.Top());
            //for (int i = 0; i < 11; i++)
            //    Console.WriteLine(stackCard.Pop());
        }
    }
    class Stack<T>
    {
        private T[] stack;
        private int position = -1;
        public Stack(int capacity)
        {
            stack = new T[capacity];
        }
        public void Push(T element)
        {
            if(position+1 < stack.Length)
            {
                position++;
                stack[position] = element;
            }
            else
            {
                Console.WriteLine("Стек переполнен");
                return;
            }
        }
        public T Pop()
        {
            if(position < 0)
            {
                Console.WriteLine("Стек пустой");
                return default(T)!;
            }
            else
            {
                T currentElement = stack[position];
                stack[position] = default(T)!;
                position--;
                return currentElement;
            }
        }
        public T Top()
        {
            if(position < 0)
                return default(T)!;
            else
                return stack[position];
        }
        public void Show()
        {
            for(int i = stack.Length-1; i >= 0 ; i--)
                Console.WriteLine(stack[i]);
        }
    }
    class Person
    {
        public string Name { get; }
        public int Age { get; }
        public string Purpose { get; }
        public Person(string name, int age, string purpose)
        {
            Name = name; Age = age; Purpose = purpose; 
        }
    }
}