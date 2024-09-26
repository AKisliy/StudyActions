using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ActionsConsole
{
    public class Calculator
    {
        public bool IsPrime(int num)
        {
            if (num == 1)
                return false;
            for (int i = 2; i < num; ++i)
                if (num % i == 0)
                    return false;
            return true;
        }

        public int Add(int x, int y)
        {
            return x + y;
        }
    }
}