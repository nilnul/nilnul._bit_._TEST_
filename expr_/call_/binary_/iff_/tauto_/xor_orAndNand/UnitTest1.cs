using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.Linq.Expressions;

namespace nilnul._bit_._TEST_.expr_.call_.binary_.iff_.tauto_.xor_orAndNand
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var e = new nilnul.bit.expr_.call_.binary_.iff_.tauto_.Xor_OrAndNand(
				new nilnul.bit.expr_.Var_sys("x")
				,
				new bit.expr_.Var_sys("y")
			);


			Debug.WriteLine(
				e.ToString()
			);


		}
	}
}
