using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace nilnul._bit_._TEST_.of_.vec.set.be_.complete_.ofDelta9sect
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var builder = new nilnul.bit.op.set.be_.complete_.byCompoFunc_.AssumeArityNonpoly(
				nilnul.bit.op_.binary_.Xor.Singleton
				,
				nilnul.bit.op_.binary_.Min.Singleton
			);
			var computed=builder.compute();
			Assert.IsFalse(
				computed
			);



		}



	}
}
