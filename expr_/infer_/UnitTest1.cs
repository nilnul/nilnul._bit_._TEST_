using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace nilnul.bit._test._expr_.expr_.infer_
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void InferTest()
		{
			var x = nilnul.bit.expr_.infer_.A_le_B_le_C___A_le_B__le__A_le_C.Singleton;
			Debug.WriteLine(x);

			Debug.WriteLine(
				nilnul.bit.expr_.infer_.A__B_le_A.Singleton
			);
			Debug.WriteLine(
				nilnul.bit.expr_.infer_.ModusPonens.Singleton
			);

		}
	}
}
