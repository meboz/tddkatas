﻿using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace Tests {
    
    [TestFixture]
    public class TestClass {
        
        [TestCase("",0)]
        
        [TestCase("0",0)]
        [TestCase("1",1)]
        [TestCase("2",2)]
        
        [TestCase("1,2",3)]

        [TestCase("1,2,3",6)]
        [TestCase("1\n,2,3",6)]
        [TestCase("1:2:3",6)]
        [TestCase("1::2::3",6)]
        [TestCase("1:::2:::3",6)]
        [TestCase("1;;;2;;;3",6)]
        [TestCase("11;;;2;;;3",16)]
        public void should_be_0_if_empty_string_inputted(string input, int expectedSum)
        {
            var sum = new Calculator().Add(input);
            Assert.That(sum, Is.EqualTo(expectedSum));
        }

        [Test]
        public void does_int_parse_remove_newline_chars()
        {
            Assert.That(int.Parse("\n23"), Is.EqualTo(23));
            Assert.That(int.Parse("23\n"), Is.EqualTo(23));
        }

       

        
    }

    public class Calculator
    {
        public int Add(string input) {
            var regex = Regex();
            var matches = regex.Matches(input);

            var sum = 0;

            foreach (Match match in matches) {
                sum += int.Parse(match.Value);
            }

            return sum;
        }

        private static Regex Regex()
        {
            var regex = new Regex(@"(\d+)");
            return regex;
        }
    }
}
