using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace nilnul._bit_._TEST_.op_.binary.be_.associative.of_.nand
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var value = nilnul.bit.op_.binary.be_._AssociativeX.Be(
				nilnul.bit.op_.binary_.Nand.Singleton
			);

			Debug.WriteLine(
				value
			);

			Assert.IsTrue(value);
		}
	}
}
