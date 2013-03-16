using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace FiboLinq
{
	public class Startup
    {
        public async Task<object> FindByDigits(object digits)
        {
            return Query().First(x => x.Digits == (int)digits);
        }

        public IEnumerable<Term> Query()
        {
            int i = 1;
            BigInteger a = 0, b = 1;

            while (true)
            {
                var temp = a;
                a = b;
                b = temp + b;

                var l = Math.Floor(BigInteger.Log10(a) + 1);
                yield return new Term { Number = i++, Value = a, Digits = l };
            }
        }

        public class Term
        {
            public int Number { get; set; }
            public double Digits { get; set; }
            public BigInteger Value { get; set; }
        }
    }
}