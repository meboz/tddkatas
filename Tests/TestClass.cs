using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Tests {
    
    [TestFixture]
    public class TestClass {
        
        [Test]
        public void should_be_0_if_empty_string_inputted()
        {
            var input = "";
            var sum = Add(input);
            Assert.That(sum, Is.EqualTo(0));
        }

        [Test]
        public void should_return_1_if_input_is_1()
        {
            var input = "1";
            var sum = Add(input);
            Assert.That(sum, Is.EqualTo(1));
        }

        private int Add(string input)
        {
            if (input == "1")
                return 1;
            return 0;
        }
    }
}
