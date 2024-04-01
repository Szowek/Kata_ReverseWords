namespace Kata
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class Tests
    {
        [Test]
        public void SplitTest()
        {
            var testString = "this is a test";
            var result = Kata.Split(testString, ' ');

            Assert.AreEqual("test", result[3]);
            Assert.AreEqual("a", result[2]);
            Assert.AreEqual("is", result[1]);
            Assert.AreEqual("this", result[0]);
        }

        [Test]
        public void BasicTests()
        {
            Assert.AreEqual("world! hello", Kata.ReverseWords("hello world!"));
            Assert.AreEqual("this like speak doesn't yoda", Kata.ReverseWords("yoda doesn't speak like this"));
            Assert.AreEqual("foobar", Kata.ReverseWords("foobar"));
            Assert.AreEqual("kata editor", Kata.ReverseWords("editor kata"));
            Assert.AreEqual("boat your row row row", Kata.ReverseWords("row row row your boat"));
            Assert.AreEqual("", Kata.ReverseWords(""));
        }
    }
}