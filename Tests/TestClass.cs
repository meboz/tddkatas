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

        private int Add(string input)
        {
            throw new NotImplementedException();
        }
    }
}
