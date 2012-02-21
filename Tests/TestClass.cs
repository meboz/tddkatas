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
        [TestCase("1,2",3)]
        [TestCase("1,2,3",6)]
        public void should_be_0_if_empty_string_inputted(string input, int expectedSum)
        {
            var sum = Add(input);
            Assert.That(sum, Is.EqualTo(expectedSum));
        }


        private int Add(string input)
        {
            if(input == "")
                return 0;

            var iInput = 0;

            if (int.TryParse(input, out iInput))
                return iInput;

            var parts = input.Split(',');

            foreach (var part in parts)
            {
                iInput += int.Parse(part);
            }

            return iInput;
        }
    }
}
