using MaxNumber;
using NUnit.Framework;

namespace MaxNumberTests
{

	[TestFixture]
	public class MaxNumberCalculatorTests
	{
		private MaxNumberCalculator _calculator;

		[SetUp]
		public void Setup()
		{
			_calculator = new MaxNumberCalculator();
		}

		[Test]
		public void Single_Item_Array_Returns_Value()
		{
			var values = new[] {1};
			var result = _calculator.GetMaxNumber(values);
			Assert.AreEqual(1, result);
		}

		[Test]
		public void Same_Values_Returns_Max()
		{
			var values = new[] {1, 1};
			var result = _calculator.GetMaxNumber(values);
			Assert.AreEqual(1, result);
		}

		[Test]
		public void Different_Values_Returns_Max()
		{
			var values = new[] { 1, 2 };
			var result = _calculator.GetMaxNumber(values);
			Assert.AreEqual(2, result);
		}

		[Test]
		public void Negative_Numbers_Returns_Max()
		{
			var values = new[] { -1, -2 };
			var result = _calculator.GetMaxNumber(values);
			Assert.AreEqual(-1, result);
		}

		[Test]
		public void Negative_And_Positive_Numbers_Returns_Max()
		{
			var values = new[] { -1, -2, 0, 1, 2, 3 };
			var result = _calculator.GetMaxNumber(values);
			Assert.AreEqual(3, result);
		}

		[Test]
		public void Out_Of_Order_Numbers_Returns_Max()
		{
			var values = new[] { 10, 2, 49, -129, 1908, 345099234, 32, 123, -93, 345, 334, 5, 452, 34, 23, 45 };
			var result = _calculator.GetMaxNumber(values);
			Assert.AreEqual(345099234, result);
		}
	}
}
