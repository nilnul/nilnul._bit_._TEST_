using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.Linq.Expressions;

namespace nilnul._bit_._TEST_.expr_.call_.binary_.and_.but
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			var e = new nilnul.bit.expr_.call_.binary_.And(
				new bit.expr_.Var_sys("x")
				,
				new nilnul.bit.expr_.call_.unary_.Not1(
					new nilnul.bit.expr_.Var_sys("y")
				)
			);


			Debug.WriteLine(
				e.ToString()
			);

			var truthTable = nilnul.bit.expr_.closed._ReifyX.GetTruthTable_assumeClosed(e);

			var table = truthTable.ToString();

			Debug.Write(
				table
			);



		}
	}
}
