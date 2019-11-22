using System;
using System.Collections;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Open_Lab_05._10
{
    [TestFixture]
    public class Tests
    {

        private Challenge challenge;

        private const int RandSeed = 510510510;
        private const int RandTestCasesCount = 96;

        [OneTimeSetUp]
        public void Init() => challenge = new Challenge();

        [TestCase(152, 10)]
        [TestCase(832, 48)]
        [TestCase(19, 9)]
        [TestCase(133, 9)]
        [TestCaseSource(nameof(GetRandom))]
        public void ChallengeTest(int num, int expected) =>
            Assert.That(challenge.MysteryFunc(num), Is.EqualTo(expected));

        private static IEnumerable GetRandom()
        {
            var rand = new Random(RandSeed);

            for (var t = 0; t < RandTestCasesCount; t++)
            {
                var count = rand.Next(1, 10);

                var digits = new int[count];
                var builder = new StringBuilder(count);

                for (var i = 0; i < count; i++)
                {
                    digits[i] = rand.Next(1, 10);
                    builder.Append(digits[i]);
                }

                yield return new TestCaseData(int.Parse(builder.ToString()), digits.Aggregate((n1, n2) => n1 * n2));
            }
        }

    }
}
