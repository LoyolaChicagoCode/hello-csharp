using System;
using NUnit.Framework;
using NUnit.Framework.SyntaxHelpers;

namespace HelloCSharp
{
	[TestFixture]
	public class HelloNUnit
	{
		[Test]
		public void TestPass() // assertion holds
		{
			// arrange
			const int i = 1, j = 1;
			// act
			var r = i + j;
			// assert
			Assert.That(r, Is.EqualTo(2));
		}

		[Test]
		public void TestFail() // assertion fails
		{
			// arrange
			const int i = 1, j = 1;
			// act
			var r = i + j;
			// assert
			Assert.That(r, Is.EqualTo(3));
		}
	
		[Test]
		public void TestError() // error occurs before testing assertion
		{
			// arrange
			const int i = 1;
			var j = 1;
			if (true) j = 0;
			// act
			var r = i / j;
			// assert
			Assert.That(r, Is.EqualTo(2));
		}

		[Test, Ignore]
		public void TestIgnore() // test is not run
		{
			// arrange
			const int i = 1;
			var j = 1;
			if (true) j = 0;
			// act
			var r = i / j;
			// assert
			Assert.That(r, Is.EqualTo(2));
		}

		[Test, ExpectedException("System.DivideByZeroException")]
		public void TestErrorExpected () // test fails if error does not occur
		{
			// arrange
			const int i = 1;
			var j = 1;
			if (true) j = 0;
			// act
			var r = i / j;
			// assert
			Assert.That (r, Is.EqualTo (2));
		}
	}
}
