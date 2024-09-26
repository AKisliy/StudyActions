using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Xunit;

namespace ActionsConsole.Tests
{
    public class PrimeService
    {
        [Fact]
        public void IsPrimeShould()
        {
            Calculator calc = new Calculator();
            var res = calc.IsPrime(4);
            Assert.True(!res);
        }

        [Fact]
        public void AddShould()
        {
            Calculator calc = new Calculator();
            int res = calc.Add(10, 5);
            Assert.True(res == 15);
        }
    }
}