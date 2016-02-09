﻿using System;
using TechTalk.SpecFlow;
using Xunit;

namespace Calculator.Specs
{
    [Binding]
    public class CalculatorSteps
    {
        private Calculator calculator = new Calculator();

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int operand)
        {
            calculator.Enter(operand);
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            calculator.Add();
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            Assert.Equal(expectedResult, calculator.Result);
        }
    }
}
