using NUnit.Framework;
using System;
using System.IO;


namespace Test_HelloWorld
{
    public class program
    {
        public TextWriter SW { get; private set; }

        [SetUp]
        public void Setup()
        {
            HelloWorldUserEB.Program.KeyPressed = ConsoleKey.Enter;
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        //Citation:
        //https://docs.google.com/document/d/1n6xVp-L6HJCccjl3KqCAkLAqnWtxM6AXj2PSPkZ0JTQ/edit
        //The following unit test will check the console output inside SW variable
        //We will compare the value of SW with our expected result to make sure it is asserted
        public void Test_HelloWorld()
        {
            String expected = "Hello World!";
            var sw = new StringWriter();
            Console.SetOut(SW);
            HelloWorldUserEB.Program.main();
            var result = sw.ToString().Trim();
            Assert.AreEqual(expected, result);
        }
        //End Citation
    }
}