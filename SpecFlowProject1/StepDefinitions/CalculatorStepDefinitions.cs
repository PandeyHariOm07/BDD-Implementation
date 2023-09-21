using Calculator;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]

    public class CalculatorStepDefinitions
    {
        Calc cal = new Calc();
        int num1, num2, output;

        [Given(@"I have (.*) and (.*)")]
        public void GivenIHaveAnd(int p0, int p1)
        {
            num1 = p0;
            num2 = p1;
        }

        [When(@"I call the addnumber member")]
        public void WhenICallTheAddnumberMember()
        {
            output = cal.AddNumber(num1, num2);
        }

        [Then(@"It Should result (.*)")]
        public void ThenItShouldResult(int p0)
        {
            Console.WriteLine(output);
        }
        [Given(@"I have given the values below")]
        public void GivenIHaveGivenTheValuesBelow(Table table)
        {
            foreach(var row in table.Rows)
            {
                num1 = Convert.ToInt32(row["num1"]);
                num2 = Convert.ToInt32(row["num2"]);
            }
        }

        [When(@"I call the Subtract method")]
        public void WhenICallTheSubtractMethod()
        {
            output=cal.Subtract(num1, num2);
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            Assert.AreEqual(p0, output);
        }

        [Given(@"(.*) and (.*)")]
        public void GivenAnd(int p0, int p1)
        {
            num1 = p0;
            num2 = p1;
        }

        [When(@"I Call the Divide Method")]
        public void WhenICallTheDivideMethod()
        {
            output = cal.divide(num1, num2);
        }

        [Then(@"The Result is (.*)")]
        public void ThenTheResultIs(int p0)
        {
            Assert.AreEqual(p0, output);
        }

    }
}
