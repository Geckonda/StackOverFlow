using Xunit;
using myProgramm;
using System;


namespace StackTests
{
    public class UnitTest1
    {
        //[Fact]
        //public void TestConstructor()
        //{
        //    Stack<Person> stackPeople = new Stack<Person>(12);
        //    Assert.Equal(2, stackPeople.);
        //}
        [Fact]
        public void TestCount()
        {
            Stack<Person> stackPeople = new Stack<Person>(12);
            Person mike = new Person("Mike", 18, "Life goes on");
            Person kalamity = new Person("Kalamity", 21, "To secure poeple");
            stackPeople.Push(mike);
            stackPeople.Push(kalamity);
            Assert.Equal(2, stackPeople.Count);
        }
        [Fact]
        public void TestPushOverFlow()
        {
            Stack<int> stackCard = new Stack<int>(2);
            stackCard.Push(2);
            stackCard.Push(2);
            Action act = () => stackCard.Push(2);
            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(act);
            Assert.Equal("Переполнение стека!", exception.Message);
        }
        [Fact]
        public void TestPush()
        {
            Stack<int> stackCard = new Stack<int>(2);
            stackCard.Push(12);
            Assert.Equal(12, stackCard.Top());

        }
        [Fact]
        public void TestIsEmptyTrue()
        {
            Stack<string> stackNames = new Stack<string>(2);
            Assert.True(stackNames.IsEmpty);
        }
        [Fact]
        public void TestIsEmptyFalse()
        {
            Stack<string> stackNames = new Stack<string>(2);
            stackNames.Push("Alexander");
            Assert.False(stackNames.IsEmpty);
        }
        [Fact]
        public void TestTopIsEmpty()
        {
            Stack<int> stackCard = new Stack<int>(2);
            Action act = () => stackCard.Top();
            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(act);
            Assert.Equal("Стек пуст!", exception.Message);
        }
        [Fact]
        public void TestTop()
        {
            Stack<int> stackCard = new Stack<int>(2);
            stackCard.Push(323);
            Assert.Equal(323, stackCard.Top());
        }
        [Fact]
        public void TestPopIsEmpty()
        {
            Stack<int> stackCard = new Stack<int>(2);
            Action act = () => stackCard.Pop();
            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(act);
            Assert.Equal("Стек пуст!", exception.Message);
        }
        [Fact]
        public void TestPop()
        {
            Stack<int> stackCard = new Stack<int>(2);
            stackCard.Push(2);
            stackCard.Push(32);
            Assert.Equal(32, stackCard.Pop());
            Assert.Equal(2, stackCard.Top());
        }
       
    }
}