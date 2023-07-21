using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.Linq.Expressions;

namespace nilnul._bit_._TEST_.expr_.call_.binary_.iff_.plain_.absorption
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var e = new nilnul.bit.expr_.plain_.equiv_.tauto_.bivar_.Absorption();
				


			Debug.WriteLine(
				e.ToString()
			);

			e.assert();


		}
	}
}
