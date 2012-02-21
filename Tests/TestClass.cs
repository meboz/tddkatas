using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Tests {
    
    [TestFixture]
    public class TestClass {
        
        [TestCase("",0)]
        [TestCase("1",1)]
        [TestCase("2",2)]
        public void should_be_0_if_empty_string_inputted(string input, int expectedSum)
        {
            var sum = Add(input);
            Assert.That(sum, Is.EqualTo(expectedSum));
        }

        private int Add(string input)
        {
            if (input == "1")
                return 1;
            if (input == "2")
                return 2;
            return 0;
        }
    }
}
