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
        public readonly int capacity = 0;
        public Stack(int capacityOfStack)
        {
            capacity = capacityOfStack;
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
        public bool IsFull
        {
            get { return position+1 == capacity; }
        }
        public void Push(T element)
        {
            if(IsFull)
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
}
