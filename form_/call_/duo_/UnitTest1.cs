using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace nilnul.bit._test.form_.call_.duo_
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void OneNandOne()
		{
		

			var form = new nilnul.bit.form_.call_.Duo( nilnul.bit.combine_.Nand.Singleton, 1,1);
			Debug.Assert(
				form.eval()==false
			);


		}
	}
}
