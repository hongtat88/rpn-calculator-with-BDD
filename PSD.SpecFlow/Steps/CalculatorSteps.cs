using FluentAssertions;
using TechTalk.SpecFlow;

namespace PSD.SpecFlow.Steps
{
    [Binding]
    public class CalculatorSteps
    {
        private readonly Calculator _calculator = new Calculator();
        private string _result;
        private string _input;

        [Given(@"the input is (.*)")]
        public void GivenTheInputIs(string input)
        {
            _input = input;
        }

        [When(@"the inputs are calculated")]
        public void WhenTheInputsAreCalculated()
        {
            _result = _calculator.Evaluate(_input);
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(string result)
        {
            _result.Should().Be(result);
        }
    }
}
