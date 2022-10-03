using System.Collections.Generic;

namespace myProgramm
{
    public class Programm
    {
        static void Main()
        {
            Console.WriteLine("Testing...");
        }
    }
    public class Stack<T>
    {
        private T[] stack;
        private int position = -1;
        public Stack(int capacity)
        {
            stack = new T[capacity];
        }
        public bool IsEmpty
        {
            get { return position < 0; }
        }
        public int Count
        {
            get { return position+1; }
        }
        public void Push(T element)
        {
            if(position+1 == stack.Length)
                throw new InvalidOperationException("Переполнение стека!");
            stack[++position] = element;
        }
        public T Pop()
        {
            if(IsEmpty)
                throw new InvalidOperationException("Стек пуст!");
            T currentElement = stack[position];
            stack[position] = default(T)!;
            position--;
            return currentElement;
        }
        public T Top()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Стек пуст!");
            return stack[position];
        }
    }
    public class Person
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
