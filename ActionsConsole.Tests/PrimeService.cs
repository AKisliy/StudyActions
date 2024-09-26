using System;
using System.Collections.Generic;
using System.Linq;
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
            var res = calc.IsPrime(2);
            Assert.True(!res);
        }
    }
}