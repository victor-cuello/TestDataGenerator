using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Core.Test.Model;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using NUnit.Framework.Internal.Builders;

namespace Core.Test.Model
{
    internal static class RangeTest

    {
        [TestFixture]
        internal sealed class EqualsMessage
        {
            [TestCase('[',2,5,'[')]
            [TestCase(']',2,5,']')]
            [TestCase('[',2,5,']')]
            public void RangeTest(char initialCondition, int startValue, int endValue, char lastCondition)
            {                
                Range range = new Range();
                 range.GenerateTestRange(initialCondition,startValue,endValue,lastCondition);

                var value =  range.GenerateTestRange(initialCondition,startValue,endValue,lastCondition);

                System.Diagnostics.Debug.WriteLine(value);

                Assert.That(range.GenerateTestRange(initialCondition,startValue,endValue,lastCondition), Is.Not.Empty);
            }

            [TestCase()]
            public void ValidateConsoleOutput()
            {
                using (StringWriter sw = new StringWriter())
                {
                    Console.SetOut(sw);
                    
                    //ConsoleUser cu = new ConsoleUser();
                    //cu.DoWork();

                    //string expected = string.Format("Ploeh{0}", Environment.NewLine);
                    //Assert.AreEqual<string>(expected, sw.ToString());
                }
            }
        }
    }
}
