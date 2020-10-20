using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace calculator.logic.unitTest
{
    [TestFixture]
    public class EvaluatorTest
    {
        [TestCase("1 2 + 3 +", 6)]
        [TestCase("1 2 + 3 *", 9)]
        [TestCase("3 4 2 * 1 5 - 2 3 ^ ^ / +", 3.0001220703125)]
        public void testEvaluation(string input, double expected)
        {
            double actual = Evaluator.Eval(input);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase("3 3 3 + ^", "3 ^ 6\r\n729")]
        [TestCase("3 4 2 * 1 5 - 2 3 ^ ^ / +", "3 + 8 / ( 1 - 5 ) ^ 2 ^ 3\r\n3 + 8 / -4 ^ 2 ^ 3\r\n3 + 8 / -4 ^ 8\r\n3 + 8 / 65536\r\n3 + 0.0001220703125\r\n3.0001220703125")]
        public void testEvaluationSBS(string input, string expected)
        {
            string actual = Evaluator.Eval_stepByStep(input);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
